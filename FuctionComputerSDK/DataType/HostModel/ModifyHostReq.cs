using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000042 RID: 66
	public class ModifyHostReq
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000335 RID: 821 RVA: 0x000070A0 File Offset: 0x000052A0
		// (set) Token: 0x06000336 RID: 822 RVA: 0x000070B7 File Offset: 0x000052B7
		public string name { get; set; }

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000337 RID: 823 RVA: 0x000070C0 File Offset: 0x000052C0
		// (set) Token: 0x06000338 RID: 824 RVA: 0x000070D7 File Offset: 0x000052D7
		public string description { get; set; }

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000339 RID: 825 RVA: 0x000070E0 File Offset: 0x000052E0
		// (set) Token: 0x0600033A RID: 826 RVA: 0x000070F7 File Offset: 0x000052F7
		public string multiPathMode { get; set; }

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00007100 File Offset: 0x00005300
		// (set) Token: 0x0600033C RID: 828 RVA: 0x00007117 File Offset: 0x00005317
		public string bmcIp { get; set; }

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00007120 File Offset: 0x00005320
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00007137 File Offset: 0x00005337
		public string bmcUserName { get; set; }

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00007140 File Offset: 0x00005340
		// (set) Token: 0x06000340 RID: 832 RVA: 0x00007157 File Offset: 0x00005357
		public string bmcPassword { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000341 RID: 833 RVA: 0x00007160 File Offset: 0x00005360
		// (set) Token: 0x06000342 RID: 834 RVA: 0x00007177 File Offset: 0x00005377
		public string ntpIp1 { get; set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00007180 File Offset: 0x00005380
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00007197 File Offset: 0x00005397
		public string ntpIp2 { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000345 RID: 837 RVA: 0x000071A0 File Offset: 0x000053A0
		// (set) Token: 0x06000346 RID: 838 RVA: 0x000071B7 File Offset: 0x000053B7
		public string ntpIp3 { get; set; }

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000347 RID: 839 RVA: 0x000071C0 File Offset: 0x000053C0
		// (set) Token: 0x06000348 RID: 840 RVA: 0x000071D7 File Offset: 0x000053D7
		public int? ntpCycle { get; set; }

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000071E0 File Offset: 0x000053E0
		// (set) Token: 0x0600034A RID: 842 RVA: 0x000071F7 File Offset: 0x000053F7
		public int? isForceSynTime { get; set; }

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600034B RID: 843 RVA: 0x00007200 File Offset: 0x00005400
		// (set) Token: 0x0600034C RID: 844 RVA: 0x00007217 File Offset: 0x00005417
		public int? gpuCapacity { get; set; }

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00007220 File Offset: 0x00005420
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00007237 File Offset: 0x00005437
		public int? gdvmMemory { get; set; }

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00007240 File Offset: 0x00005440
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00007257 File Offset: 0x00005457
		public int? gsvmMemory { get; set; }
	}
}
