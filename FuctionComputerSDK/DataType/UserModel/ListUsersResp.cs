using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000026 RID: 38
	public class ListUsersResp : SDKCommonResp
	{
		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060001F0 RID: 496 RVA: 0x000056E0 File Offset: 0x000038E0
		// (set) Token: 0x060001F1 RID: 497 RVA: 0x000056F7 File Offset: 0x000038F7
		public int? total { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x00005700 File Offset: 0x00003900
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x00005717 File Offset: 0x00003917
		public int? itemSize { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x00005720 File Offset: 0x00003920
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x00005737 File Offset: 0x00003937
		public List<UserInfo> users { get; set; }
	}
}
