using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200001C RID: 28
	public class ImportVmTempResp : AsynchrTask
	{
		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000463C File Offset: 0x0000283C
		// (set) Token: 0x06000148 RID: 328 RVA: 0x00004653 File Offset: 0x00002853
		public string urn { get; set; }

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000465C File Offset: 0x0000285C
		// (set) Token: 0x0600014A RID: 330 RVA: 0x00004673 File Offset: 0x00002873
		public string uri { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x0600014C RID: 332 RVA: 0x00004693 File Offset: 0x00002893
		public string serverLeaseUrn { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000469C File Offset: 0x0000289C
		// (set) Token: 0x0600014E RID: 334 RVA: 0x000046B3 File Offset: 0x000028B3
		public string serverLeaseUri { get; set; }
	}
}
