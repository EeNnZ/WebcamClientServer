using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcamServer
{
    public class Webcam
    {
        public VideoCaptureDevice VideoSource { get; set; }
        public FilterInfoCollection VideoDevices { get; set; }
        public event EventHandler<AForge.Video.NewFrameEventArgs> NewFrame;
        public Webcam()
        {
            VideoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            VideoSource = new VideoCaptureDevice(VideoDevices[0].MonikerString);
            VideoSource.NewFrame += FrameChanged;
        }

        protected virtual void FrameChanged(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            NewFrame?.Invoke(this, eventArgs);
        }

        public void Start()
        {
            VideoSource.Start();
        }

        public void Stop()
        {
            VideoSource.Stop();
        }

    }
}
