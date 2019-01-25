using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000032 RID: 50
	public class ListHostsReq
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002AE RID: 686 RVA: 0x000065E0 File Offset: 0x000047E0
		// (set) Token: 0x060002AF RID: 687 RVA: 0x000065F7 File Offset: 0x000047F7
		public int? limit { get; set; }

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00006600 File Offset: 0x00004800
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00006617 File Offset: 0x00004817
		public int? offset { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00006620 File Offset: 0x00004820
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00006637 File Offset: 0x00004837
		public string scope { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00006640 File Offset: 0x00004840
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00006657 File Offset: 0x00004857
		public string name { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00006660 File Offset: 0x00004860
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00006677 File Offset: 0x00004877
		public string ip { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00006680 File Offset: 0x00004880
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00006697 File Offset: 0x00004897
		public int? resourceGroupFlag { get; set; }
	}
}
