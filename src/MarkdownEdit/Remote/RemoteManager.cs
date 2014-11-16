﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MarkdownEdit
{
    public class RemoteManager : IRemoteManager
    {
        public IRemoteProvider[] Providers { get; private set; }
         
        public RemoteManager()
        {
            var googleDrive = new GoogleDriveRemoteProvider();
            Providers = new[] { googleDrive };
        }

        public IEnumerable<IRemoteProvider> LinkedRemoteProviders()
        {
            throw new NotImplementedException();
        }

        public Task LinkRemoteProvider(IRemoteProvider remote)
        {
            throw new NotImplementedException();
        }

        public string[] RemoteProviders()
        {
            throw new NotImplementedException();
        }

        public Task UnlinkRemoteProvider(IRemoteProvider remote)
        {
            throw new NotImplementedException();
        }
    }
}