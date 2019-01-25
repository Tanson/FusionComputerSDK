using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000053 RID: 83
	public class ListSitesResp : SDKCommonResp
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000828C File Offset: 0x0000648C
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x000082A3 File Offset: 0x000064A3
		public List<SiteInfo> sites { get; set; }
	}
}
