using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200000E RID: 14
	public class Nic
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00002D18 File Offset: 0x00000F18
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002D2F File Offset: 0x00000F2F
		public string name { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00002D38 File Offset: 0x00000F38
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002D4F File Offset: 0x00000F4F
		public string urn { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00002D58 File Offset: 0x00000F58
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00002D6F File Offset: 0x00000F6F
		public string uri { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00002D78 File Offset: 0x00000F78
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002D8F File Offset: 0x00000F8F
		public string portGroupUrn { get; set; }

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002D98 File Offset: 0x00000F98
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002DAF File Offset: 0x00000FAF
		public string portGroupName { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002DB8 File Offset: 0x00000FB8
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002DCF File Offset: 0x00000FCF
		public string mac { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002DD8 File Offset: 0x00000FD8
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002DEF File Offset: 0x00000FEF
		public string ip { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00002DF8 File Offset: 0x00000FF8
		// (set) Token: 0x0600009A RID: 154 RVA: 0x00002E0F File Offset: 0x0000100F
		public List<string> ips6 { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00002E18 File Offset: 0x00001018
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002E2F File Offset: 0x0000102F
		public int? sequenceNum { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00002E38 File Offset: 0x00001038
		// (set) Token: 0x0600009E RID: 158 RVA: 0x00002E4F File Offset: 0x0000104F
		public int? virtIo { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002E58 File Offset: 0x00001058
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002E6F File Offset: 0x0000106F
		public string ipList { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002E78 File Offset: 0x00001078
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002E8F File Offset: 0x0000108F
		public int? nicType { get; set; }
	}
}
