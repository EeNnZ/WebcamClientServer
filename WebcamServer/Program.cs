using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WebcamServer
{
    internal class Program
    {
        private static StreamBroadcaster _broadcaster = new StreamBroadcaster();
        static void Main(string[] args)
        {
            Webcam webcam = new Webcam();
            webcam.NewFrame += WebcamNewFrameEventHandler;
            webcam.Start();

            Console.ReadLine();
        }

        private static void WebcamNewFrameEventHandler(object sender, AForge.Video.NewFrameEventArgs e)
        {
            var bitmap = new Bitmap(e.Frame, 800, 600);
            try
            {
                using (var stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Jpeg);
                    byte[] bytes = stream.ToArray();
                    _broadcaster.UdpClient.Send(bytes, bytes.Length, _broadcaster.EndPoint);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
