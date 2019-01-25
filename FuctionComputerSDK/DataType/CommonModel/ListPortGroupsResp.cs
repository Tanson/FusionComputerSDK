using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000018 RID: 24
	public class ListPortGroupsResp : SDKCommonResp
	{
		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00003BFC File Offset: 0x00001DFC
		// (set) Token: 0x06000128 RID: 296 RVA: 0x00003C13 File Offset: 0x00001E13
		public int? total { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00003C1C File Offset: 0x00001E1C
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00003C33 File Offset: 0x00001E33
		public List<PortGroupInfo> portGroups { get; set; }
	}
}
