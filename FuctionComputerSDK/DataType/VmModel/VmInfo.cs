using System;
using System.Collections.Generic;

namespace FuctionComputerSDK.DataType.VmModel
{
	// Token: 0x0200001D RID: 29
	public class VmInfo
	{
		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000046C4 File Offset: 0x000028C4
		// (set) Token: 0x06000151 RID: 337 RVA: 0x000046DB File Offset: 0x000028DB
		public string uri { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000152 RID: 338 RVA: 0x000046E4 File Offset: 0x000028E4
		// (set) Token: 0x06000153 RID: 339 RVA: 0x000046FB File Offset: 0x000028FB
		public string urn { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000154 RID: 340 RVA: 0x00004704 File Offset: 0x00002904
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000471B File Offset: 0x0000291B
		public string uuid { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000156 RID: 342 RVA: 0x00004724 File Offset: 0x00002924
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000473B File Offset: 0x0000293B
		public string name { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000158 RID: 344 RVA: 0x00004744 File Offset: 0x00002944
		// (set) Token: 0x06000159 RID: 345 RVA: 0x0000475B File Offset: 0x0000295B
		public string description { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600015A RID: 346 RVA: 0x00004764 File Offset: 0x00002964
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000477B File Offset: 0x0000297B
		public string group { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600015C RID: 348 RVA: 0x00004784 File Offset: 0x00002984
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000479B File Offset: 0x0000299B
		public string location { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600015E RID: 350 RVA: 0x000047A4 File Offset: 0x000029A4
		// (set) Token: 0x0600015F RID: 351 RVA: 0x000047BB File Offset: 0x000029BB
		public string locationName { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000047C4 File Offset: 0x000029C4
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000047DB File Offset: 0x000029DB
		public string hostUrn { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000162 RID: 354 RVA: 0x000047E4 File Offset: 0x000029E4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000047FB File Offset: 0x000029FB
		public string clusterUrn { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00004804 File Offset: 0x00002A04
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000481B File Offset: 0x00002A1B
		public List<string> dataStoreUrns { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00004824 File Offset: 0x00002A24
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000483B File Offset: 0x00002A3B
		public string status { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00004844 File Offset: 0x00002A44
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000485B File Offset: 0x00002A5B
		public string pvDriverStatus { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00004864 File Offset: 0x00002A64
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000487B File Offset: 0x00002A7B
		public string toolInstallStatus { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00004884 File Offset: 0x00002A84
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000489B File Offset: 0x00002A9B
		public string cdRomStatus { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600016E RID: 366 RVA: 0x000048A4 File Offset: 0x00002AA4
		// (set) Token: 0x0600016F RID: 367 RVA: 0x000048BB File Offset: 0x00002ABB
		public bool? isTemplate { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000048C4 File Offset: 0x00002AC4
		// (set) Token: 0x06000171 RID: 369 RVA: 0x000048DB File Offset: 0x00002ADB
		public bool? isLinkClone { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000048E4 File Offset: 0x00002AE4
		// (set) Token: 0x06000173 RID: 371 RVA: 0x000048FB File Offset: 0x00002AFB
		public string createTime { get; set; }

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000174 RID: 372 RVA: 0x00004904 File Offset: 0x00002B04
		// (set) Token: 0x06000175 RID: 373 RVA: 0x0000491B File Offset: 0x00002B1B
		public VncAccessInfo vncAcessInfo { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000176 RID: 374 RVA: 0x00004924 File Offset: 0x00002B24
		// (set) Token: 0x06000177 RID: 375 RVA: 0x0000493B File Offset: 0x00002B3B
		public VmConfig vmConfig { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000178 RID: 376 RVA: 0x00004944 File Offset: 0x00002B44
		// (set) Token: 0x06000179 RID: 377 RVA: 0x0000495B File Offset: 0x00002B5B
		public VmRebootConfig vmRebootConfig { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00004964 File Offset: 0x00002B64
		// (set) Token: 0x0600017B RID: 379 RVA: 0x0000497B File Offset: 0x00002B7B
		public OsOption osOptions { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600017C RID: 380 RVA: 0x00004984 File Offset: 0x00002B84
		// (set) Token: 0x0600017D RID: 381 RVA: 0x0000499B File Offset: 0x00002B9B
		public int? idle { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000049A4 File Offset: 0x00002BA4
		// (set) Token: 0x0600017F RID: 383 RVA: 0x000049BB File Offset: 0x00002BBB
		public string deleteTime { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000180 RID: 384 RVA: 0x000049C4 File Offset: 0x00002BC4
		// (set) Token: 0x06000181 RID: 385 RVA: 0x000049DB File Offset: 0x00002BDB
		public string toolsVersion { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000182 RID: 386 RVA: 0x000049E4 File Offset: 0x00002BE4
		// (set) Token: 0x06000183 RID: 387 RVA: 0x000049FB File Offset: 0x00002BFB
		public string imcSetting { get; set; }

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00004A04 File Offset: 0x00002C04
		// (set) Token: 0x06000185 RID: 389 RVA: 0x00004A1B File Offset: 0x00002C1B
		public string minCompatibleimcSetting { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000186 RID: 390 RVA: 0x00004A24 File Offset: 0x00002C24
		// (set) Token: 0x06000187 RID: 391 RVA: 0x00004A3B File Offset: 0x00002C3B
		public bool? isBindingHost { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00004A44 File Offset: 0x00002C44
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00004A5B File Offset: 0x00002C5B
		public List<string> additionalStatus { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00004A64 File Offset: 0x00002C64
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00004A7B File Offset: 0x00002C7B
		public string hostName { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00004A84 File Offset: 0x00002C84
		// (set) Token: 0x0600018D RID: 397 RVA: 0x00004A9B File Offset: 0x00002C9B
		public string clusterName { get; set; }

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00004AA4 File Offset: 0x00002CA4
		// (set) Token: 0x0600018F RID: 399 RVA: 0x00004ABB File Offset: 0x00002CBB
		public int? vmType { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000190 RID: 400 RVA: 0x00004AC4 File Offset: 0x00002CC4
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00004ADB File Offset: 0x00002CDB
		public int? drStatus { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00004AE4 File Offset: 0x00002CE4
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00004AFB File Offset: 0x00002CFB
		public int? rpoStatus { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00004B04 File Offset: 0x00002D04
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00004B1B File Offset: 0x00002D1B
		public int? initSyncStatus { get; set; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00004B24 File Offset: 0x00002D24
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00004B3B File Offset: 0x00002D3B
		public string drDrillVmUri { get; set; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00004B44 File Offset: 0x00002D44
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00004B5B File Offset: 0x00002D5B
		public string drDrillVmUrn { get; set; }

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00004B64 File Offset: 0x00002D64
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00004B7B File Offset: 0x00002D7B
		public List<string> objectPrivs { get; set; }
	}
}
