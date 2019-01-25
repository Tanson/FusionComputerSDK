using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000058 RID: 88
	public class CpuResource
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00008514 File Offset: 0x00006714
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0000852B File Offset: 0x0000672B
		public int? totalSizeMHz { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x00008534 File Offset: 0x00006734
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0000854B File Offset: 0x0000674B
		public int? allocatedSizeMHz { get; set; }
	}
}
