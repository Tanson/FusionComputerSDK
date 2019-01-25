using System;
using System.Text;
using log4net;

namespace FuctionComputerSDK.Utils
{
	// Token: 0x0200003F RID: 63
	public class LogUtil
	{
		// Token: 0x06000322 RID: 802 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public static ILog init<T>()
		{
			return LogManager.GetLogger(typeof(T));
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00006DC4 File Offset: 0x00004FC4
		public static void WriteLog(ILog log, string logLevel, string logBody)
		{
			if ("error".Equals(logLevel))
			{
				log.Error(logBody);
			}
			else
			{
				log.Info(logBody);
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00006DFC File Offset: 0x00004FFC
		public static string ReplayLog(string srcLog)
		{
			string result;
			if (srcLog != null && (srcLog.Contains("password") || srcLog.Contains("Password")))
			{
				StringBuilder stringBuilder = new StringBuilder(srcLog);
				string text = srcLog;
				bool flag = false;
				foreach (string str in LogUtil.sensitiveWords)
				{
					string text2 = "\"" + str + "\":\"";
					int num = 0;
					while (text.Contains(text2))
					{
						StringBuilder stringBuilder2 = new StringBuilder();
						flag = true;
						stringBuilder2.Append(text.Substring(0, text.IndexOf(text2))).Append(text2).Append(LogUtil.replaceWord).Append("\"");
						num++;
						text = text.Substring(text.IndexOf(text2));
						text = text.Substring(text2.Length);
						if (text.IndexOf("\"") != -1)
						{
							text = text.Substring(text.IndexOf("\"") + 1);
						}
						if (1 == num)
						{
							stringBuilder = stringBuilder2;
						}
						else
						{
							stringBuilder = stringBuilder.Append(stringBuilder2);
						}
					}
					if (flag)
					{
						text = stringBuilder.Append(text).ToString();
						flag = false;
					}
				}
				result = stringBuilder.ToString();
			}
			else
			{
				result = srcLog;
			}
			return result;
		}

		// Token: 0x0400016B RID: 363
		private static string replaceWord = "******";

		// Token: 0x0400016C RID: 364
		private static string[] sensitiveWords = new string[]
		{
			"password",
			"oldPassword",
			"bmcPassword",
			"vncPassword",
			"vncOldPassword",
			"domainPassword"
		};
	}
}
