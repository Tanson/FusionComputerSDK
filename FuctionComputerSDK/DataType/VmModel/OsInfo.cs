using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000054 RID: 84
	public class OsInfo
	{
		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x000082B4 File Offset: 0x000064B4
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x000082CB File Offset: 0x000064CB
		public int? id { get; set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x000082D4 File Offset: 0x000064D4
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x000082EB File Offset: 0x000064EB
		public string versionDes { get; set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x000082F4 File Offset: 0x000064F4
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000830B File Offset: 0x0000650B
		public int? cpuQuantityLimit { get; set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00008314 File Offset: 0x00006514
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0000832B File Offset: 0x0000652B
		public int? cpuSocketLimit { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00008334 File Offset: 0x00006534
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x0000834B File Offset: 0x0000654B
		public int? memQuantityLimit { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600040E RID: 1038 RVA: 0x00008354 File Offset: 0x00006554
		// (set) Token: 0x0600040F RID: 1039 RVA: 0x0000836B File Offset: 0x0000656B
		public bool? supportCpuHotPlug { get; set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000410 RID: 1040 RVA: 0x00008374 File Offset: 0x00006574
		// (set) Token: 0x06000411 RID: 1041 RVA: 0x0000838B File Offset: 0x0000658B
		public bool? supportMemHotPlug { get; set; }
	}
}
