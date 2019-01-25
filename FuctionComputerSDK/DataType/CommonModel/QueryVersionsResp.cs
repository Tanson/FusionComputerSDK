using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200004C RID: 76
	public class QueryVersionsResp : SDKCommonResp
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00007DD4 File Offset: 0x00005FD4
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00007DEB File Offset: 0x00005FEB
		public List<Version> versions { get; set; }
	}
}
