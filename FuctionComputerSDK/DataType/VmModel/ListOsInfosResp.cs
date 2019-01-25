using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200000F RID: 15
	public class ListOsInfosResp : SDKCommonResp
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002EA0 File Offset: 0x000010A0
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002EB7 File Offset: 0x000010B7
		public List<OsInfo> windows { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00002EC0 File Offset: 0x000010C0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002ED7 File Offset: 0x000010D7
		public List<OsInfo> linux { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002EE0 File Offset: 0x000010E0
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00002EF7 File Offset: 0x000010F7
		public List<OsInfo> other { get; set; }
	}
}
