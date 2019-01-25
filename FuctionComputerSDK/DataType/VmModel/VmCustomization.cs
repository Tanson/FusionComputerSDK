using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000059 RID: 89
	public class VmCustomization
	{
		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0000855C File Offset: 0x0000675C
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00008573 File Offset: 0x00006773
		public string urn { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0000857C File Offset: 0x0000677C
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00008593 File Offset: 0x00006793
		public string uri { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0000859C File Offset: 0x0000679C
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x000085B3 File Offset: 0x000067B3
		public string name { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x000085BC File Offset: 0x000067BC
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x000085D3 File Offset: 0x000067D3
		public string description { get; set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x000085DC File Offset: 0x000067DC
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x000085F3 File Offset: 0x000067F3
		public string osType { get; set; }

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x000085FC File Offset: 0x000067FC
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x00008613 File Offset: 0x00006813
		public string hostname { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0000861C File Offset: 0x0000681C
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x00008633 File Offset: 0x00006833
		public string password { get; set; }

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x0000863C File Offset: 0x0000683C
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x00008653 File Offset: 0x00006853
		public string workgroup { get; set; }

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x0000865C File Offset: 0x0000685C
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x00008673 File Offset: 0x00006873
		public string domain { get; set; }

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000867C File Offset: 0x0000687C
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x00008693 File Offset: 0x00006893
		public string domainName { get; set; }

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x0000869C File Offset: 0x0000689C
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000086B3 File Offset: 0x000068B3
		public string domainPassword { get; set; }

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x000086BC File Offset: 0x000068BC
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x000086D3 File Offset: 0x000068D3
		public List<NicSpecification> nicSpecification { get; set; }

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x000086DC File Offset: 0x000068DC
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x000086F3 File Offset: 0x000068F3
		public string ouName { get; set; }
	}
}
