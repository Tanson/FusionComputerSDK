using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000051 RID: 81
	public class LoginResp : SDKCommonResp
	{
		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x060003DD RID: 989 RVA: 0x0000805C File Offset: 0x0000625C
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00008073 File Offset: 0x00006273
		public int? validity { get; set; }

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000807C File Offset: 0x0000627C
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00008093 File Offset: 0x00006293
		public List<string> privilegeIds { get; set; }

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000809C File Offset: 0x0000629C
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x000080B3 File Offset: 0x000062B3
		public string userId { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000080BC File Offset: 0x000062BC
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x000080D3 File Offset: 0x000062D3
		public string userName { get; set; }

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x000080DC File Offset: 0x000062DC
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x000080F3 File Offset: 0x000062F3
		public List<string> roleList { get; set; }

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x000080FC File Offset: 0x000062FC
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00008113 File Offset: 0x00006313
		public string rightType { get; set; }
	}
}
