using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000024 RID: 36
	public class VncAccessInfo
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x000055F0 File Offset: 0x000037F0
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x00005607 File Offset: 0x00003807
		public string hostIp { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00005610 File Offset: 0x00003810
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x00005627 File Offset: 0x00003827
		public int? vncPort { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x00005630 File Offset: 0x00003830
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x00005647 File Offset: 0x00003847
		public string vncPassword { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x00005650 File Offset: 0x00003850
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x00005667 File Offset: 0x00003867
		public string vncOldPassword { get; set; }
	}
}
