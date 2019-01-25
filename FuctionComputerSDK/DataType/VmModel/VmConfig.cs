using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000006 RID: 6
	public class VmConfig
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000021F8 File Offset: 0x000003F8
		// (set) Token: 0x06000013 RID: 19 RVA: 0x0000220F File Offset: 0x0000040F
		public CPU cpu { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002218 File Offset: 0x00000418
		// (set) Token: 0x06000015 RID: 21 RVA: 0x0000222F File Offset: 0x0000042F
		public Memory memory { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002238 File Offset: 0x00000438
		// (set) Token: 0x06000017 RID: 23 RVA: 0x0000224F File Offset: 0x0000044F
		public List<Disk> disks { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002258 File Offset: 0x00000458
		// (set) Token: 0x06000019 RID: 25 RVA: 0x0000226F File Offset: 0x0000046F
		public List<Nic> nics { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002278 File Offset: 0x00000478
		// (set) Token: 0x0600001B RID: 27 RVA: 0x0000228F File Offset: 0x0000048F
		public List<Usb> usb { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002298 File Offset: 0x00000498
		// (set) Token: 0x0600001D RID: 29 RVA: 0x000022AF File Offset: 0x000004AF
		public List<GPU> gpu { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001E RID: 30 RVA: 0x000022B8 File Offset: 0x000004B8
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000022CF File Offset: 0x000004CF
		public Property properties { get; set; }
	}
}
