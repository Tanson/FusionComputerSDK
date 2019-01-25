using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FuctionComputerSDK.DataType;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.Utils
{
	// Token: 0x02000023 RID: 35
	public class RestClientUtil
	{
		// Token: 0x060001DA RID: 474 RVA: 0x00004F34 File Offset: 0x00003134
		public static string loginRequest(string userName, string password, ClientProviderBean bean, string methodName)
		{
			string result;
			if (!RestClientUtil.CheckParam(bean))
			{
				result = JsonConvert.SerializeObject(new SDKCommonResp
				{
					errorCode = "2130000404"
				});
			}
			else
			{
				string uriString = bean.serverUrl + "/service/session";
				Uri uri = new Uri(uriString);
				RestClientUtil.log.Info(methodName + " request Url :" + uri);
				if (bean.serverUrl.StartsWith("https"))
				{
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(RestClientUtil.CheckValidationResult);
				}
				HttpWebRequest httpWebRequest = WebRequest.Create(uri) as HttpWebRequest;
				httpWebRequest.Proxy = null;
				httpWebRequest.Timeout = 10000;
				httpWebRequest.KeepAlive = false;
				httpWebRequest.Method = "POST";
				httpWebRequest.ContentType = "application/json;charset=UTF-8";
				httpWebRequest.Accept = "application/json;version=6.3;charset=UTF-8";
				httpWebRequest.Headers.Add("Accept-Language", "zh_CN");
				httpWebRequest.Headers.Add("X-Auth-User", userName);
				string value = SHA256Util.SHA256Encrypt(password);
				httpWebRequest.Headers.Add("X-Auth-Key", value);
				byte[] bytes = Encoding.UTF8.GetBytes("{}");
				try
				{
					using (Stream requestStream = httpWebRequest.GetRequestStream())
					{
						requestStream.Write(bytes, 0, bytes.Length);
						requestStream.Flush();
						requestStream.Close();
					}
				}
				catch (Exception ex)
				{
					LogUtil.WriteLog(RestClientUtil.log, "error", string.Format("connect server exception, {0}", ex.ToString()));
				return JsonConvert.SerializeObject(new SDKCommonResp
					{
						errorCode = "2130000404",
						errorDes = string.Format("connect server exception, {0}", ex.ToString())
					});
				}
				HttpWebResponse httpWebResponse = null;
				try
				{
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				}
				catch (WebException ex2)
				{
					httpWebResponse = (HttpWebResponse)ex2.Response;
				}
				if (null == httpWebResponse)
				{
					result = JsonConvert.SerializeObject(new SDKCommonResp
					{
						errorCode = "2130000404"
					});
				}
				else
				{
					string text = "";
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
					{
						text = streamReader.ReadToEnd();
						streamReader.Close();
					}
					if (!string.IsNullOrEmpty(httpWebResponse.Headers["X-Auth-Token"]))
					{
						string tokenId = httpWebResponse.Headers["X-Auth-Token"];
						ClientCacheBean.saveAuthCache(bean, tokenId);
					}
					result = text;
				}
			}
			return result;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00005224 File Offset: 0x00003424
		public static string sendRequest(string methodType, string uri, object requestBody, ClientProviderBean bean, string methodName)
		{
			string result;
			if (!RestClientUtil.CheckParam(bean))
			{
				result = JsonConvert.SerializeObject(new SDKCommonResp
				{
					errorCode = "2130000404"
				});
			}
			else
			{
				Uri uri2 = null;
				try
				{
					uri2 = new Uri(bean.serverUrl + uri);
					RestClientUtil.log.Info(methodName + " request Url :" + uri2);
				}
				catch(Exception ex)
				{
					return JsonConvert.SerializeObject(new SDKCommonResp
					{
						errorCode = "2130000404"
					});
				}
				if (bean.serverUrl.StartsWith("https"))
				{
					ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(RestClientUtil.CheckValidationResult);
				}
				HttpWebRequest httpWebRequest = WebRequest.Create(uri2) as HttpWebRequest;
				httpWebRequest.Proxy = null;
				httpWebRequest.Timeout = 10000;
				httpWebRequest.Method = methodType;
				httpWebRequest.ContentType = "application/json;charset=UTF-8";
				httpWebRequest.Accept = "application/json;version=6.3;charset=UTF-8";
				httpWebRequest.Headers.Add("Accept-Language", "zh_CN");
                string taken = ClientCacheBean.getAuthToken(bean);

                httpWebRequest.Headers.Add("X-Auth-Token", taken);
				if ("POST".Equals(methodType) || "PUT".Equals(methodType))
				{
					string text = JsonUtil.JsonSerializer(requestBody);
					RestClientUtil.log.Info(methodName + " request Body :" + LogUtil.ReplayLog(text));
					byte[] bytes = Encoding.UTF8.GetBytes(text);
					try
					{
						using (Stream requestStream = httpWebRequest.GetRequestStream())
						{
							requestStream.Write(bytes, 0, bytes.Length);
							requestStream.Flush();
							requestStream.Close();
						}
					}
					catch (Exception ex)
					{
						LogUtil.WriteLog(RestClientUtil.log, "error", string.Format("connect server exception, {0}", ex.ToString()));
						return JsonConvert.SerializeObject(new SDKCommonResp
						{
							errorCode = "2130000404"
						});
					}
				}
				HttpWebResponse httpWebResponse = null;
				try
				{
					httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
				}
				catch (WebException ex2)
				{
					httpWebResponse = (HttpWebResponse)ex2.Response;
				}
				if (httpWebResponse == null || httpWebResponse.StatusCode == HttpStatusCode.NotFound)
				{
					result = JsonConvert.SerializeObject(new SDKCommonResp
					{
						errorCode = "2130000404"
					});
				}
				else
				{
					string text2 = "";
					using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8")))
					{
						text2 = streamReader.ReadToEnd();
						streamReader.Close();
					}
					if (httpWebResponse.StatusCode == HttpStatusCode.OK && (string.IsNullOrEmpty(text2) || "{}".Equals(text2)))
					{
						SDKCommonResp sdkcommonResp = new SDKCommonResp();
						text2 = JsonConvert.SerializeObject(sdkcommonResp);
					}
					result = text2;
				}
			}
			return result;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00005568 File Offset: 0x00003768
		private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
		{
			return true;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000557C File Offset: 0x0000377C
		private static bool CheckParam(ClientProviderBean bean)
		{
			return bean != null && null != bean.serverUrl && (bean.serverUrl.StartsWith("http://") || bean.serverUrl.StartsWith("https://"));
		}

		// Token: 0x040000D7 RID: 215
		private static ILog log = LogUtil.init<RestClientUtil>();
	}
}
