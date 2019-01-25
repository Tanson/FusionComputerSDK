using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000003 RID: 3
	public class ListDataStoresResp : SDKCommonResp
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000020EC File Offset: 0x000002EC
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002103 File Offset: 0x00000303
		public int? total { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000210C File Offset: 0x0000030C
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002123 File Offset: 0x00000323
		public List<DataStoreInfo> datastores { get; set; }
	}
}
