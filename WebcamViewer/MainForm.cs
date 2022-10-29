using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebcamViewer
{
    public partial class MainForm : Form
    {
        private readonly StreamReceiver _streamReceiver;
        private delegate void SetPictureBoxData();
        private SetPictureBoxData _setPictureBoxData;
        private int _port;
        public MainForm()
        {
            InitializeComponent();

            _port = int.Parse(ConfigurationManager.AppSettings.Get("port"));
            _streamReceiver = new StreamReceiver(_port);
        }

        private void ConnectMenuItemClick(object sender, EventArgs e)
        {
            Task.Run(() => DoWork());
        }

        private async Task DoWork()
        {
            byte[] buffer = await _streamReceiver.ReceiveAsync();
            using (var stream = new MemoryStream(buffer))
            {
                pictureBox1.Invoke(new SetPictureBoxData(() => { pictureBox1.Image = new Bitmap(stream); }));
            }
        }

        private void ShowIPAddressesMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", HostInfo.InterNetworkAddresses), "IN IP Addresses");
        }
    }
}
