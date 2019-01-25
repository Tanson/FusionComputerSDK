using System;
using System.Text;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.CommonModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x0200000D RID: 13
	public class TaskResource
	{
		// Token: 0x06000084 RID: 132 RVA: 0x00002946 File Offset: 0x00000B46
		private TaskResource()
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002954 File Offset: 0x00000B54
		public static TaskResource GetInstance(ClientProviderBean bean)
		{
			if (null == TaskResource.instance)
			{
				TaskResource.instance = new TaskResource();
			}
			TaskResource.instance.init(bean);
			return TaskResource.instance;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002992 File Offset: 0x00000B92
		private void init(ClientProviderBean arg)
		{
			this.bean = arg;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000299C File Offset: 0x00000B9C
		public TaskInfo QueryTask(string taskUri)
		{
			string text = RestClientUtil.sendRequest("GET", taskUri, null, this.bean, "QueryTask");
			TaskResource.log.Info("QueryTask result : " + text);
			return JsonConvert.DeserializeObject<TaskInfo>(text);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000029E4 File Offset: 0x00000BE4
		public SDKCommonResp Cancel(string taskUri)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", taskUri + "/cancel", null, this.bean, "Cancel");
			TaskResource.log.Info("Cancel result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002A3C File Offset: 0x00000C3C
		public ListTasksResp ListTasks(string siteUri, ListTasksReqEx reqEx)
		{
			ListTasksResp listTasksResp = new ListTasksResp();
			StringBuilder stringBuilder = new StringBuilder(siteUri + "/tasks?");
			if (null != reqEx)
			{
				stringBuilder.Append((reqEx.limit == null) ? "" : ("limit=" + reqEx.limit + "&"));
				stringBuilder.Append((reqEx.offset == null) ? "" : ("offset=" + reqEx.offset + "&"));
				stringBuilder.Append((reqEx.scope == null) ? "" : ("scope=" + reqEx.scope + "&"));
				stringBuilder.Append((reqEx.type == null) ? "" : ("type=" + reqEx.type + "&"));
				stringBuilder.Append((reqEx.user == null) ? "" : ("user=" + reqEx.user + "&"));
				stringBuilder.Append((reqEx.status == null) ? "" : ("status=" + reqEx.status + "&"));
				stringBuilder.Append((reqEx.startTime == null) ? "" : ("startTime=" + reqEx.startTime + "&"));
				stringBuilder.Append((reqEx.finishTime == null) ? "" : ("finishTime=" + reqEx.finishTime + "&"));
				if (reqEx.taskUrns != null && reqEx.taskUrns.Count > 0)
				{
					foreach (string text in reqEx.taskUrns)
					{
						if (null != text)
						{
							stringBuilder.Append("taskUrns=").Append(text + "&");
						}
					}
				}
				stringBuilder.Append((reqEx.cancelled == null) ? "" : ("cancelled=" + reqEx.cancelled + "&"));
			}
			string text2 = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListTasks");
			TaskResource.log.Info("ListTasks result : " + text2);
			return JsonConvert.DeserializeObject<ListTasksResp>(text2);
		}

		// Token: 0x0400003C RID: 60
		private static TaskResource instance = null;

		// Token: 0x0400003D RID: 61
		private static ILog log = LogManager.GetLogger(typeof(TaskResource));

		// Token: 0x0400003E RID: 62
		private ClientProviderBean bean;
	}
}
