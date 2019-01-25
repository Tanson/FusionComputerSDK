using System;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200000B RID: 11
	public class CreateVmReq
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00002717 File Offset: 0x00000917
		public string name { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002720 File Offset: 0x00000920
		// (set) Token: 0x06000068 RID: 104 RVA: 0x00002737 File Offset: 0x00000937
		public string description { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002740 File Offset: 0x00000940
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00002757 File Offset: 0x00000957
		public string group { get; set; }

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00002777 File Offset: 0x00000977
		public string location { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00002780 File Offset: 0x00000980
		// (set) Token: 0x0600006E RID: 110 RVA: 0x00002797 File Offset: 0x00000997
		public bool? isBindingHost { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000027A0 File Offset: 0x000009A0
		// (set) Token: 0x06000070 RID: 112 RVA: 0x000027B7 File Offset: 0x000009B7
		public VmConfig vmConfig { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000071 RID: 113 RVA: 0x000027C0 File Offset: 0x000009C0
		// (set) Token: 0x06000072 RID: 114 RVA: 0x000027D7 File Offset: 0x000009D7
		public bool? autoBoot { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000027E0 File Offset: 0x000009E0
		// (set) Token: 0x06000074 RID: 116 RVA: 0x000027F7 File Offset: 0x000009F7
		public OsOption osOptions { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00002800 File Offset: 0x00000A00
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00002817 File Offset: 0x00000A17
		public VncAccessInfo vncAccessInfo { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00002820 File Offset: 0x00000A20
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002837 File Offset: 0x00000A37
		public bool? occupiedVm { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00002840 File Offset: 0x00000A40
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002857 File Offset: 0x00000A57
		public string uuid { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002860 File Offset: 0x00000A60
		// (set) Token: 0x0600007C RID: 124 RVA: 0x00002877 File Offset: 0x00000A77
		public SecurityGroup securityGroupSet { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002880 File Offset: 0x00000A80
		// (set) Token: 0x0600007E RID: 126 RVA: 0x00002897 File Offset: 0x00000A97
		public bool? isMultiDiskSpeedup { get; set; }
	}
}
