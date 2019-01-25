using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200002F RID: 47
	public class Disk
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600027F RID: 639 RVA: 0x00006308 File Offset: 0x00004508
		// (set) Token: 0x06000280 RID: 640 RVA: 0x0000631F File Offset: 0x0000451F
		public string pciType { get; set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000281 RID: 641 RVA: 0x00006328 File Offset: 0x00004528
		// (set) Token: 0x06000282 RID: 642 RVA: 0x0000633F File Offset: 0x0000453F
		public int? sequenceNum { get; set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000283 RID: 643 RVA: 0x00006348 File Offset: 0x00004548
		// (set) Token: 0x06000284 RID: 644 RVA: 0x0000635F File Offset: 0x0000455F
		public string volumeUrn { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00006368 File Offset: 0x00004568
		// (set) Token: 0x06000286 RID: 646 RVA: 0x0000637F File Offset: 0x0000457F
		public string volumeUuid { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00006388 File Offset: 0x00004588
		// (set) Token: 0x06000288 RID: 648 RVA: 0x0000639F File Offset: 0x0000459F
		public int? quantityGB { get; set; }

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000289 RID: 649 RVA: 0x000063A8 File Offset: 0x000045A8
		// (set) Token: 0x0600028A RID: 650 RVA: 0x000063BF File Offset: 0x000045BF
		public bool? isDataCopy { get; set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600028B RID: 651 RVA: 0x000063C8 File Offset: 0x000045C8
		// (set) Token: 0x0600028C RID: 652 RVA: 0x000063DF File Offset: 0x000045DF
		public string datastoreUrn { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600028D RID: 653 RVA: 0x000063E8 File Offset: 0x000045E8
		// (set) Token: 0x0600028E RID: 654 RVA: 0x000063FF File Offset: 0x000045FF
		public bool? isThin { get; set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600028F RID: 655 RVA: 0x00006408 File Offset: 0x00004608
		// (set) Token: 0x06000290 RID: 656 RVA: 0x0000641F File Offset: 0x0000461F
		public bool? indepDisk { get; set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000291 RID: 657 RVA: 0x00006428 File Offset: 0x00004628
		// (set) Token: 0x06000292 RID: 658 RVA: 0x0000643F File Offset: 0x0000463F
		public bool? persistentDisk { get; set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000293 RID: 659 RVA: 0x00006448 File Offset: 0x00004648
		// (set) Token: 0x06000294 RID: 660 RVA: 0x0000645F File Offset: 0x0000465F
		public string storageType { get; set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000295 RID: 661 RVA: 0x00006468 File Offset: 0x00004668
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000647F File Offset: 0x0000467F
		public int? volType { get; set; }

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00006488 File Offset: 0x00004688
		// (set) Token: 0x06000298 RID: 664 RVA: 0x0000649F File Offset: 0x0000469F
		public long? maxReadBytes { get; set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000299 RID: 665 RVA: 0x000064A8 File Offset: 0x000046A8
		// (set) Token: 0x0600029A RID: 666 RVA: 0x000064BF File Offset: 0x000046BF
		public long? maxWriteBytes { get; set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600029B RID: 667 RVA: 0x000064C8 File Offset: 0x000046C8
		// (set) Token: 0x0600029C RID: 668 RVA: 0x000064DF File Offset: 0x000046DF
		public long? maxReadRequest { get; set; }

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600029D RID: 669 RVA: 0x000064E8 File Offset: 0x000046E8
		// (set) Token: 0x0600029E RID: 670 RVA: 0x000064FF File Offset: 0x000046FF
		public long? maxWriteRequest { get; set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00006508 File Offset: 0x00004708
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0000651F File Offset: 0x0000471F
		public string type { get; set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00006528 File Offset: 0x00004728
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x0000653F File Offset: 0x0000473F
		public string diskName { get; set; }

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x00006548 File Offset: 0x00004748
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x0000655F File Offset: 0x0000475F
		public long? ioWeight { get; set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00006568 File Offset: 0x00004768
		// (set) Token: 0x060002A6 RID: 678 RVA: 0x0000657F File Offset: 0x0000477F
		public string datastoreName { get; set; }
	}
}
