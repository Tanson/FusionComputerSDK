using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200005B RID: 91
	public class ImportVmTempReq
	{
		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x000088AC File Offset: 0x00006AAC
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x000088C3 File Offset: 0x00006AC3
		public string name { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000088CC File Offset: 0x00006ACC
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x000088E3 File Offset: 0x00006AE3
		public string description { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x000088EC File Offset: 0x00006AEC
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00008903 File Offset: 0x00006B03
		public string group { get; set; }

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0000890C File Offset: 0x00006B0C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x00008923 File Offset: 0x00006B23
		public string location { get; set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0000892C File Offset: 0x00006B2C
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00008943 File Offset: 0x00006B43
		public VmConfig vmConfig { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0000894C File Offset: 0x00006B4C
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x00008963 File Offset: 0x00006B63
		public OsOption osOptions { get; set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0000896C File Offset: 0x00006B6C
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00008983 File Offset: 0x00006B83
		public List<FileItem> fileItems { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0000898C File Offset: 0x00006B8C
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000089A3 File Offset: 0x00006BA3
		public string url { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x000089AC File Offset: 0x00006BAC
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x000089C3 File Offset: 0x00006BC3
		public string protocol { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000089CC File Offset: 0x00006BCC
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x000089E3 File Offset: 0x00006BE3
		public string username { get; set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000089EC File Offset: 0x00006BEC
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x00008A03 File Offset: 0x00006C03
		public string password { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00008A0C File Offset: 0x00006C0C
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00008A23 File Offset: 0x00006C23
		public bool? autoBoot { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00008A2C File Offset: 0x00006C2C
		// (set) Token: 0x06000480 RID: 1152 RVA: 0x00008A43 File Offset: 0x00006C43
		public string publickey { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00008A4C File Offset: 0x00006C4C
		// (set) Token: 0x06000482 RID: 1154 RVA: 0x00008A63 File Offset: 0x00006C63
		public VmCustomization vmCustomization { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00008A6C File Offset: 0x00006C6C
		// (set) Token: 0x06000484 RID: 1156 RVA: 0x00008A83 File Offset: 0x00006C83
		public VncAccessInfo vncAccessInfo { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00008A8C File Offset: 0x00006C8C
		// (set) Token: 0x06000486 RID: 1158 RVA: 0x00008AA3 File Offset: 0x00006CA3
		public bool? isTemplate { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00008AAC File Offset: 0x00006CAC
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00008AC3 File Offset: 0x00006CC3
		public string vmId { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00008ACC File Offset: 0x00006CCC
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x00008AE3 File Offset: 0x00006CE3
		public string uuid { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00008AEC File Offset: 0x00006CEC
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x00008B03 File Offset: 0x00006D03
		public bool? isBindingHost { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00008B0C File Offset: 0x00006D0C
		// (set) Token: 0x0600048E RID: 1166 RVA: 0x00008B23 File Offset: 0x00006D23
		public SecurityGroup securityGroupSet { get; set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00008B2C File Offset: 0x00006D2C
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00008B43 File Offset: 0x00006D43
		public bool? recover { get; set; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00008B4C File Offset: 0x00006D4C
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x00008B63 File Offset: 0x00006D63
		public bool? isMultiDiskSpeedup { get; set; }
	}
}
