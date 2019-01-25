using System;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.CommonModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x0200003C RID: 60
	public class AuthenticateResource
	{
		// Token: 0x06000308 RID: 776 RVA: 0x00006B30 File Offset: 0x00004D30
		private AuthenticateResource()
		{
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00006B3C File Offset: 0x00004D3C
		public static AuthenticateResource GetInstance(ClientProviderBean bean)
		{
			if (null == AuthenticateResource.instance)
			{
				AuthenticateResource.instance = new AuthenticateResource();
			}
			AuthenticateResource.instance.init(bean);
			return AuthenticateResource.instance;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00006B7C File Offset: 0x00004D7C
		private void init(ClientProviderBean arg)
		{
			if (null == arg)
			{
				this.bean = new ClientProviderBean();
			}
			else
			{
				this.bean = arg;
			}
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public LoginResp Login(string userName, string password)
		{
			this.bean.userName = userName;
			string text = RestClientUtil.loginRequest(userName, password, this.bean, "Login");
			AuthenticateResource.log.Info("Login result : " + text);
			return JsonConvert.DeserializeObject<LoginResp>(text);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00006C00 File Offset: 0x00004E00
		public SDKCommonResp Logout()
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("DELETE", "/service/session", null, this.bean, "Logout");
			AuthenticateResource.log.Info("Logout result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x0400015F RID: 351
		private static AuthenticateResource instance = null;

		// Token: 0x04000160 RID: 352
		private ClientProviderBean bean;

		// Token: 0x04000161 RID: 353
		private static ILog log = LogManager.GetLogger(typeof(AuthenticateResource));
	}
}
