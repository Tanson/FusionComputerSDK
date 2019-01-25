using System;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000057 RID: 87
	public class ModifyPasswordReq
	{
		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000084AC File Offset: 0x000066AC
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000084C3 File Offset: 0x000066C3
		public string userId { get; set; }

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000084CC File Offset: 0x000066CC
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x000084E3 File Offset: 0x000066E3
		public string oldPassword { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x000084EC File Offset: 0x000066EC
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00008503 File Offset: 0x00006703
		public string password { get; set; }
	}
}
