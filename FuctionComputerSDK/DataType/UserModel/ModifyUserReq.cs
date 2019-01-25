using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000055 RID: 85
	public class ModifyUserReq
	{
		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x0000839C File Offset: 0x0000659C
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x000083B3 File Offset: 0x000065B3
		public string userName { get; set; }

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000083BC File Offset: 0x000065BC
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x000083D3 File Offset: 0x000065D3
		public List<string> roles { get; set; }

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x000083DC File Offset: 0x000065DC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x000083F3 File Offset: 0x000065F3
		public string email { get; set; }

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x000083FC File Offset: 0x000065FC
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00008413 File Offset: 0x00006613
		public string contact { get; set; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x0000841C File Offset: 0x0000661C
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00008433 File Offset: 0x00006633
		public string description { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x0000843C File Offset: 0x0000663C
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00008453 File Offset: 0x00006653
		public int? connectNum { get; set; }
	}
}
