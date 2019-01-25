using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000040 RID: 64
	public class VmRebootConfig
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00006FD0 File Offset: 0x000051D0
		// (set) Token: 0x06000328 RID: 808 RVA: 0x00006FE7 File Offset: 0x000051E7
		public CPU cpu { get; set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00006FF0 File Offset: 0x000051F0
		// (set) Token: 0x0600032A RID: 810 RVA: 0x00007007 File Offset: 0x00005207
		public Memory memory { get; set; }
	}
}
