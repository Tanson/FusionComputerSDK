using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000034 RID: 52
	public class DvSwitchInfo
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x00006707 File Offset: 0x00004907
		public string urn { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x00006710 File Offset: 0x00004910
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x00006727 File Offset: 0x00004927
		public string uri { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00006730 File Offset: 0x00004930
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x00006747 File Offset: 0x00004947
		public string name { get; set; }

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00006750 File Offset: 0x00004950
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x00006767 File Offset: 0x00004967
		public string description { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00006770 File Offset: 0x00004970
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x00006787 File Offset: 0x00004987
		public int? type { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002CA RID: 714 RVA: 0x00006790 File Offset: 0x00004990
		// (set) Token: 0x060002CB RID: 715 RVA: 0x000067A7 File Offset: 0x000049A7
		public int? portGroupNum { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002CC RID: 716 RVA: 0x000067B0 File Offset: 0x000049B0
		// (set) Token: 0x060002CD RID: 717 RVA: 0x000067C7 File Offset: 0x000049C7
		public bool? isIgmpSnooping { get; set; }
	}
}
