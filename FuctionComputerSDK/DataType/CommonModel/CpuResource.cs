using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200004E RID: 78
	public class CpuResource
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00007EC4 File Offset: 0x000060C4
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00007EDB File Offset: 0x000060DB
		public int? totalSizeMHz { get; set; }

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00007EE4 File Offset: 0x000060E4
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00007EFB File Offset: 0x000060FB
		public int? allocatedSizeMHz { get; set; }
	}
}
