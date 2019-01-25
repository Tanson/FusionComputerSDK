using System;
using System.Collections.Generic;
using FuctionComputerSDK.DataType;

namespace FuctionComputerSDK.Utils
{
	// Token: 0x0200000C RID: 12
	public class ClientCacheBean
	{
		// Token: 0x06000080 RID: 128 RVA: 0x000028A8 File Offset: 0x00000AA8
		public static void saveAuthCache(ClientProviderBean bean, string tokenId)
		{
			string key = bean.serverUrl + bean.userName;
			if (0 == ClientCacheBean.tokenMap.Count)
			{
				ClientCacheBean.tokenMap.Add(key, tokenId);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000028EC File Offset: 0x00000AEC
		public static string getAuthToken(ClientProviderBean bean)
		{
			string key = bean.serverUrl + bean.userName;
			string result = null;
			if (0 != ClientCacheBean.tokenMap.Count)
			{
				result = ClientCacheBean.tokenMap[key];
			}
			return result;
		}

		// Token: 0x0400003B RID: 59
		private static Dictionary<string, string> tokenMap = new Dictionary<string, string>();
	}
}
