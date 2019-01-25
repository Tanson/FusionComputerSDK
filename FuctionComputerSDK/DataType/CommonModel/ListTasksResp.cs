using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000015 RID: 21
	public class ListTasksResp : SDKCommonResp
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00003570 File Offset: 0x00001770
		// (set) Token: 0x06000115 RID: 277 RVA: 0x00003587 File Offset: 0x00001787
		public int? total { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000116 RID: 278 RVA: 0x00003590 File Offset: 0x00001790
		// (set) Token: 0x06000117 RID: 279 RVA: 0x000035A7 File Offset: 0x000017A7
		public List<TaskInfo> tasks { get; set; }
	}
}
