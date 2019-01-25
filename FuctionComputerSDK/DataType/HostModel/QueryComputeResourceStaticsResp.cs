using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000012 RID: 18
	public class QueryComputeResourceStaticsResp : SDKCommonResp
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000BF RID: 191 RVA: 0x00003038 File Offset: 0x00001238
		// (set) Token: 0x060000C0 RID: 192 RVA: 0x0000304F File Offset: 0x0000124F
		public CpuResource cpuResource { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x00003058 File Offset: 0x00001258
		// (set) Token: 0x060000C2 RID: 194 RVA: 0x0000306F File Offset: 0x0000126F
		public MemResource memResource { get; set; }
	}
}
