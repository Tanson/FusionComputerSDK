using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000020 RID: 32
	public class MemResource
	{
		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00004E1C File Offset: 0x0000301C
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00004E33 File Offset: 0x00003033
		public int? totalSizeMB { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00004E3C File Offset: 0x0000303C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00004E53 File Offset: 0x00003053
		public int? allocatedSizeMB { get; set; }
	}
}
