using FuctionComputerSDK.ClientResource;
using FuctionComputerSDK.DataType;
using FuctionComputerSDK.DataType.CommonModel;
using FuctionComputerSDK.DataType.HostModel;
using FuctionComputerSDK.DataType.UserModel;
using FuctionComputerSDK.DataType.VmModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTestCore
{
    class Program
    {
        static ClientProviderBean bean = new ClientProviderBean();
        static AuthenticateResource auth = AuthenticateResource.GetInstance(bean);
        static HostResource host = HostResource.GetInstance(bean);
        static VmResource vm = VmResource.GetInstance(bean);
        static CommonResource comm = CommonResource.GetInstance(bean);
        static TaskResource task = TaskResource.GetInstance(bean);
        static UserResource user = UserResource.GetInstance(bean);
        static void Main(string[] args)
        {
            bean.serverUrl = "https://url:7443";
            LoginResp resp = auth.Login("Account", "PassWord");
            //var list = user.ListUsers(new ListUsersReq() {offset=0,limit=100,userType="0"});
            //var hosts = host.ListHosts("/service/sites/4EEE09DA", new ListHostsReq() { limit = 100, offset = 0 , scope="default"});
            //var vms = vm.ListVms("/service/sites/4EEE09DA", new ListVmsReq() { offset=0,limit=100});
            var sites = comm.ListSites();
            foreach (var item in sites.sites)
            {
                var hosts = host.ListHosts(item.uri, new ListHostsReq() { limit = 100, offset = 0, scope = "default" });
                foreach (var host in hosts.hosts)
                {
                    Console.WriteLine(host.uri);
                }
                var clustes = comm.ListClusters(item.uri, new ListClustersReqEx());
                foreach (var cluster in clustes.clusters)
                {
                    Console.WriteLine(cluster.uri);
                    var tests = host.ListHosts(item.uri, new ListHostsReq() { limit = 100, offset = 0, scope = cluster.urn });
                    foreach (var host in tests.hosts)
                    {
                        Console.WriteLine(host.ip + "," + host.status + "," + host.cpuQuantity);
                    }

                }
            }
            //foreach (var item in list.users)
            //{
            //    Console.WriteLine(item.userName + ",usertype:" + item.userType);
            //}
            Console.ReadLine();
        }
    }
}
