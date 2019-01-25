using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x02000052 RID: 82
	public class UserInfo
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00008124 File Offset: 0x00006324
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x0000813B File Offset: 0x0000633B
		public string userId { get; set; }

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x00008144 File Offset: 0x00006344
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000815B File Offset: 0x0000635B
		public string userType { get; set; }

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00008164 File Offset: 0x00006364
		// (set) Token: 0x060003EF RID: 1007 RVA: 0x0000817B File Offset: 0x0000637B
		public string userName { get; set; }

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00008184 File Offset: 0x00006384
		// (set) Token: 0x060003F1 RID: 1009 RVA: 0x0000819B File Offset: 0x0000639B
		public List<string> roles { get; set; }

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000081A4 File Offset: 0x000063A4
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x000081BB File Offset: 0x000063BB
		public string email { get; set; }

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000081C4 File Offset: 0x000063C4
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x000081DB File Offset: 0x000063DB
		public string contact { get; set; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x000081E4 File Offset: 0x000063E4
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x000081FB File Offset: 0x000063FB
		public string description { get; set; }

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x00008204 File Offset: 0x00006404
		// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0000821B File Offset: 0x0000641B
		public string createTime { get; set; }

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00008224 File Offset: 0x00006424
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0000823B File Offset: 0x0000643B
		public int? connectNum { get; set; }

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x00008244 File Offset: 0x00006444
		// (set) Token: 0x060003FD RID: 1021 RVA: 0x0000825B File Offset: 0x0000645B
		public int? rightType { get; set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00008264 File Offset: 0x00006464
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x0000827B File Offset: 0x0000647B
		public int? manageStatus { get; set; }
	}
}
