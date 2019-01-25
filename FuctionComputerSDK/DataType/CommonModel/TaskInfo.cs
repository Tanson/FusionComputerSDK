using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000028 RID: 40
	public class TaskInfo : SDKCommonResp
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00005790 File Offset: 0x00003990
		// (set) Token: 0x060001FD RID: 509 RVA: 0x000057A7 File Offset: 0x000039A7
		public string urn { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060001FE RID: 510 RVA: 0x000057B0 File Offset: 0x000039B0
		// (set) Token: 0x060001FF RID: 511 RVA: 0x000057C7 File Offset: 0x000039C7
		public string uri { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000200 RID: 512 RVA: 0x000057D0 File Offset: 0x000039D0
		// (set) Token: 0x06000201 RID: 513 RVA: 0x000057E7 File Offset: 0x000039E7
		public string type { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000202 RID: 514 RVA: 0x000057F0 File Offset: 0x000039F0
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00005807 File Offset: 0x00003A07
		public string entityUrn { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00005810 File Offset: 0x00003A10
		// (set) Token: 0x06000205 RID: 517 RVA: 0x00005827 File Offset: 0x00003A27
		public string entityName { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00005830 File Offset: 0x00003A30
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00005847 File Offset: 0x00003A47
		public string startTime { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00005850 File Offset: 0x00003A50
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00005867 File Offset: 0x00003A67
		public string finishTime { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00005870 File Offset: 0x00003A70
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00005887 File Offset: 0x00003A87
		public string user { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00005890 File Offset: 0x00003A90
		// (set) Token: 0x0600020D RID: 525 RVA: 0x000058A7 File Offset: 0x00003AA7
		public string status { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600020E RID: 526 RVA: 0x000058B0 File Offset: 0x00003AB0
		// (set) Token: 0x0600020F RID: 527 RVA: 0x000058C7 File Offset: 0x00003AC7
		public int? progress { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000058D0 File Offset: 0x00003AD0
		// (set) Token: 0x06000211 RID: 529 RVA: 0x000058E7 File Offset: 0x00003AE7
		public string reason { get; set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000212 RID: 530 RVA: 0x000058F0 File Offset: 0x00003AF0
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00005907 File Offset: 0x00003B07
		public string reasonDes { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00005910 File Offset: 0x00003B10
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00005927 File Offset: 0x00003B27
		public bool? cancelable { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00005930 File Offset: 0x00003B30
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00005947 File Offset: 0x00003B47
		public bool? cancelled { get; set; }
	}
}
