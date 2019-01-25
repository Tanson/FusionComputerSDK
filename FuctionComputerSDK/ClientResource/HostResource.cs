using System;
using System.Text;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.HostModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x0200002D RID: 45
	public class HostResource
	{
		// Token: 0x06000269 RID: 617 RVA: 0x00005E38 File Offset: 0x00004038
		private HostResource()
		{
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00005E44 File Offset: 0x00004044
		public static HostResource GetInstance(ClientProviderBean bean)
		{
			if (null == HostResource.instance)
			{
				HostResource.instance = new HostResource();
			}
			HostResource.instance.init(bean);
			return HostResource.instance;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00005E82 File Offset: 0x00004082
		private void init(ClientProviderBean arg)
		{
			this.bean = arg;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00005E8C File Offset: 0x0000408C
		public HostTaskResp CreateHost(string siteUri, CreateHostReq req)
		{
			string uri = siteUri + "/hosts";
			string text = RestClientUtil.sendRequest("POST", uri, req, this.bean, "CreateHost");
			HostResource.log.Info("CreateHost result : " + text);
			return JsonConvert.DeserializeObject<HostTaskResp>(text);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00005EE0 File Offset: 0x000040E0
		public ListHostsResp ListHosts(string siteUri, ListHostsReq req)
		{
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/hosts?");
			if (null != req)
			{
				stringBuilder.Append((req.limit == null) ? "" : ("limit=" + req.limit + "&"));
				stringBuilder.Append((req.offset == null) ? "" : ("offset=" + req.offset + "&"));
				stringBuilder.Append((req.name == null) ? "" : ("name=" + req.name + "&"));
				stringBuilder.Append((req.scope == null) ? "" : ("scope=" + req.scope + "&"));
				stringBuilder.Append((req.ip == null) ? "" : ("ip=" + req.ip + "&"));
				stringBuilder.Append((req.resourceGroupFlag == null) ? "" : ("resourceGroupFlag=" + req.resourceGroupFlag + "&"));
			}
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListHosts");
			HostResource.log.Info("ListHosts result : " + text);
			return JsonConvert.DeserializeObject<ListHostsResp>(text);
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00006084 File Offset: 0x00004284
		public QueryComputeResourceStaticsResp QueryComputeResourceStatics(string hostUri)
		{
			string uri = hostUri + "/computeResourceStatics";
			string text = RestClientUtil.sendRequest("GET", uri, null, this.bean, "QueryComputeResourceStatics");
			HostResource.log.Info("QueryComputeResourceStatics result : " + text);
			return JsonConvert.DeserializeObject<QueryComputeResourceStaticsResp>(text);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x000060D8 File Offset: 0x000042D8
		public QueryHostsStatisticsResp QueryHostsStatistics(string siteUri, string scope)
		{
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/hosts/statistics?");
			stringBuilder.Append((scope == null) ? "" : ("scope=" + scope + "&"));
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "QueryHostsStatistics");
			HostResource.log.Info("QueryHostsStatistics result : " + text);
			return JsonConvert.DeserializeObject<QueryHostsStatisticsResp>(text);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00006160 File Offset: 0x00004360
		public AsynchrTask ModifyHost(string hostUri, ModifyHostReq req)
		{
			string text = RestClientUtil.sendRequest("PUT", hostUri, req, this.bean, "ModifyHost");
			HostResource.log.Info("ModifyHost result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000061A8 File Offset: 0x000043A8
		public AsynchrTask RemoveHost(string hostUri, int? isForce)
		{
			string text = RestClientUtil.sendRequest("DELETE", hostUri, null, this.bean, "RemoveHost");
			HostResource.log.Info("RemoveHost result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x06000272 RID: 626 RVA: 0x000061F0 File Offset: 0x000043F0
		public AsynchrTask RebootHost(string hostUri, RebootReq req)
		{
			string text = RestClientUtil.sendRequest("POST", hostUri + "/action/reboot", req, this.bean, "RebootHost");
			HostResource.log.Info("RebootHost result : " + text);
			return JsonConvert.DeserializeObject<AsynchrTask>(text);
		}

		// Token: 0x04000118 RID: 280
		private static HostResource instance = null;

		// Token: 0x04000119 RID: 281
		private static ILog log = LogManager.GetLogger(typeof(HostResource));

		// Token: 0x0400011A RID: 282
		private ClientProviderBean bean;
	}
}
