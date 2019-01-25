using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000008 RID: 8
	public class FileItem
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00002388 File Offset: 0x00000588
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0000239F File Offset: 0x0000059F
		public string deviceId { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000023A8 File Offset: 0x000005A8
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000023BF File Offset: 0x000005BF
		public string path { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000023C8 File Offset: 0x000005C8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000023DF File Offset: 0x000005DF
		public long? size { get; set; }
	}
}
