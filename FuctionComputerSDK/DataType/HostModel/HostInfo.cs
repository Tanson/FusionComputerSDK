using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000014 RID: 20
	public class HostInfo
	{
		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000030C8 File Offset: 0x000012C8
		// (set) Token: 0x060000CA RID: 202 RVA: 0x000030DF File Offset: 0x000012DF
		public string urn { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000030E8 File Offset: 0x000012E8
		// (set) Token: 0x060000CC RID: 204 RVA: 0x000030FF File Offset: 0x000012FF
		public string uri { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060000CD RID: 205 RVA: 0x00003108 File Offset: 0x00001308
		// (set) Token: 0x060000CE RID: 206 RVA: 0x0000311F File Offset: 0x0000131F
		public string name { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00003128 File Offset: 0x00001328
		// (set) Token: 0x060000D0 RID: 208 RVA: 0x0000313F File Offset: 0x0000133F
		public string description { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00003148 File Offset: 0x00001348
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x0000315F File Offset: 0x0000135F
		public string ip { get; set; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00003168 File Offset: 0x00001368
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x0000317F File Offset: 0x0000137F
		public string bmcIp { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00003188 File Offset: 0x00001388
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x0000319F File Offset: 0x0000139F
		public string bmcUserName { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000031A8 File Offset: 0x000013A8
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x000031BF File Offset: 0x000013BF
		public string clusterUrn { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x000031C8 File Offset: 0x000013C8
		// (set) Token: 0x060000DA RID: 218 RVA: 0x000031DF File Offset: 0x000013DF
		public string clusterName { get; set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000DB RID: 219 RVA: 0x000031E8 File Offset: 0x000013E8
		// (set) Token: 0x060000DC RID: 220 RVA: 0x000031FF File Offset: 0x000013FF
		public string status { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00003208 File Offset: 0x00001408
		// (set) Token: 0x060000DE RID: 222 RVA: 0x0000321F File Offset: 0x0000141F
		public bool? isMaintaining { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00003228 File Offset: 0x00001428
		// (set) Token: 0x060000E0 RID: 224 RVA: 0x0000323F File Offset: 0x0000143F
		public string multiPathMode { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00003248 File Offset: 0x00001448
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000325F File Offset: 0x0000145F
		public string hostMultiPathMode { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x00003268 File Offset: 0x00001468
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000327F File Offset: 0x0000147F
		public int? memQuantityMB { get; set; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x00003288 File Offset: 0x00001488
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000329F File Offset: 0x0000149F
		public int? cpuQuantity { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x000032A8 File Offset: 0x000014A8
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x000032BF File Offset: 0x000014BF
		public int? cpuMHz { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x000032C8 File Offset: 0x000014C8
		// (set) Token: 0x060000EA RID: 234 RVA: 0x000032DF File Offset: 0x000014DF
		public int? nicQuantity { get; set; }

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060000EB RID: 235 RVA: 0x000032E8 File Offset: 0x000014E8
		// (set) Token: 0x060000EC RID: 236 RVA: 0x000032FF File Offset: 0x000014FF
		public List<string> attachedISOVMs { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060000ED RID: 237 RVA: 0x00003308 File Offset: 0x00001508
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000331F File Offset: 0x0000151F
		public string computeResourceStatics { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00003328 File Offset: 0x00001528
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000333F File Offset: 0x0000153F
		public string ntpIp1 { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000335F File Offset: 0x0000155F
		public string ntpIp2 { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00003368 File Offset: 0x00001568
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000337F File Offset: 0x0000157F
		public string ntpIp3 { get; set; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00003388 File Offset: 0x00001588
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000339F File Offset: 0x0000159F
		public int? ntpCycle { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x000033BF File Offset: 0x000015BF
		public int? physicalCpuQuantity { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x000033C8 File Offset: 0x000015C8
		// (set) Token: 0x060000FA RID: 250 RVA: 0x000033DF File Offset: 0x000015DF
		public int? gpuCapacity { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060000FB RID: 251 RVA: 0x000033E8 File Offset: 0x000015E8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x000033FF File Offset: 0x000015FF
		public int? gpuCapacityReboot { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x060000FE RID: 254 RVA: 0x0000341F File Offset: 0x0000161F
		public string imcSetting { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00003428 File Offset: 0x00001628
		// (set) Token: 0x06000100 RID: 256 RVA: 0x0000343F File Offset: 0x0000163F
		public string maxImcSetting { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00003448 File Offset: 0x00001648
		// (set) Token: 0x06000102 RID: 258 RVA: 0x0000345F File Offset: 0x0000165F
		public CpuResource cpuResource { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x06000104 RID: 260 RVA: 0x0000347F File Offset: 0x0000167F
		public MemResource memResource { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00003488 File Offset: 0x00001688
		// (set) Token: 0x06000106 RID: 262 RVA: 0x0000349F File Offset: 0x0000169F
		public int? gdvmMemory { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000107 RID: 263 RVA: 0x000034A8 File Offset: 0x000016A8
		// (set) Token: 0x06000108 RID: 264 RVA: 0x000034BF File Offset: 0x000016BF
		public int? gdvmMemoryReboot { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000109 RID: 265 RVA: 0x000034C8 File Offset: 0x000016C8
		// (set) Token: 0x0600010A RID: 266 RVA: 0x000034DF File Offset: 0x000016DF
		public int? gsvmMemory { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x0600010B RID: 267 RVA: 0x000034E8 File Offset: 0x000016E8
		// (set) Token: 0x0600010C RID: 268 RVA: 0x000034FF File Offset: 0x000016FF
		public int? gsvmMemoryReboot { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00003508 File Offset: 0x00001708
		// (set) Token: 0x0600010E RID: 270 RVA: 0x0000351F File Offset: 0x0000171F
		public string haState { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000353F File Offset: 0x0000173F
		public string haRole { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00003548 File Offset: 0x00001748
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000355F File Offset: 0x0000175F
		public bool? isFailOverHost { get; set; }
	}
}
