using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000043 RID: 67
	public class ListRightsResp : SDKCommonResp
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00007268 File Offset: 0x00005468
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000727F File Offset: 0x0000547F
		public int? total { get; set; }

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00007288 File Offset: 0x00005488
		// (set) Token: 0x06000355 RID: 853 RVA: 0x0000729F File Offset: 0x0000549F
		public int? itemSize { get; set; }

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000356 RID: 854 RVA: 0x000072A8 File Offset: 0x000054A8
		// (set) Token: 0x06000357 RID: 855 RVA: 0x000072BF File Offset: 0x000054BF
		public List<RightInfo> items { get; set; }
	}
}
