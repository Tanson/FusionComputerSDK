using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200002C RID: 44
	public class DataStoreInfo
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00005B30 File Offset: 0x00003D30
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00005B47 File Offset: 0x00003D47
		public string urn { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00005B50 File Offset: 0x00003D50
		// (set) Token: 0x0600023B RID: 571 RVA: 0x00005B67 File Offset: 0x00003D67
		public string uri { get; set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600023C RID: 572 RVA: 0x00005B70 File Offset: 0x00003D70
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00005B87 File Offset: 0x00003D87
		public string suUrn { get; set; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00005B90 File Offset: 0x00003D90
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00005BA7 File Offset: 0x00003DA7
		public string suName { get; set; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00005BB0 File Offset: 0x00003DB0
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00005BC7 File Offset: 0x00003DC7
		public string storageType { get; set; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00005BD0 File Offset: 0x00003DD0
		// (set) Token: 0x06000243 RID: 579 RVA: 0x00005BE7 File Offset: 0x00003DE7
		public int? clusterSize { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00005BF0 File Offset: 0x00003DF0
		// (set) Token: 0x06000245 RID: 581 RVA: 0x00005C07 File Offset: 0x00003E07
		public string name { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00005C10 File Offset: 0x00003E10
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00005C27 File Offset: 0x00003E27
		public string status { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00005C30 File Offset: 0x00003E30
		// (set) Token: 0x06000249 RID: 585 RVA: 0x00005C47 File Offset: 0x00003E47
		public int? capacityGB { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00005C50 File Offset: 0x00003E50
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00005C67 File Offset: 0x00003E67
		public int? usedSizeGB { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00005C70 File Offset: 0x00003E70
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00005C87 File Offset: 0x00003E87
		public int? freeSizeGB { get; set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00005C90 File Offset: 0x00003E90
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00005CA7 File Offset: 0x00003EA7
		public bool? isThin { get; set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00005CB0 File Offset: 0x00003EB0
		// (set) Token: 0x06000251 RID: 593 RVA: 0x00005CC7 File Offset: 0x00003EC7
		public int? thinRate { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00005CD0 File Offset: 0x00003ED0
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00005CE7 File Offset: 0x00003EE7
		public int? actualCapacityGB { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00005CF0 File Offset: 0x00003EF0
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00005D07 File Offset: 0x00003F07
		public int? actualFreeSizeGB { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00005D10 File Offset: 0x00003F10
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00005D27 File Offset: 0x00003F27
		public string refreshTime { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00005D30 File Offset: 0x00003F30
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00005D47 File Offset: 0x00003F47
		public string description { get; set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00005D50 File Offset: 0x00003F50
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00005D67 File Offset: 0x00003F67
		public List<string> hosts { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00005D70 File Offset: 0x00003F70
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00005D87 File Offset: 0x00003F87
		public string version { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00005D90 File Offset: 0x00003F90
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00005DA7 File Offset: 0x00003FA7
		public string ioDelay { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00005DB0 File Offset: 0x00003FB0
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00005DC7 File Offset: 0x00003FC7
		public int? expandCount { get; set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00005DD0 File Offset: 0x00003FD0
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00005DE7 File Offset: 0x00003FE7
		public List<string> suIdList { get; set; }

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00005DF0 File Offset: 0x00003FF0
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00005E07 File Offset: 0x00004007
		public string siocFlag { get; set; }

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00005E10 File Offset: 0x00004010
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00005E27 File Offset: 0x00004027
		public List<StorageUnitInfo> storageUnits { get; set; }
	}
}
