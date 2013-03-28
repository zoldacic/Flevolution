using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Threading;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;
using Microsoft.WindowsAzure.StorageClient;

namespace WorkerRole
{
    public class WorkerRole : RoleEntryPoint
    {
        public override void Run()
        {
            // This is a sample worker implementation. Replace with your logic.
            Trace.WriteLine("WorkerRole entry point called", "Information");

            while (true)
            {
                Thread.Sleep(10000);
                Trace.WriteLine("Working", "Information");
            }
        }

        public override bool OnStart()
        {
            // Set the maximum number of concurrent connections 
            ServicePointManager.DefaultConnectionLimit = 12;

            WcfStart();

            // For information on handling configuration changes
            // see the MSDN topic at http://go.microsoft.com/fwlink/?LinkId=166357.

            return base.OnStart();
        }

        public void WcfStart()
        {
            // Create the host
            var host = new ServiceHost(typeof(GameService));

            // Read config parameters
            var workerRoleEndpoint = RoleEnvironment.CurrentRoleInstance.InstanceEndpoints["port"].IPEndpoint;
            var workerRoleMexEndpoint = RoleEnvironment.CurrentRoleInstance.InstanceEndpoints["mexport"].IPEndpoint;

            var hostName = workerRoleEndpoint.Address.ToString();
            var port = workerRoleEndpoint.Port;
            var mexport = workerRoleMexEndpoint.Port;

            // Create end point
            var mexBinding = MetadataExchangeBindings.CreateMexTcpBinding();

            var endpointurl = string.Format("net.tcp://{0}:{1}/GameService", hostName, 9001);
            var mexendpointurl = string.Format("net.tcp://{0}:{1}/GameServiceMetadata", hostName, 8001);
                                    
            host.AddServiceEndpoint(typeof(IGameService), new NetTcpBinding(SecurityMode.None), endpointurl, new Uri(endpointurl));
            host.AddServiceEndpoint(typeof(IMetadataExchange), mexBinding, mexendpointurl, new Uri(mexendpointurl));

            // Open the host
            host.Open();

            // Trace output
            Trace.WriteLine("WCF Listening At: " + endpointurl);
            Trace.WriteLine("WCF MetaData Listening At: " + mexendpointurl);
        }
    }
}
