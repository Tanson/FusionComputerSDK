using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x0200004B RID: 75
	public class ModifyRoleReq
	{
		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00007D6C File Offset: 0x00005F6C
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00007D83 File Offset: 0x00005F83
		public string roleName { get; set; }

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060003AD RID: 941 RVA: 0x00007D8C File Offset: 0x00005F8C
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00007DA3 File Offset: 0x00005FA3
		public string description { get; set; }

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060003AF RID: 943 RVA: 0x00007DAC File Offset: 0x00005FAC
		// (set) Token: 0x060003B0 RID: 944 RVA: 0x00007DC3 File Offset: 0x00005FC3
		public List<string> popedom { get; set; }
	}
}
