using System;

namespace FuctionComputerSDK.DataType.HostModel
{
	// Token: 0x02000045 RID: 69
	public class QueryHostsStatisticsResp : SDKCommonResp
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00007320 File Offset: 0x00005520
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00007337 File Offset: 0x00005537
		public int? total { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00007340 File Offset: 0x00005540
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00007357 File Offset: 0x00005557
		public int? rebooting { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00007360 File Offset: 0x00005560
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00007377 File Offset: 0x00005577
		public int? normal { get; set; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00007380 File Offset: 0x00005580
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00007397 File Offset: 0x00005597
		public int? fault { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000364 RID: 868 RVA: 0x000073A0 File Offset: 0x000055A0
		// (set) Token: 0x06000365 RID: 869 RVA: 0x000073B7 File Offset: 0x000055B7
		public int? initial { get; set; }

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000073C0 File Offset: 0x000055C0
		// (set) Token: 0x06000367 RID: 871 RVA: 0x000073D7 File Offset: 0x000055D7
		public int? unknown { get; set; }

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000073E0 File Offset: 0x000055E0
		// (set) Token: 0x06000369 RID: 873 RVA: 0x000073F7 File Offset: 0x000055F7
		public int? poweroff { get; set; }

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00007400 File Offset: 0x00005600
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00007417 File Offset: 0x00005617
		public int? booting { get; set; }

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00007420 File Offset: 0x00005620
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00007437 File Offset: 0x00005637
		public int? shutdowning { get; set; }
	}
}
