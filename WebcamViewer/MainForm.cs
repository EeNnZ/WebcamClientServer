using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI;
using DarkUI.Forms;

namespace WebcamViewer
{
    public partial class MainForm : Form
    {
        private CancellationTokenSource _cts = new CancellationTokenSource();
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
            Task.Run(() => DoWork(_cts.Token), _cts.Token);
        }

        private async Task DoWork(CancellationToken token)
        {
            while (true)
            {
                if (token.IsCancellationRequested) return;
                byte[] buffer = await _streamReceiver.ReceiveAsync();
                if (buffer is null)
                {
                    statusLabel.Text = "Trying to connect...";
                } else { statusLabel.Text += $"Recieved: {buffer.LongLength} bytes"; }
                using (var stream = new MemoryStream(buffer))
                {
                    pictureBox1.Invoke(new SetPictureBoxData(() => { pictureBox1.Image = new Bitmap(stream); }));
                } 
            }
        }

        private void ShowIPAddressesMenuItemClick(object sender, EventArgs e)
        {
            MessageBox.Show(string.Join("\n", HostInfo.InterNetworkAddresses), "IN IP Addresses");
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            _cts.Cancel();
        }
    }
}
