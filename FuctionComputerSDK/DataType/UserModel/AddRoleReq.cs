using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000041 RID: 65
	public class AddRoleReq
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00007018 File Offset: 0x00005218
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000702F File Offset: 0x0000522F
		public string roleName { get; set; }

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00007038 File Offset: 0x00005238
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000704F File Offset: 0x0000524F
		public int? rightType { get; set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00007058 File Offset: 0x00005258
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000706F File Offset: 0x0000526F
		public string description { get; set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00007078 File Offset: 0x00005278
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000708F File Offset: 0x0000528F
		public List<string> popedom { get; set; }
	}
}
