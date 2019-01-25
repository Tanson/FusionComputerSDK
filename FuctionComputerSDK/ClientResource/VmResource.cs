using System;
using System.Text;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.VmModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x0200001B RID: 27
	public class VmResource
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00003CF4 File Offset: 0x00001EF4
		private VmResource()
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00003D00 File Offset: 0x00001F00
		public static VmResource GetInstance(ClientProviderBean bean)
		{
			if (null == VmResource.instance)
			{
				VmResource.instance = new VmResource();
			}
			VmResource.instance.init(bean);
			return VmResource.instance;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00003D3E File Offset: 0x00001F3E
		private void init(ClientProviderBean arg)
		{
			this.bean = arg;
		}
        public VmTaskResp OsVersions(string vmUri)
        {
            VmTaskResp vmTaskResp = new VmTaskResp();
            string uri = vmUri + "/osversions";
            string text = RestClientUtil.sendRequest("get", uri,"", this.bean, "osversions");
            VmResource.log.Info("osversions result : " + text);
            return JsonConvert.DeserializeObject<VmTaskResp>(text);
        }
        // Token: 0x0600013B RID: 315 RVA: 0x00003D48 File Offset: 0x00001F48
        public VmTaskResp CreateVm(string siteUri, CreateVmReq req)
		{
			VmTaskResp vmTaskResp = new VmTaskResp();
			string uri = siteUri + "/vms";
			string text = RestClientUtil.sendRequest("POST", uri, req, this.bean, "CreateVm");
			VmResource.log.Info("CreateVm result : " + LogUtil.ReplayLog(text));
			return JsonConvert.DeserializeObject<VmTaskResp>(text);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public ImportVmTempResp ImportVmTemp(string siteUri, ImportVmTempReq req)
		{
			ImportVmTempResp importVmTempResp = new ImportVmTempResp();
			string uri = siteUri + "/vms/action/import";
			string text = RestClientUtil.sendRequest("POST", uri, req, this.bean, "ImportVmTemp");
			VmResource.log.Info("ImportVmTemp result : " + LogUtil.ReplayLog(text));
			return JsonConvert.DeserializeObject<ImportVmTempResp>(text);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00003E08 File Offset: 0x00002008
		public AsynchrTask StartVm(string vmUri)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			string uri = vmUri + "/action/start";
			string text = RestClientUtil.sendRequest("POST", uri, null, this.bean, "StartVm");
			VmResource.log.Info("StartVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00003E64 File Offset: 0x00002064
		public AsynchrTask StopVm(string vmUri, string mode)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			ActionModeReq actionModeReq = new ActionModeReq();
			actionModeReq.mode = mode;
			string uri = vmUri + "/action/stop";
			string text = RestClientUtil.sendRequest("POST", uri, actionModeReq, this.bean, "StopVm");
			VmResource.log.Info("StopVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00003ED0 File Offset: 0x000020D0
		public VmTaskResp CloneVm(string vmUri, CloneVmReq req)
		{
			VmTaskResp vmTaskResp = new VmTaskResp();
			string uri = vmUri + "/action/clone";
			string text = RestClientUtil.sendRequest("POST", uri, req, this.bean, "CloneVm");
			VmResource.log.Info("CloneVm result : " + text);
			return JsonConvert.DeserializeObject<VmTaskResp>(text);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00003F2C File Offset: 0x0000212C
		public ListVmsResp ListVms(string siteUri, ListVmsReq req)
		{
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/vms?");
			if (null != req)
			{
				stringBuilder.Append((req.limit == null) ? "" : ("limit=" + req.limit + "&"));
				stringBuilder.Append((req.offset == null) ? "" : ("offset=" + req.offset + "&"));
				stringBuilder.Append((req.name == null) ? "" : ("name=" + req.name + "&"));
				stringBuilder.Append((req.scope == null) ? "" : ("scope=" + req.scope + "&"));
				stringBuilder.Append((req.isTemplate == null) ? "" : ("isTemplate=" + req.isTemplate + "&"));
				stringBuilder.Append((req.isLinkClone == null) ? "" : ("isLinkClone=" + req.isLinkClone + "&"));
				stringBuilder.Append((req.templateUrn == null) ? "" : ("templateUrn=" + req.templateUrn + "&"));
				stringBuilder.Append((req.status == null) ? "" : ("status=" + req.status + "&"));
				stringBuilder.Append((req.ip == null) ? "" : ("ip=" + req.ip + "&"));
				stringBuilder.Append((req.mac == null) ? "" : ("mac=" + req.mac + "&"));
				stringBuilder.Append((req.vmId == null) ? "" : ("vmId=" + req.vmId + "&"));
				stringBuilder.Append((req.uuid == null) ? "" : ("uuid=" + req.uuid + "&"));
				stringBuilder.Append((req.resourceGroupFlag == null) ? "" : ("resourceGroupFlag=" + req.resourceGroupFlag + "&"));
				stringBuilder.Append((req.detail == null) ? "" : ("detail=" + req.detail + "&"));
				stringBuilder.Append((req.description == null) ? "" : ("description=" + req.description + "&"));
				stringBuilder.Append((req.imcSetting == null) ? "" : ("imcSetting=" + req.imcSetting + "&"));
				stringBuilder.Append((req.isBindingHost == null) ? "" : ("isBindingHost=" + req.isBindingHost + "&"));
				stringBuilder.Append((req.vmType == null) ? "" : ("vmType=" + req.vmType + "&"));
				if (req.vmurns != null && req.vmurns.Count > 0)
				{
					foreach (string text in req.vmurns)
					{
						if (null != text)
						{
							stringBuilder.Append("vmurns=").Append(text + "&");
						}
					}
				}
			}
			string text2 = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListVms");
			VmResource.log.Info("ListVms result : " + text2);
			return JsonConvert.DeserializeObject<ListVmsResp>(text2);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000043B0 File Offset: 0x000025B0
		public AsynchrTask PauseVm(string vmUri)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			string uri = vmUri + "/action/pause";
			string text = RestClientUtil.sendRequest("POST", uri, null, this.bean, "PauseVm");
			VmResource.log.Info("PauseVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000440C File Offset: 0x0000260C
		public AsynchrTask ResumeVm(string vmUri)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			string uri = vmUri + "/action/resume";
			string text = RestClientUtil.sendRequest("POST", uri, null, this.bean, "ResumeVm");
			VmResource.log.Info("ResumeVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00004468 File Offset: 0x00002668
		public AsynchrTask RebootVm(string vmUri, string req)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			ActionModeReq actionModeReq = new ActionModeReq();
			actionModeReq.mode = req;
			string uri = vmUri + "/action/reboot";
			string text = RestClientUtil.sendRequest("POST", uri, actionModeReq, this.bean, "RebootVm");
			VmResource.log.Info("RebootVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000044D4 File Offset: 0x000026D4
		public AsynchrTask RemoveVm(string vmUri, int? isReserveDisks, int? isFormat, int? holdTime)
		{
			AsynchrTask asynchrTask = new AsynchrTask();
			StringBuilder stringBuilder = new StringBuilder(vmUri + "?");
			stringBuilder.Append((isReserveDisks == null) ? "" : ("isReserveDisks=" + isReserveDisks + "&"));
			stringBuilder.Append((isFormat == null) ? "" : ("isFormat=" + isFormat + "&"));
			stringBuilder.Append((holdTime == null) ? "" : ("holdTime=" + holdTime + "&"));
			string text = RestClientUtil.sendRequest("DELETE", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "RemoveVm");
			VmResource.log.Info("RemoveVm result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000045C8 File Offset: 0x000027C8
		public ListOsInfosResp ListOsInfos(string siteUri)
		{
			ListOsInfosResp listOsInfosResp = new ListOsInfosResp();
			string text = RestClientUtil.sendRequest("GET", siteUri + "/vms/osversions", null, this.bean, "ListOsInfos");
			VmResource.log.Info("ListOsInfos result : " + text);
			return JsonConvert.DeserializeObject<ListOsInfosResp>(text);
		}

		// Token: 0x0400008E RID: 142
		private static VmResource instance = null;

		// Token: 0x0400008F RID: 143
		private static ILog log = LogManager.GetLogger(typeof(VmResource));

		// Token: 0x04000090 RID: 144
		private ClientProviderBean bean;
	}
}
