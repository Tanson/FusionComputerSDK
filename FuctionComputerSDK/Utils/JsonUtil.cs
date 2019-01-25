using System;
using Newtonsoft.Json;

namespace FuctionComputerSDK.Utils
{
	// Token: 0x02000044 RID: 68
	public class JsonUtil
	{
		// Token: 0x06000359 RID: 857 RVA: 0x000072D0 File Offset: 0x000054D0
		public static string JsonSerializer(object obj)
		{
			return JsonConvert.SerializeObject(obj, new JsonSerializerSettings
			{
              NullValueHandling= NullValueHandling.Ignore
        });
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000072FC File Offset: 0x000054FC
		public static T JsonDeserialize<T>(string jsonString)
		{
			return JsonConvert.DeserializeObject<T>(jsonString);
		}
	}
}
