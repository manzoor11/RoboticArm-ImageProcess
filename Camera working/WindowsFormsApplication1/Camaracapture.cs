using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.CvEnum;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Camaracapture : Form
    {
        Capture camera= default (Capture);
        public  Image<Bgr,Byte>  CameraImage;
        Image<Gray, byte> ProcessedImage;
        Image<Gray, byte> DetectedImage;
        int circlecount = 0, cropx = 0, circle_x = 0, circle_y = 0, rectangle_x = 0, rectangle_y = 0, cropy = 0, cropwidth = 0, cropheight = 0;
        public byte []  tosend;
        float circlex = 0, circley = 0;
        bool portconnected = false, mousedown = false, iscroping = false ;
        Rectangle ImageRect;  
       
        public Camaracapture()
        {
                InitializeComponent();

                #region if capture is not created, create it now
                if (camera == null)
                {
                    try
                    {
                        camera = new Capture();
                        camera.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 256);
                        camera.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 256);
                    }
                    catch (NullReferenceException excpt)
                    {
                        MessageBox.Show(excpt.Message);
                    }
                }
                #endregion
                Application.Idle += new EventHandler(IdleProcess);
                CorrectImageBox(camera.Width, camera.Height);
                ImageRect = new Rectangle(0, 0, camera.Width, camera.Height);
                DetectedImage = new Image<Gray, byte>(camera.Width, camera.Height);
                SearchforSerialPort();
              //  comboBox1.SelectedIndex = 0;
            }

        

        void IdleProcess(object sender, EventArgs e)
        { 
            Emgu.CV.Image<Bgr, Byte> CameraImage = camera.QueryFrame();
             CameraImage = new Image<Bgr, Byte>(CropImage(ImageRect));
             
            
            if (iscroping)
                CameraImage.Draw(new Rectangle(cropx, cropy, cropwidth, cropheight), new Bgr(Color. Green), 3);
           
            camimagebox.Image = CameraImage.Bitmap;
            ProcessedImage = CameraImage.InRange(new Bgr(Bmin.Value, Gmin.Value, Rmin.Value), new Bgr(Bmax.Value, Gmax.Value, Rmax.Value));
           
            ProcessedImage.SmoothGaussian(9);
            StructuringElementEx rect_12 = new StructuringElementEx(12, 12, 6, 6, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
            CvInvoke.cvErode(ProcessedImage, ProcessedImage, rect_12, 1);
            StructuringElementEx rect_6 = new StructuringElementEx(6, 6, 3, 3, Emgu.CV.CvEnum.CV_ELEMENT_SHAPE.CV_SHAPE_RECT);
            CvInvoke.cvDilate(ProcessedImage, ProcessedImage, rect_6, 2);

            ExtractShapes(ProcessedImage,CameraImage );
            processedimagebox.Image = ProcessedImage.Bitmap;

          /*  if (portconnected)
            {
                if (tosend == 1)
                    serialPort1.Write("To send Cuboid");
                else if (tosend == 2)
                    serialPort1.Write("To Send Cylinder");
            }
          */

            label1.Text = rectangle_x + "& Y:" + rectangle_y;

        }

        void SearchCircles(Image<Gray, byte> Image)
        {
            circlex = circley = 0;
            circlecount = 0;
            CircleF[] circles = DetectedImage.HoughCircles(new Gray(250.0), new Gray(120), 2.0, 20.0, 25, 0)[0];
            circlecount = circles.Length;
            if (circles.Length > 0)
            {
                foreach (CircleF circle in circles)
                {
                    circlex += circle.Center.X;
                    circley += circle.Center.Y;
                }
                circlex /= circles.Length;
                circley /= circles.Length;
            }
        }

        private void ExtractShapes(Image<Gray,byte> skin ,Image<Bgr,byte> CameraImage)
        {
            circle_x = circle_y = rectangle_x = rectangle_y = 0;
            Contour<Point> polygoncontour;
            Contour<Point>[] contour = new Contour<Point>[2];
            using (MemStorage storage = new MemStorage())
            {
                SearchCircles(ProcessedImage);
                Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_TREE, storage);
                DetectedImage.SetZero();

                Double area = 0.0;

                while (contours != null)
                {
                    if (contours.Area > area)
                    {
                        area = contours.Area;
                        contour[1] = contour[0];
                        contour[0] = contours;
                    }
                    else
                    {
                        if (contour[1] == null)
                        {
                            contour[1] = contours;
                        }
                    }
                    contours = contours.HNext;
                }

                if (contour != null)
                {
                    for (int i = 0; (i < 2 && contour[i] != null); i++)
                    {
                        if (contour[i].Area > 1000)
                        {
                            polygoncontour = contour[i].ApproxPoly(contour[i].Perimeter * 0.05, storage);
                            float sx = contour[i].GetMinAreaRect().center.X;
                            float sy = contour[i].GetMinAreaRect().center.Y;
                            if (circlecount > 0)
                            {
                                if (!(sx > circlex - 20 && sx < circlex + 20))
                                {
                                    CameraImage.Draw(polygoncontour, new Bgr(Color.Yellow), 5);
                                    CameraImage.Draw(new CircleF(new PointF(sx, sy), 3), new Bgr(Color.Yellow), 4);
                                    rectangle_x = Convert.ToInt16 ((Convert.ToInt32(widthtbx.Text) * sx) / CameraImage.Width);
                                    rectangle_y = Convert.ToInt16 ((Convert.ToInt32(heighttbx.Text)) - ((Convert.ToInt32(heighttbx.Text) * sy) / CameraImage.Height));
                                }
                                else
                                {
                                    CameraImage.Draw(contour[i], new Bgr(Color.Red), 4);
                                    CameraImage.Draw(new CircleF(new PointF(sx, sy), 3), new Bgr(Color.Red), 4);
                                    circle_x = Convert.ToInt16 ((Convert.ToInt32(widthtbx.Text) * sx) / CameraImage.Width);
                                    circle_y = Convert.ToInt16 ((Convert.ToInt32(heighttbx.Text)) - ((Convert.ToInt32(heighttbx.Text) * sy) / CameraImage.Height));
                                }
                            }
                            else
                            {
                                CameraImage.Draw(polygoncontour, new Bgr(Color.Yellow), 5);
                                CameraImage.Draw(new CircleF(new PointF(sx, sy), 3), new Bgr(Color.Yellow), 4);
                                rectangle_x = Convert.ToInt16 ( (Convert.ToInt32(widthtbx.Text) * sx) / CameraImage.Width);
                                rectangle_y = Convert.ToInt16 ((Convert.ToInt32(heighttbx.Text)) - ((Convert.ToInt32(heighttbx.Text) * sy) / CameraImage.Height));
                            }
                            DetectedImage.Draw(contour[i], new Gray(200), 10);
                        }
                    }
                }
            }
 	
        }

        private void SearchforSerialPort()
        {
            String[] ports = SerialPort.GetPortNames();
            foreach (String port in ports)
                comboBox1.Items.Add(port);
        }

        private void ConnecttoPort(string portname)
        {
            serialPort1.Close();
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            try
            {
                serialPort1.Open();
                portconnected = true;
                seriallbl.Text = "connected " + serialPort1.PortName;
            }
            catch
            {
                seriallbl.Text = "Fail To Connect";
                portconnected = false;
                comboBox1.Items.Clear();
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                    comboBox1.Items.Add(port);
            }
        }

     private void cropbtn_Click_1(object sender, EventArgs e)
        {
            if (iscroping)
            {
                if (cropwidth != 0 && cropheight != 0)
                {
                    ImageRect = new Rectangle(cropx, cropy, cropwidth, cropheight);
                    CorrectImageBox(ImageRect.Width, ImageRect.Height);
                }
                cropbtn.BackColor = Color.OrangeRed;
                iscroping = false;
            }
            else
            {
                cropx = cropy = cropheight = cropwidth = 0;
                ImageRect = new Rectangle(0, 0, camera.Width, camera.Height);
                CorrectImageBox(camera.Width, camera.Height);
                cropbtn.BackColor = Color.GreenYellow;
                iscroping = true;
            }
        }
        
        private void CorrectImageBox(int Width, int Height)
        {
            if (Width > Height)
            {
                float camwidth = Width, boxwidth = camimagebox.Width;
                float ratio = boxwidth / camwidth;
                camimagebox.Height = Convert.ToInt32(Height * ratio);
                processedimagebox.Height = Convert.ToInt32(Height * ratio);
            }
            else
            {
                float camwidth = Height, boxwidth = camimagebox.Height;
                float ratio = boxwidth / camwidth;
                camimagebox.Width = Convert.ToInt32(Width * ratio);
                processedimagebox.Width = Convert.ToInt32(Width * ratio);
            }
        }

        private Bitmap CropImage(Rectangle rect)
        {
            Bitmap  image = new Bitmap (rect.Width, rect.Height);
            Graphics grap = Graphics.FromImage(image);
            grap.DrawImage(camera.QueryFrame().Bitmap, new Rectangle(0, 0, image.Width, image.Height), rect, GraphicsUnit.Pixel);
            return image;
        }


        private void Camaracapture_Load(object sender, EventArgs e)
        {

        }

        private void camimagebox_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            cropx = (camera.Width * e.X) / camimagebox.Width;
            cropy = (camera.Height * e.Y) / camimagebox.Height;
        }

        private void camimagebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                cropwidth = ((camera.Width * (e.X)) / camimagebox.Width) - cropx;
                cropheight = ((camera.Height * (e.Y)) / camimagebox.Height) - cropy;
                if (cropheight > cropwidth)
                    cropheight = cropwidth - 1;
            }
        }

        private void camimagebox_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;

        }

        private void Camaracapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y > this.Height - 100)
                toolPanel.Visible = true;
            else
                toolPanel.Visible = false;
        }

        private void camimagebox_MouseEnter(object sender, EventArgs e)
        {
            toolPanel.Visible = false;
        }

        private void cylinderbtn_Click(object sender, EventArgs e)
        {
           byte[] tosend = new byte[1] {Convert.ToByte((circle_x*10) + circle_y)};
            //tosend = 2;
            if (portconnected)
                serialPort1.Write(tosend,0,1);
        }

        private void cuboidbtn_Click(object sender, EventArgs e)
        {
            byte[] tosend = new byte[1] {Convert.ToByte((rectangle_x * 10) + rectangle_y)};
            //tosend = 1;
            if (portconnected)
                serialPort1.Write(tosend, 0, 1);
        }

        private void connect_Click(object sender, EventArgs e)
        {
            ConnecttoPort(comboBox1.SelectedText);
        }

        private void camimagebox_Click(object sender, EventArgs e)
        {

        }

    
    }
}