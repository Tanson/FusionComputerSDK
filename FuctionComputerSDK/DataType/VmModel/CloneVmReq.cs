using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000009 RID: 9
	public class CloneVmReq
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000033 RID: 51 RVA: 0x000023F0 File Offset: 0x000005F0
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002407 File Offset: 0x00000607
		public string name { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002410 File Offset: 0x00000610
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002427 File Offset: 0x00000627
		public string description { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002430 File Offset: 0x00000630
		// (set) Token: 0x06000038 RID: 56 RVA: 0x00002447 File Offset: 0x00000647
		public string group { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000039 RID: 57 RVA: 0x00002450 File Offset: 0x00000650
		// (set) Token: 0x0600003A RID: 58 RVA: 0x00002467 File Offset: 0x00000667
		public string location { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002470 File Offset: 0x00000670
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00002487 File Offset: 0x00000687
		public bool? isBindingHost { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002490 File Offset: 0x00000690
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000024A7 File Offset: 0x000006A7
		public VmConfig vmConfig { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600003F RID: 63 RVA: 0x000024B0 File Offset: 0x000006B0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000024C7 File Offset: 0x000006C7
		public OsOption osOptions { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000024D0 File Offset: 0x000006D0
		// (set) Token: 0x06000042 RID: 66 RVA: 0x000024E7 File Offset: 0x000006E7
		public bool? isTemplate { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000024F0 File Offset: 0x000006F0
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002507 File Offset: 0x00000707
		public bool? autoBoot { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00002510 File Offset: 0x00000710
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00002527 File Offset: 0x00000727
		public bool? isLinkClone { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002530 File Offset: 0x00000730
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00002547 File Offset: 0x00000747
		public string regionInfo { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002550 File Offset: 0x00000750
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00002567 File Offset: 0x00000767
		public VmCustomization vmCustomization { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00002570 File Offset: 0x00000770
		// (set) Token: 0x0600004C RID: 76 RVA: 0x00002587 File Offset: 0x00000787
		public string publickey { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002590 File Offset: 0x00000790
		// (set) Token: 0x0600004E RID: 78 RVA: 0x000025A7 File Offset: 0x000007A7
		public string vmData { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000025B0 File Offset: 0x000007B0
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000025C7 File Offset: 0x000007C7
		public string fileName { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000051 RID: 81 RVA: 0x000025D0 File Offset: 0x000007D0
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000025E7 File Offset: 0x000007E7
		public VncAccessInfo vncAccessInfo { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000025F0 File Offset: 0x000007F0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00002607 File Offset: 0x00000807
		public bool? fileMode { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00002627 File Offset: 0x00000827
		public int? drDrillOption { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002630 File Offset: 0x00000830
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00002647 File Offset: 0x00000847
		public string uuid { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00002650 File Offset: 0x00000850
		// (set) Token: 0x0600005A RID: 90 RVA: 0x00002667 File Offset: 0x00000867
		public bool? isMultiDiskSpeedup { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00002670 File Offset: 0x00000870
		// (set) Token: 0x0600005C RID: 92 RVA: 0x00002687 File Offset: 0x00000887
		public List<string> fileNames { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002690 File Offset: 0x00000890
		// (set) Token: 0x0600005E RID: 94 RVA: 0x000026A7 File Offset: 0x000008A7
		public List<string> vmDatas { get; set; }
	}
}
