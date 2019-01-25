using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000035 RID: 53
	public class NicSpecification
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002CF RID: 719 RVA: 0x000067D8 File Offset: 0x000049D8
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x000067EF File Offset: 0x000049EF
		public int? sequenceNum { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x000067F8 File Offset: 0x000049F8
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000680F File Offset: 0x00004A0F
		public string ip { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x00006818 File Offset: 0x00004A18
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000682F File Offset: 0x00004A2F
		public string netmask { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00006838 File Offset: 0x00004A38
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000684F File Offset: 0x00004A4F
		public string gateway { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00006858 File Offset: 0x00004A58
		// (set) Token: 0x060002D8 RID: 728 RVA: 0x0000686F File Offset: 0x00004A6F
		public string setdns { get; set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002D9 RID: 729 RVA: 0x00006878 File Offset: 0x00004A78
		// (set) Token: 0x060002DA RID: 730 RVA: 0x0000688F File Offset: 0x00004A8F
		public string adddns { get; set; }

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002DB RID: 731 RVA: 0x00006898 File Offset: 0x00004A98
		// (set) Token: 0x060002DC RID: 732 RVA: 0x000068AF File Offset: 0x00004AAF
		public int? ipVersion { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000068B8 File Offset: 0x00004AB8
		// (set) Token: 0x060002DE RID: 734 RVA: 0x000068CF File Offset: 0x00004ACF
		public bool? autoConfEnabled6 { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002DF RID: 735 RVA: 0x000068D8 File Offset: 0x00004AD8
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x000068EF File Offset: 0x00004AEF
		public bool? dhcpEnabled6 { get; set; }

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002E1 RID: 737 RVA: 0x000068F8 File Offset: 0x00004AF8
		// (set) Token: 0x060002E2 RID: 738 RVA: 0x0000690F File Offset: 0x00004B0F
		public List<IpAddress6> ipAddress6 { get; set; }

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x00006918 File Offset: 0x00004B18
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x0000692F File Offset: 0x00004B2F
		public string gatewayIpAddr6 { get; set; }

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x00006938 File Offset: 0x00004B38
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x0000694F File Offset: 0x00004B4F
		public string setdns6 { get; set; }

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x00006958 File Offset: 0x00004B58
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x0000696F File Offset: 0x00004B6F
		public string adddns6 { get; set; }
	}
}
