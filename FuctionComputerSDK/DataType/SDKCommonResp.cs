using System;

namespace FuctionComputerSDK.DataType
{
	// Token: 0x02000002 RID: 2
	public class SDKCommonResp
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		public string errorCode
		{
			get
			{
				return this.errorCodeValue;
			}
			set
			{
				if (value != this.errorCodeValue)
				{
					this.errorCodeValue = value;
				}
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002094 File Offset: 0x00000294
		// (set) Token: 0x06000004 RID: 4 RVA: 0x000020AC File Offset: 0x000002AC
		public string errorDes
		{
			get
			{
				return this.errorDesValue;
			}
			set
			{
				if (value != this.errorDesValue)
				{
					this.errorDesValue = value;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private string errorCodeValue = "00000000";

		// Token: 0x04000002 RID: 2
		private string errorDesValue;
	}
}
