using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000027 RID: 39
	public class MemResource
	{
		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00005748 File Offset: 0x00003948
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x0000575F File Offset: 0x0000395F
		public int? totalSizeMB { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00005768 File Offset: 0x00003968
		// (set) Token: 0x060001FA RID: 506 RVA: 0x0000577F File Offset: 0x0000397F
		public int? allocatedSizeMB { get; set; }
	}
}
