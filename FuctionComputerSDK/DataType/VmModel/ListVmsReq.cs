using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200001F RID: 31
	public class ListVmsReq
	{
		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00004B94 File Offset: 0x00002D94
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00004BAB File Offset: 0x00002DAB
		public int? limit { get; set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00004BB4 File Offset: 0x00002DB4
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00004BCB File Offset: 0x00002DCB
		public int? offset { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00004BD4 File Offset: 0x00002DD4
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00004BEB File Offset: 0x00002DEB
		public string name { get; set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x00004BF4 File Offset: 0x00002DF4
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00004C0B File Offset: 0x00002E0B
		public string scope { get; set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00004C14 File Offset: 0x00002E14
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00004C2B File Offset: 0x00002E2B
		public string group { get; set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00004C34 File Offset: 0x00002E34
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x00004C4B File Offset: 0x00002E4B
		public bool? isTemplate { get; set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00004C54 File Offset: 0x00002E54
		// (set) Token: 0x060001AB RID: 427 RVA: 0x00004C6B File Offset: 0x00002E6B
		public bool? isLinkClone { get; set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00004C74 File Offset: 0x00002E74
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00004C8B File Offset: 0x00002E8B
		public string status { get; set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00004C94 File Offset: 0x00002E94
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00004CAB File Offset: 0x00002EAB
		public string templateUrn { get; set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00004CB4 File Offset: 0x00002EB4
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00004CCB File Offset: 0x00002ECB
		public string ip { get; set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x00004CD4 File Offset: 0x00002ED4
		// (set) Token: 0x060001B3 RID: 435 RVA: 0x00004CEB File Offset: 0x00002EEB
		public string mac { get; set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00004CF4 File Offset: 0x00002EF4
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00004D0B File Offset: 0x00002F0B
		public string vmId { get; set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00004D14 File Offset: 0x00002F14
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00004D2B File Offset: 0x00002F2B
		public string uuid { get; set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00004D34 File Offset: 0x00002F34
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00004D4B File Offset: 0x00002F4B
		public List<string> vmurns { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00004D54 File Offset: 0x00002F54
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00004D6B File Offset: 0x00002F6B
		public int? resourceGroupFlag { get; set; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00004D74 File Offset: 0x00002F74
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00004D8B File Offset: 0x00002F8B
		public int? detail { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00004D94 File Offset: 0x00002F94
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00004DAB File Offset: 0x00002FAB
		public string description { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x00004DB4 File Offset: 0x00002FB4
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x00004DCB File Offset: 0x00002FCB
		public string imcSetting { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00004DD4 File Offset: 0x00002FD4
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x00004DEB File Offset: 0x00002FEB
		public bool? isBindingHost { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x00004DF4 File Offset: 0x00002FF4
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x00004E0B File Offset: 0x0000300B
		public int? vmType { get; set; }
	}
}
