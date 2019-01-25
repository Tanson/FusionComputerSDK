using System;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000011 RID: 17
	public class ResetPasswordReq
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002FF0 File Offset: 0x000011F0
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00003007 File Offset: 0x00001207
		public string userId { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00003010 File Offset: 0x00001210
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00003027 File Offset: 0x00001227
		public string password { get; set; }
	}
}
