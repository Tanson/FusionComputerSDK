using System;
using System.Text;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.CommonModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x02000016 RID: 22
	public class CommonResource
	{
		// Token: 0x06000119 RID: 281 RVA: 0x000035B8 File Offset: 0x000017B8
		private CommonResource()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x000035C4 File Offset: 0x000017C4
		public static CommonResource GetInstance(ClientProviderBean bean)
		{
			if (null == CommonResource.instance)
			{
				CommonResource.instance = new CommonResource();
			}
			CommonResource.instance.init(bean);
			return CommonResource.instance;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00003604 File Offset: 0x00001804
		private void init(ClientProviderBean arg)
		{
			if (null == arg)
			{
				this.bean = new ClientProviderBean();
			}
			else
			{
				this.bean = arg;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00003638 File Offset: 0x00001838
		public ListSitesResp ListSites()
		{
			ListSitesResp listSitesResp = new ListSitesResp();
			string text = RestClientUtil.sendRequest("GET", "/service/sites", null, this.bean, "ListSites");
			CommonResource.log.Info("ListSites result : " + text);
			return JsonConvert.DeserializeObject<ListSitesResp>(text);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000368C File Offset: 0x0000188C
		public ListClustersResp ListClusters(string siteUri, ListClustersReqEx reqEx)
		{
			ListClustersResp listClustersResp = new ListClustersResp();
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/clusters?");
			if (null != reqEx)
			{
				stringBuilder.Append((reqEx.tag == null) ? "" : ("tag=" + reqEx.tag + "&"));
				stringBuilder.Append((reqEx.name == null) ? "" : ("name=" + reqEx.name + "&"));
				stringBuilder.Append((reqEx.parentObjUrn == null) ? "" : ("parentObjUrn=" + reqEx.parentObjUrn + "&"));
				if (reqEx.clusterUrns != null && reqEx.clusterUrns.Count > 0)
				{
					foreach (string str in reqEx.clusterUrns)
					{
						stringBuilder.Append("clusterUrns=" + str + "&");
					}
				}
			}
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListClusters");
			CommonResource.log.Info("ListClusters result : " + text);
			return JsonConvert.DeserializeObject<ListClustersResp>(text);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00003810 File Offset: 0x00001A10
		public ListDataStoresResp ListDataStores(string siteUri, ListDataStoresReqEx reqEx)
		{
			ListDataStoresResp listDataStoresResp = new ListDataStoresResp();
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/datastores?");
			if (null != reqEx)
			{
				stringBuilder.Append((reqEx.limit == null) ? "" : ("limit=" + reqEx.limit + "&"));
				stringBuilder.Append((reqEx.offset == null) ? "" : ("offset=" + reqEx.offset + "&"));
				stringBuilder.Append((reqEx.scope == null) ? "" : ("scope=" + reqEx.scope + "&"));
				stringBuilder.Append((reqEx.status == null) ? "" : ("status=" + reqEx.status + "&"));
				stringBuilder.Append((reqEx.name == null) ? "" : ("name=" + reqEx.name + "&"));
				stringBuilder.Append((reqEx.exceptDatastoreType == null) ? "" : ("exceptDatastoreType=" + reqEx.exceptDatastoreType + "&"));
			}
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListDataStores");
			CommonResource.log.Info("ListDataStores result : " + text);
			return JsonConvert.DeserializeObject<ListDataStoresResp>(text);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x000039AC File Offset: 0x00001BAC
		public ListDvswitchsResp ListDvswitchs(string siteUri, ListDvswitchsReqEx reqEx)
		{
			ListDvswitchsResp listDvswitchsResp = new ListDvswitchsResp();
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/dvswitchs?");
			if (null != reqEx)
			{
				stringBuilder.Append((reqEx.location == null) ? "" : ("location=" + reqEx.location + "&"));
				stringBuilder.Append((reqEx.name == null) ? "" : ("name=" + reqEx.name + "&"));
			}
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListDvswitchs");
			CommonResource.log.Info("ListDvswitchs result : " + text);
			return JsonConvert.DeserializeObject<ListDvswitchsResp>(text);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00003A7C File Offset: 0x00001C7C
		public ListPortGroupsResp ListPortGroups(string dvswitchUri, ListPortGroupsReqEx reqEx)
		{
			ListPortGroupsResp listPortGroupsResp = new ListPortGroupsResp();
			StringBuilder stringBuilder = new StringBuilder(dvswitchUri + "/portgroups?");
			if (null != reqEx)
			{
				stringBuilder.Append((reqEx.limit == null) ? "" : ("limit=" + reqEx.limit + "&"));
				stringBuilder.Append((reqEx.offset == null) ? "" : ("offset=" + reqEx.offset + "&"));
				stringBuilder.Append((reqEx.portGroupName == null) ? "" : ("portGroupName=" + reqEx.portGroupName + "&"));
			}
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListPortGroups");
			CommonResource.log.Info("ListPortGroups result : " + text);
			return JsonConvert.DeserializeObject<ListPortGroupsResp>(text);
		}

		// Token: 0x04000082 RID: 130
		private static CommonResource instance = null;

		// Token: 0x04000083 RID: 131
		private ClientProviderBean bean;

		// Token: 0x04000084 RID: 132
		private static ILog log = LogManager.GetLogger(typeof(CommonResource));
	}
}
