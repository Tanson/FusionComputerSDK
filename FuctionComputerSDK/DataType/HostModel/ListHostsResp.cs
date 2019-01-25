using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x0200002A RID: 42
	public class ListHostsResp : SDKCommonResp
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000059A0 File Offset: 0x00003BA0
		// (set) Token: 0x0600021F RID: 543 RVA: 0x000059B7 File Offset: 0x00003BB7
		public int? total { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000220 RID: 544 RVA: 0x000059C0 File Offset: 0x00003BC0
		// (set) Token: 0x06000221 RID: 545 RVA: 0x000059D7 File Offset: 0x00003BD7
		public List<HostInfo> hosts { get; set; }
	}
}
