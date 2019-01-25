using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200005A RID: 90
	public class Property
	{
		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00008704 File Offset: 0x00006904
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0000871B File Offset: 0x0000691B
		public string bootOption { get; set; }

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x00008724 File Offset: 0x00006924
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0000873B File Offset: 0x0000693B
		public bool? isEnableHa { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00008744 File Offset: 0x00006944
		// (set) Token: 0x06000451 RID: 1105 RVA: 0x0000875B File Offset: 0x0000695B
		public string vmFaultProcess { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00008764 File Offset: 0x00006964
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x0000877B File Offset: 0x0000697B
		public bool? reoverByHost { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00008784 File Offset: 0x00006984
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x0000879B File Offset: 0x0000699B
		public string clockMode { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000087A4 File Offset: 0x000069A4
		// (set) Token: 0x06000457 RID: 1111 RVA: 0x000087BB File Offset: 0x000069BB
		public bool? isEnableMemVol { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000087C4 File Offset: 0x000069C4
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x000087DB File Offset: 0x000069DB
		public bool? isEnableFt { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x000087E4 File Offset: 0x000069E4
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x000087FB File Offset: 0x000069FB
		public bool? isAutoUpgrade { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00008804 File Offset: 0x00006A04
		// (set) Token: 0x0600045D RID: 1117 RVA: 0x0000881B File Offset: 0x00006A1B
		public bool? attachType { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00008824 File Offset: 0x00006A24
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x0000883B File Offset: 0x00006A3B
		public string gpuShareType { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00008844 File Offset: 0x00006A44
		// (set) Token: 0x06000461 RID: 1121 RVA: 0x0000885B File Offset: 0x00006A5B
		public bool? isReserveResource { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00008864 File Offset: 0x00006A64
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x0000887B File Offset: 0x00006A7B
		public string secureVmType { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00008884 File Offset: 0x00006A84
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x0000889B File Offset: 0x00006A9B
		public bool? isHpet { get; set; }
	}
}
