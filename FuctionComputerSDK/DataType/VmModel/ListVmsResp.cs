using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200000A RID: 10
	public class ListVmsResp : SDKCommonResp
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000026CF File Offset: 0x000008CF
		public int? total { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000062 RID: 98 RVA: 0x000026D8 File Offset: 0x000008D8
		// (set) Token: 0x06000063 RID: 99 RVA: 0x000026EF File Offset: 0x000008EF
		public List<VmInfo> vms { get; set; }
	}
}
