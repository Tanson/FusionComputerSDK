using System;

namespace FuctionComputerSDK.DataType.CommonModel
{
	// Token: 0x0200004F RID: 79
	public class ClusterInfo
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060003C7 RID: 967 RVA: 0x00007F0C File Offset: 0x0000610C
		// (set) Token: 0x060003C8 RID: 968 RVA: 0x00007F23 File Offset: 0x00006123
		public string urn { get; set; }

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00007F2C File Offset: 0x0000612C
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00007F43 File Offset: 0x00006143
		public string uri { get; set; }

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060003CB RID: 971 RVA: 0x00007F4C File Offset: 0x0000614C
		// (set) Token: 0x060003CC RID: 972 RVA: 0x00007F63 File Offset: 0x00006163
		public string name { get; set; }

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060003CD RID: 973 RVA: 0x00007F6C File Offset: 0x0000616C
		// (set) Token: 0x060003CE RID: 974 RVA: 0x00007F83 File Offset: 0x00006183
		public string parentObjUrn { get; set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060003CF RID: 975 RVA: 0x00007F8C File Offset: 0x0000618C
		// (set) Token: 0x060003D0 RID: 976 RVA: 0x00007FA3 File Offset: 0x000061A3
		public string parentObjName { get; set; }

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060003D1 RID: 977 RVA: 0x00007FAC File Offset: 0x000061AC
		// (set) Token: 0x060003D2 RID: 978 RVA: 0x00007FC3 File Offset: 0x000061C3
		public string description { get; set; }

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00007FCC File Offset: 0x000061CC
		// (set) Token: 0x060003D4 RID: 980 RVA: 0x00007FE3 File Offset: 0x000061E3
		public CpuResource cpuResource { get; set; }

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x00007FEC File Offset: 0x000061EC
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x00008003 File Offset: 0x00006203
		public MemResource memResource { get; set; }

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060003D7 RID: 983 RVA: 0x0000800C File Offset: 0x0000620C
		// (set) Token: 0x060003D8 RID: 984 RVA: 0x00008023 File Offset: 0x00006223
		public string tag { get; set; }
	}
}
