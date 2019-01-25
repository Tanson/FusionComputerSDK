using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200002E RID: 46
	public class Memory
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00006260 File Offset: 0x00004460
		// (set) Token: 0x06000275 RID: 629 RVA: 0x00006277 File Offset: 0x00004477
		public int? quantityMB { get; set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000276 RID: 630 RVA: 0x00006280 File Offset: 0x00004480
		// (set) Token: 0x06000277 RID: 631 RVA: 0x00006297 File Offset: 0x00004497
		public int? reservation { get; set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000278 RID: 632 RVA: 0x000062A0 File Offset: 0x000044A0
		// (set) Token: 0x06000279 RID: 633 RVA: 0x000062B7 File Offset: 0x000044B7
		public int? weight { get; set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600027A RID: 634 RVA: 0x000062C0 File Offset: 0x000044C0
		// (set) Token: 0x0600027B RID: 635 RVA: 0x000062D7 File Offset: 0x000044D7
		public int? limit { get; set; }

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600027C RID: 636 RVA: 0x000062E0 File Offset: 0x000044E0
		// (set) Token: 0x0600027D RID: 637 RVA: 0x000062F7 File Offset: 0x000044F7
		public int? memHotPlug { get; set; }
	}
}
