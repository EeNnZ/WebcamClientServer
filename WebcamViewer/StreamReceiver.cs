using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebcamViewer
{
    public class StreamReceiver
    {
        public int Port { get; }
        private readonly UdpClient _udpClient;

        public StreamReceiver(int port) 
        {
            Port = port;
            _udpClient = new UdpClient(Port);
        }

        public async Task<byte[]> ReceiveAsync()
        {
            UdpReceiveResult result;
            try
            {
                result = await _udpClient.ReceiveAsync();
            }
            catch (Exception)
            {
                return null;
            }
            return result.Buffer;
        }
    }
}
