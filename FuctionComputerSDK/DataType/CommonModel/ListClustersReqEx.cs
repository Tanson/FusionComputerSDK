using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000022 RID: 34
	public class ListClustersReqEx
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00004EAC File Offset: 0x000030AC
		// (set) Token: 0x060001D2 RID: 466 RVA: 0x00004EC3 File Offset: 0x000030C3
		public string tag { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00004ECC File Offset: 0x000030CC
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x00004EE3 File Offset: 0x000030E3
		public string name { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00004F03 File Offset: 0x00003103
		public string parentObjUrn { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00004F0C File Offset: 0x0000310C
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00004F23 File Offset: 0x00003123
		public List<string> clusterUrns { get; set; }
	}
}
