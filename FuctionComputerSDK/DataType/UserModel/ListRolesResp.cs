using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000038 RID: 56
	public class ListRolesResp : SDKCommonResp
	{
		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00006A50 File Offset: 0x00004C50
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x00006A67 File Offset: 0x00004C67
		public int? total { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00006A70 File Offset: 0x00004C70
		// (set) Token: 0x060002FB RID: 763 RVA: 0x00006A87 File Offset: 0x00004C87
		public int? itemSize { get; set; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00006A90 File Offset: 0x00004C90
		// (set) Token: 0x060002FD RID: 765 RVA: 0x00006AA7 File Offset: 0x00004CA7
		public List<RoleInfo> items { get; set; }
	}
}
