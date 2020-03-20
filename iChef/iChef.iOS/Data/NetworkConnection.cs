using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using CoreFoundation;
using Foundation;
using iChef.Data;
using iChef.iOS.Data;
using SystemConfiguration;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetworkConnection))]
namespace iChef.iOS.Data
{
    class NetworkConnection : INetworkConnection
    {
        private NetworkReachability DefaultReachability;
        private event EventHandler ReachabilityChanged;
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            InternetStatus();
        }

        public bool InternetStatus()
        {
            NetworkReachabilityFlags flags;
            bool defaultNetworkAvailable = IsNetworkAvailable(out flags);

            if (defaultNetworkAvailable && ((flags & NetworkReachabilityFlags.IsDirect) != 0))
            {
                return false;
            }
            else if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
            {
                return true;
            }
            else if (flags == 0)
            {
                return false;
            }
            return true;
        }

        private bool IsNetworkAvailable(out NetworkReachabilityFlags flags)
        {
            if (DefaultReachability == null)
            {
                DefaultReachability = new NetworkReachability(new IPAddress(0));
                DefaultReachability.SetNotification(OnChange);
                DefaultReachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
            }
            if (!DefaultReachability.TryGetFlags(out flags))
            {
                return false;
            }
            return IsReachableWithoutRequiringConnection(flags);
        }

        public void OnChange(NetworkReachabilityFlags flags)
        {
            ReachabilityChanged?.Invoke(null, EventArgs.Empty);
        }

        private bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            bool isReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;
            bool noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
            {
                noConnectionRequired = true;
            }
            return isReachable && noConnectionRequired;
        }
    }
}