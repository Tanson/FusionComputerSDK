using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000007 RID: 7
	public class OsOption
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000022E0 File Offset: 0x000004E0
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000022F7 File Offset: 0x000004F7
		public string osType { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002300 File Offset: 0x00000500
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002317 File Offset: 0x00000517
		public int? osVersion { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002320 File Offset: 0x00000520
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00002337 File Offset: 0x00000537
		public string guestOSName { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002340 File Offset: 0x00000540
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00002357 File Offset: 0x00000557
		public string hostname { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002360 File Offset: 0x00000560
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002377 File Offset: 0x00000577
		public string password { get; set; }
	}
}
