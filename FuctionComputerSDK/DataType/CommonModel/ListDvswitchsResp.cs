using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200003A RID: 58
	public class ListDvswitchsResp : SDKCommonResp
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00006B00 File Offset: 0x00004D00
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00006B17 File Offset: 0x00004D17
		public List<DvSwitchInfo> dvSwitchs { get; set; }
	}
}
