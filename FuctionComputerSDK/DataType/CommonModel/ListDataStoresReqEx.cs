using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200004D RID: 77
	public class ListDataStoresReqEx
	{
		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060003B5 RID: 949 RVA: 0x00007DFC File Offset: 0x00005FFC
		// (set) Token: 0x060003B6 RID: 950 RVA: 0x00007E13 File Offset: 0x00006013
		public int? limit { get; set; }

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x00007E1C File Offset: 0x0000601C
		// (set) Token: 0x060003B8 RID: 952 RVA: 0x00007E33 File Offset: 0x00006033
		public int? offset { get; set; }

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x00007E3C File Offset: 0x0000603C
		// (set) Token: 0x060003BA RID: 954 RVA: 0x00007E53 File Offset: 0x00006053
		public string scope { get; set; }

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060003BB RID: 955 RVA: 0x00007E5C File Offset: 0x0000605C
		// (set) Token: 0x060003BC RID: 956 RVA: 0x00007E73 File Offset: 0x00006073
		public string status { get; set; }

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060003BD RID: 957 RVA: 0x00007E7C File Offset: 0x0000607C
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00007E93 File Offset: 0x00006093
		public string name { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060003BF RID: 959 RVA: 0x00007E9C File Offset: 0x0000609C
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x00007EB3 File Offset: 0x000060B3
		public string exceptDatastoreType { get; set; }
	}
}
