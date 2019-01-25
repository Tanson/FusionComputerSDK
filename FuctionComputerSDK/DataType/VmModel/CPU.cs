using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000010 RID: 16
	public class CPU
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00002F08 File Offset: 0x00001108
		// (set) Token: 0x060000AC RID: 172 RVA: 0x00002F1F File Offset: 0x0000111F
		public int? quantity { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x060000AE RID: 174 RVA: 0x00002F3F File Offset: 0x0000113F
		public int? coresPerSocket { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00002F48 File Offset: 0x00001148
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00002F5F File Offset: 0x0000115F
		public int? reservation { get; set; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x00002F68 File Offset: 0x00001168
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x00002F7F File Offset: 0x0000117F
		public int? weight { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x00002F9F File Offset: 0x0000119F
		public int? limit { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x00002FA8 File Offset: 0x000011A8
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x00002FBF File Offset: 0x000011BF
		public int? cpuHotPlug { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00002FC8 File Offset: 0x000011C8
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x00002FDF File Offset: 0x000011DF
		public List<int?> affinitySet { get; set; }
	}
}
