﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TOR.TOMService.BAL.CoreServiceFramework
{
    public class CoreServiceFrameworkNetTcpContext : CoreServiceFrameworkContext
    {

        //Delegate Constructor the Base to leverage shared initialization Code
        public CoreServiceFrameworkNetTcpContext(Uri endpointUri, NetworkCredential windowsNetworkCredentials)
            : base(endpointUri, windowsNetworkCredentials)
        {
        }

        /// <summary>
        /// Initialize a Tcp Core Service Connection with Authentication
        /// More Info: http://code.google.com/p/tridion-practice/wiki/GetCoreServiceClientWithoutConfigFile
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public override Binding GetBinding()
        {
            //NOTE:  WCF will automatically figure out the correct security mode for the 
            //Binding and no obvious performance hit is incurred.
            ////var endpointBinding = new MaxxedWsHttpBinding(SecurityMode.Message);
            ////endpointBinding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
            var endpointBinding = new MaxxedNetTcpBinding();
            return endpointBinding;
        }

    }
}
