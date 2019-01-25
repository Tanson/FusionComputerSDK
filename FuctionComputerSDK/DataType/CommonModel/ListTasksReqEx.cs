using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200002B RID: 43
	public class ListTasksReqEx
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000059E8 File Offset: 0x00003BE8
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000059FF File Offset: 0x00003BFF
		public int? limit { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00005A08 File Offset: 0x00003C08
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00005A1F File Offset: 0x00003C1F
		public int? offset { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00005A28 File Offset: 0x00003C28
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00005A3F File Offset: 0x00003C3F
		public string scope { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00005A48 File Offset: 0x00003C48
		// (set) Token: 0x0600022A RID: 554 RVA: 0x00005A5F File Offset: 0x00003C5F
		public string type { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00005A68 File Offset: 0x00003C68
		// (set) Token: 0x0600022C RID: 556 RVA: 0x00005A7F File Offset: 0x00003C7F
		public string user { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600022D RID: 557 RVA: 0x00005A88 File Offset: 0x00003C88
		// (set) Token: 0x0600022E RID: 558 RVA: 0x00005A9F File Offset: 0x00003C9F
		public string status { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00005AA8 File Offset: 0x00003CA8
		// (set) Token: 0x06000230 RID: 560 RVA: 0x00005ABF File Offset: 0x00003CBF
		public string startTime { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00005AC8 File Offset: 0x00003CC8
		// (set) Token: 0x06000232 RID: 562 RVA: 0x00005ADF File Offset: 0x00003CDF
		public string finishTime { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00005AE8 File Offset: 0x00003CE8
		// (set) Token: 0x06000234 RID: 564 RVA: 0x00005AFF File Offset: 0x00003CFF
		public List<string> taskUrns { get; set; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00005B08 File Offset: 0x00003D08
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00005B1F File Offset: 0x00003D1F
		public bool? cancelled { get; set; }
	}
}
