using AForge.Video;
using AForge.Video.DirectShow;
using Newtonsoft.Json.Linq;
using Starbucks.infrastructure.components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace Starbucks.presentation.employee
{
    public partial class Screen_Employee : Form
    {
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        JObject prodJson;
        public Screen_Employee()
        {
            InitializeComponent();
            qrScanCamera.Location = new Point((ClientSize.Width / 2) - (qrScanCamera.Width / 2), (ClientSize.Height / 2) - (qrScanCamera.Height / 2));
        }

        void openCamera()
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += captureFrame;
            videoCaptureDevice.Start();
        }

        private void captureFrame(object sender,NewFrameEventArgs args) 
        {
            qrScanCamera.Image = (Bitmap)args.Frame.Clone();
        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(qrScanCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)qrScanCamera.Image);
                if(result != null)
                {
                    timer1.Stop();
                    openDatas(result.ToString());
                    if (videoCaptureDevice.IsRunning)
                    {
                        videoCaptureDevice.Stop();
                    }
                }
            }
        }

        void openDatas(string data)
        {
            qrScanCamera.Visible = false;
            productsLabel.Visible = true;
            productsDisplay.Visible = true;
            nextBtn.Visible = true;

            productsDisplay.Controls.Clear();
            prodJson = JObject.Parse(data);
            foreach (var items in prodJson["products"])
            {
                productsDisplay.Controls.Add(new Final_Products
                {
                    Name = items["name"].ToString(),
                    Prod_Size = items["size"].ToString(),
                    Flavour = items["flavour"].ToString()
                });
                Console.WriteLine(items["name"].ToString());
            }

        }

        void closeData()
        {
            qrScanCamera.Visible = true;
            productsLabel.Visible = false;
            productsDisplay.Visible = false;
            nextBtn.Visible = false;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            openCamera();
            timer1.Start();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            closeData();
            openCamera();
            timer1.Start();
        }
    }
}
