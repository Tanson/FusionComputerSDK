using System;
using System.Text;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.UserModel;
using FuctionComputerSDK.Utils;
using log4net;
using Newtonsoft.Json;

namespace FuctionComputerSDK.ClientResource
{
	// Token: 0x02000049 RID: 73
	public class UserResource
	{
		// Token: 0x06000388 RID: 904 RVA: 0x000075C0 File Offset: 0x000057C0
		private UserResource()
		{
		}

		// Token: 0x06000389 RID: 905 RVA: 0x000075CC File Offset: 0x000057CC
		public static UserResource GetInstance(ClientProviderBean bean)
		{
			if (null == UserResource.instance)
			{
				UserResource.instance = new UserResource();
			}
			UserResource.instance.init(bean);
			return UserResource.instance;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000760A File Offset: 0x0000580A
		private void init(ClientProviderBean arg)
		{
			this.bean = arg;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00007614 File Offset: 0x00005814
		public UserTaskResp AddUser(AddUserReq req)
		{
			string text = RestClientUtil.sendRequest("POST", "/service/users", req, this.bean, "AddUser");
			UserResource.log.Info("AddUser result : " + text);
			return JsonConvert.DeserializeObject<UserTaskResp>(text);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00007660 File Offset: 0x00005860
		public ListUsersResp ListUsers(ListUsersReq req)
		{
			StringBuilder stringBuilder = new StringBuilder("/service/users?");
			if (null != req)
			{
				stringBuilder.Append((req.limit == null) ? "" : ("limit=" + req.limit + "&"));
				stringBuilder.Append((req.offset == null) ? "" : ("offset=" + req.offset + "&"));
				stringBuilder.Append((req.userType == null) ? "" : ("userType=" + req.userType + "&"));
				stringBuilder.Append((req.userName == null) ? "" : ("userName=" + req.userName + "&"));
				stringBuilder.Append((req.createStartTime == null) ? "" : ("createStartTime=" + req.createStartTime + "&"));
				stringBuilder.Append((req.createStopTime == null) ? "" : ("createStopTime=" + req.createStopTime + "&"));
				stringBuilder.Append((req.manageStatus == null) ? "" : ("manageStatus=" + req.manageStatus + "&"));
			}
			string text = RestClientUtil.sendRequest("Get", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListUsers");
			UserResource.log.Info("ListUsers result : " + text);
			return JsonConvert.DeserializeObject<ListUsersResp>(text);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00007828 File Offset: 0x00005A28
		public UserTaskResp ModifyUser(string userId, ModifyUserReq req)
		{
			string text = RestClientUtil.sendRequest("PUT", "/service/users/" + userId, req, this.bean, "ModifyUser");
			UserResource.log.Info("ModifyUser result : " + text);
			return JsonConvert.DeserializeObject<UserTaskResp>(text);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000787C File Offset: 0x00005A7C
		public SDKCommonResp SetUserRoles(string userId, SetUserRolesReq req)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/users/" + userId + "/setRoles", req, this.bean, "SetUserRoles");
			UserResource.log.Info("SetUserRoles result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x000078DC File Offset: 0x00005ADC
		public SDKCommonResp ModifyPassword(ModifyPasswordReq req)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/users/password/modify", req, this.bean, "ModifyPassword");
			UserResource.log.Info("ModifyPassword result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00007930 File Offset: 0x00005B30
		public SDKCommonResp ResetPassword(ResetPasswordReq req)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/users/password/reset", req, this.bean, "ResetPassword");
			UserResource.log.Info("ResetPassword result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00007984 File Offset: 0x00005B84
		public SDKCommonResp RemoveUser(string userId)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("DELETE", "/service/users/" + userId, null, this.bean, "RemoveUser");
			UserResource.log.Info("RemoveUser result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000079DC File Offset: 0x00005BDC
		public SDKCommonResp AddRole(AddRoleReq req)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/roles/add", req, this.bean, "AddRole");
			UserResource.log.Info("AddRole result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00007A30 File Offset: 0x00005C30
		public ListRolesResp ListRoles(int? limit, int? offset)
		{
			StringBuilder stringBuilder = new StringBuilder("/service/roles/list?");
			stringBuilder.Append((limit == null) ? "" : ("limit=" + limit + "&"));
			stringBuilder.Append((offset == null) ? "" : ("offset=" + offset + "&"));
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(0, stringBuilder.Length - 1), null, this.bean, "ListRoles");
			UserResource.log.Info("ListRoles result : " + text);
			return JsonConvert.DeserializeObject<ListRolesResp>(text);
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00007AEC File Offset: 0x00005CEC
		public SDKCommonResp ModifyRole(ModifyRoleReq req)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/roles/mod", req, this.bean, "ModifyRole");
			UserResource.log.Info("ModifyRole result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00007B40 File Offset: 0x00005D40
		public SDKCommonResp RemoveRole(string roleName)
		{
			SDKCommonResp sdkcommonResp = new SDKCommonResp();
			string text = RestClientUtil.sendRequest("POST", "/service/roles/rmv", new RemoveRoleReq
			{
				roleName = roleName
			}, this.bean, "RemoveRole");
			UserResource.log.Info("RemoveRole result : " + text);
			return JsonConvert.DeserializeObject<SDKCommonResp>(text);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00007BA0 File Offset: 0x00005DA0
		public ListRightsResp ListRights(int? rightType)
		{
			ListRightsResp listRightsResp = new ListRightsResp();
			StringBuilder stringBuilder = new StringBuilder("/service/roles/getRights");
			stringBuilder.Append((rightType == null) ? "" : ("?rightType=" + rightType));
			string text = RestClientUtil.sendRequest("GET", stringBuilder.ToString(), null, this.bean, "ListRights");
			UserResource.log.Info("ListRights result : " + text);
			return JsonConvert.DeserializeObject<ListRightsResp>(text);
		}

		// Token: 0x04000198 RID: 408
		private static UserResource instance = null;

		// Token: 0x04000199 RID: 409
		private static ILog log = LogManager.GetLogger(typeof(UserResource));

		// Token: 0x0400019A RID: 410
		private ClientProviderBean bean;
	}
}
