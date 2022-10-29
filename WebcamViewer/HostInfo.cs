using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebcamViewer
{
    public static class HostInfo
    {
        public static string HostName => Dns.GetHostName();
        public static IPAddress[] IpAdresses => Dns.GetHostAddresses(Dns.GetHostName());
        public static string[] InterNetworkAddresses => IpAdresses
            .Where(x => x.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
            .Select(x => x.ToString())
            .ToArray();
    }
}
