using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x02000019 RID: 25
	public class ListPortGroupsReqEx
	{
		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00003C44 File Offset: 0x00001E44
		// (set) Token: 0x0600012D RID: 301 RVA: 0x00003C5B File Offset: 0x00001E5B
		public int? limit { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00003C64 File Offset: 0x00001E64
		// (set) Token: 0x0600012F RID: 303 RVA: 0x00003C7B File Offset: 0x00001E7B
		public int? offset { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00003C84 File Offset: 0x00001E84
		// (set) Token: 0x06000131 RID: 305 RVA: 0x00003C9B File Offset: 0x00001E9B
		public string portGroupName { get; set; }
	}
}
