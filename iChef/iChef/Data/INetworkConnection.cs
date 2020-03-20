using System;
using System.Collections.Generic;
using System.Text;

namespace iChef.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
