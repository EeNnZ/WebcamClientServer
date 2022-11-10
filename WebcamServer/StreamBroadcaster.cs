using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WebcamServer
{
    public class StreamBroadcaster
    {
        private UdpClient _udpClient;
        private int _port = int.Parse(ConfigurationManager.AppSettings.Get("viewerPort"));
        private string _ip = ConfigurationManager.AppSettings.Get("viewerIp");
        private IPEndPoint _endPoint = null;
        public int Port 
        {
            get => _port;
            set
            {
                if (_port != value && 1 < value && value < IPEndPoint.MaxPort)
                {
                    _port = value;
                }
            }
        }
        public string Ip
        {
            get => _ip;
            set
            {
                if (_ip != value && value != null)
                {
                    bool valid = IPAddress.TryParse(value, out IPAddress address);
                    if (valid)
                    {
                        _ip = address.ToString();
                    }
                    else return;
                }
            }
        }
        public IPEndPoint EndPoint 
        {
            get => _endPoint; 
            set
            {
                if (_endPoint != value)
                {
                    _endPoint = value;
                }
            }
        }
        public UdpClient UdpClient => _udpClient;

        public StreamBroadcaster() 
        {
            _endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);
            _udpClient = new UdpClient();
        }
        public StreamBroadcaster(int port, string ip)
        {
            _port = port;
            _ip = ip;
            _endPoint = new IPEndPoint(IPAddress.Parse(_ip), _port);
            _udpClient = new UdpClient();
        }


    }
}
