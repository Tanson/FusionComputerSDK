using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000017 RID: 23
	public class SetUserRolesReq
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000122 RID: 290 RVA: 0x00003BB4 File Offset: 0x00001DB4
		// (set) Token: 0x06000123 RID: 291 RVA: 0x00003BCB File Offset: 0x00001DCB
		public List<string> roles { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00003BD4 File Offset: 0x00001DD4
		// (set) Token: 0x06000125 RID: 293 RVA: 0x00003BEB File Offset: 0x00001DEB
		public int? rightType { get; set; }
	}
}
