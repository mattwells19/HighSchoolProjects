using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics;

namespace Check_In_Out_2
{
    public partial class Form2 : Form
    {
        Form1 form = new Form1();
        string lengthday = "";
        bool camera = true;
        string link;
        VideoCaptureDevice videoSource;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            txtName.Text = txtName.Text.Trim();
            txtTeach.Text = txtTeach.Text.Trim();
            if (txtName.Text == "" || txtTeach.Text == "")
            {
                MessageBox.Show("Please enter something in all fields. If you do not know who you are subbing for, ask and come back.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (radAll.Checked)
            {
                lengthday = "All Day";
            }
            else
            {
                lengthday = "Half Day";
            }

            Picture(txtName.Text);
            File.WriteAllText(form.badge, "Substitute: " + txtName.Text + "\r\n" + txtTeach.Text + "\r\n" + DateTime.Now.ToString("M/d/yyyy") + "\r\n" + lengthday);
            BadgePrint();
            File.AppendAllText(form.loc + "\\Subs.txt",txtName.Text + "," + txtTeach.Text + "," + lengthday + "," + DateTime.Now.ToString("M/d/yyyy") + "," + link + "\r\n");
            MessageBox.Show("Thank you. Have a nice day!","Thank You!",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private static void BadgePrint()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c NOTEPAD /P %USERPROFILE%\\Desktop\\Badge.txt";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                string[] all = File.ReadAllLines(form.loc + "\\TeachersList.txt");
                PictureSet();
                for (int i = 0; i < all.Length; i++)
                {
                    txtTeach.Items.Add(all[i]);
                }
                txtTeach.Sorted = true;
            }
            catch
            {
                MessageBox.Show("This feature has not been enabled by administration.", "Not Available"); this.Close();
            }
        }

        public void PictureSet()
        {
            //List all available video sources. (That can be webcams as well as tv cards, etc)
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //Check if atleast one video source is available
        if (videosources != null)
            {
                //For example use first video device. You may check if this is your webcam.
                try
                {
                    videoSource = new VideoCaptureDevice(videosources[0].MonikerString);
                    //Create NewFrame event handler
                    //This one triggers every time a new frame/image is captured
                    videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                    //Start recording
                    videoSource.Start();
                }
                catch { camera = false; } 
            }
        }
        public void Picture(string text)
        {
            if (camera == false || pBSub.Image == null)
            {
                pBSub.Image = Wells_FrontDesk_Check_In.Properties.Resources.img_not_found;
            }
            pBSub.Image.Save(form.pics + "\\" + text + DateTime.Now.ToString("hh_mm") + ".jpg");
            link = form.pics + "\\" + text + DateTime.Now.ToString("hh_mm") + ".jpg";
        }
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pBSub.Image = (Bitmap)eventArgs.Frame.Clone();    
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
    }
}
