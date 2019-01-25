using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x0200003E RID: 62
	public class CreateHostReq
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000311 RID: 785 RVA: 0x00006C98 File Offset: 0x00004E98
		// (set) Token: 0x06000312 RID: 786 RVA: 0x00006CAF File Offset: 0x00004EAF
		public string name { get; set; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000313 RID: 787 RVA: 0x00006CB8 File Offset: 0x00004EB8
		// (set) Token: 0x06000314 RID: 788 RVA: 0x00006CCF File Offset: 0x00004ECF
		public string description { get; set; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000315 RID: 789 RVA: 0x00006CD8 File Offset: 0x00004ED8
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00006CEF File Offset: 0x00004EEF
		public string ip { get; set; }

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00006CF8 File Offset: 0x00004EF8
		// (set) Token: 0x06000318 RID: 792 RVA: 0x00006D0F File Offset: 0x00004F0F
		public string clusterUrn { get; set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00006D18 File Offset: 0x00004F18
		// (set) Token: 0x0600031A RID: 794 RVA: 0x00006D2F File Offset: 0x00004F2F
		public string bmcIp { get; set; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600031B RID: 795 RVA: 0x00006D38 File Offset: 0x00004F38
		// (set) Token: 0x0600031C RID: 796 RVA: 0x00006D4F File Offset: 0x00004F4F
		public string bmcUserName { get; set; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00006D58 File Offset: 0x00004F58
		// (set) Token: 0x0600031E RID: 798 RVA: 0x00006D6F File Offset: 0x00004F6F
		public string bmcPassword { get; set; }

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x0600031F RID: 799 RVA: 0x00006D78 File Offset: 0x00004F78
		// (set) Token: 0x06000320 RID: 800 RVA: 0x00006D8F File Offset: 0x00004F8F
		public int? isConfDefNtpTimeZone { get; set; }
	}
}
