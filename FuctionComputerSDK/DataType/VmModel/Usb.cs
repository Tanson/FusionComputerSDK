using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x02000025 RID: 37
	public class Usb
	{
		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x00005678 File Offset: 0x00003878
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000568F File Offset: 0x0000388F
		public string controllerType { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060001EB RID: 491 RVA: 0x00005698 File Offset: 0x00003898
		// (set) Token: 0x060001EC RID: 492 RVA: 0x000056AF File Offset: 0x000038AF
		public List<UsbDevice> device { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060001ED RID: 493 RVA: 0x000056B8 File Offset: 0x000038B8
		// (set) Token: 0x060001EE RID: 494 RVA: 0x000056CF File Offset: 0x000038CF
		public string usbHostName { get; set; }
	}
}
