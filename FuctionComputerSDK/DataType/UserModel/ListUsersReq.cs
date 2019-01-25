using System;

namespace FuctionComputerSDK.DataType.UserModel
{
	// Token: 0x0200005D RID: 93
	public class ListUsersReq
	{
		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00008BBC File Offset: 0x00006DBC
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00008BD3 File Offset: 0x00006DD3
		public int? offset { get; set; }

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x00008BDC File Offset: 0x00006DDC
		// (set) Token: 0x0600049C RID: 1180 RVA: 0x00008BF3 File Offset: 0x00006DF3
		public int? limit { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x00008BFC File Offset: 0x00006DFC
		// (set) Token: 0x0600049E RID: 1182 RVA: 0x00008C13 File Offset: 0x00006E13
		public string userType { get; set; }

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00008C1C File Offset: 0x00006E1C
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00008C33 File Offset: 0x00006E33
		public string userName { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00008C3C File Offset: 0x00006E3C
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00008C53 File Offset: 0x00006E53
		public string createStartTime { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x00008C5C File Offset: 0x00006E5C
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x00008C73 File Offset: 0x00006E73
		public string createStopTime { get; set; }

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00008C7C File Offset: 0x00006E7C
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x00008C93 File Offset: 0x00006E93
		public int? manageStatus { get; set; }
	}
}
