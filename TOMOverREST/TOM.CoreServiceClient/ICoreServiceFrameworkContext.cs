﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using Tridion.ContentManager.CoreService.Client;

namespace TOM.CoreServiceClient
{
    public interface ICoreServiceFrameworkContext : IDisposable
    {
        //internal void intCoreServiceClient(Binding channelBinding, Uri endpointUri, NetworkCredential credentials);
        Uri EndpointUri { get; }
        ISessionAwareCoreService Client { get; }
        Binding GetBinding();
    }
}
