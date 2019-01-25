using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x0200004A RID: 74
	public class AddUserReq
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00007C44 File Offset: 0x00005E44
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00007C5B File Offset: 0x00005E5B
		public string userType { get; set; }

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00007C64 File Offset: 0x00005E64
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00007C7B File Offset: 0x00005E7B
		public string userName { get; set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00007C84 File Offset: 0x00005E84
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00007C9B File Offset: 0x00005E9B
		public string password { get; set; }

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00007CA4 File Offset: 0x00005EA4
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00007CBB File Offset: 0x00005EBB
		public List<string> roles { get; set; }

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00007CC4 File Offset: 0x00005EC4
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00007CDB File Offset: 0x00005EDB
		public string email { get; set; }

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00007CE4 File Offset: 0x00005EE4
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00007CFB File Offset: 0x00005EFB
		public string contact { get; set; }

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00007D04 File Offset: 0x00005F04
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00007D1B File Offset: 0x00005F1B
		public string description { get; set; }

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00007D24 File Offset: 0x00005F24
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00007D3B File Offset: 0x00005F3B
		public int? connectNum { get; set; }

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00007D44 File Offset: 0x00005F44
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00007D5B File Offset: 0x00005F5B
		public int? rightType { get; set; }
	}
}
