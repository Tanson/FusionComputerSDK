using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200005E RID: 94
	public class PortGroupInfo
	{
		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00008CA4 File Offset: 0x00006EA4
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00008CBB File Offset: 0x00006EBB
		public string urn { get; set; }

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00008CC4 File Offset: 0x00006EC4
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x00008CDB File Offset: 0x00006EDB
		public string uri { get; set; }

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00008CE4 File Offset: 0x00006EE4
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x00008CFB File Offset: 0x00006EFB
		public string name { get; set; }

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00008D04 File Offset: 0x00006F04
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00008D1B File Offset: 0x00006F1B
		public string description { get; set; }

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00008D24 File Offset: 0x00006F24
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x00008D3B File Offset: 0x00006F3B
		public bool? isDhcpIsolation { get; set; }

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00008D44 File Offset: 0x00006F44
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00008D5B File Offset: 0x00006F5B
		public bool? isIpMacBind { get; set; }

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00008D64 File Offset: 0x00006F64
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00008D7B File Offset: 0x00006F7B
		public int? portType { get; set; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00008D84 File Offset: 0x00006F84
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00008D9B File Offset: 0x00006F9B
		public int? vlanId { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00008DA4 File Offset: 0x00006FA4
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00008DBB File Offset: 0x00006FBB
		public int? vxlanId { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00008DC4 File Offset: 0x00006FC4
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00008DDB File Offset: 0x00006FDB
		public string vlanRange { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00008DE4 File Offset: 0x00006FE4
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00008DFB File Offset: 0x00006FFB
		public int? txLimit { get; set; }

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00008E04 File Offset: 0x00007004
		// (set) Token: 0x060004BF RID: 1215 RVA: 0x00008E1B File Offset: 0x0000701B
		public int? txPeakLimit { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00008E24 File Offset: 0x00007024
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x00008E3B File Offset: 0x0000703B
		public int? txBurstSize { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00008E44 File Offset: 0x00007044
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00008E5B File Offset: 0x0000705B
		public int? txWeight { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00008E64 File Offset: 0x00007064
		// (set) Token: 0x060004C5 RID: 1221 RVA: 0x00008E7B File Offset: 0x0000707B
		public int? priority { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00008E84 File Offset: 0x00007084
		// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00008E9B File Offset: 0x0000709B
		public int? rxLimit { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00008EA4 File Offset: 0x000070A4
		// (set) Token: 0x060004C9 RID: 1225 RVA: 0x00008EBB File Offset: 0x000070BB
		public int? rxPeakLimit { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00008EC4 File Offset: 0x000070C4
		// (set) Token: 0x060004CB RID: 1227 RVA: 0x00008EDB File Offset: 0x000070DB
		public int? rxBurstSize { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00008EE4 File Offset: 0x000070E4
		// (set) Token: 0x060004CD RID: 1229 RVA: 0x00008EFB File Offset: 0x000070FB
		public string subnetUrn { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00008F04 File Offset: 0x00007104
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00008F1B File Offset: 0x0000711B
		public string multicastIp { get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00008F24 File Offset: 0x00007124
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00008F3B File Offset: 0x0000713B
		public int? arpBcstSuppress { get; set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00008F44 File Offset: 0x00007144
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00008F5B File Offset: 0x0000715B
		public int? ipBcstSuppress { get; set; }
	}
}
