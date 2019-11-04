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
    public partial class Form1 : Form
    {
        int cntr;
        string Studs;
        string Viss;
        public string pics;
        public string link;
        public string badge = @"C:\FrontDeskData\Badge.txt";
        string checkPrint = @"C:\FrontDeskData\\checkPrint.txt";
        public string loc;// = @"\\10.200.247.22\Temp\CTE\Check In Out Program Files\" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2];
        public bool camera;
        public VideoCaptureDevice videoSource;
        
        public Form1()
        {
            InitializeComponent();
            pictureBoxVideo.Location = new Point(0, 0);
            pictureBoxVideo.Size = new Size(400, 400);
            pictureBoxVideo.SizeMode = PictureBoxSizeMode.CenterImage;
            grpAll.Left = (this.Width - grpAll.Width) / 2;
            grpAll.Top = (this.Height - grpAll.Height) / 2;
            camera = true;
            if (!File.Exists(@"C:\FrontDeskData\ServerLoc.txt"))
            {
                Directory.CreateDirectory(@"C:\FrontDeskData");
                File.Create(@"C:\FrontDeskData\ServerLoc.txt").Dispose();
                File.WriteAllText(@"C:\FrontDeskData\ServerLoc.txt", Microsoft.VisualBasic.Interaction.InputBox("Please paste the file location.\r\nEx: \\\\CTEC_SERVER\\Data\\\r\nPlease include the last backslash as well.", "New Server Location"));
            }
            loc = File.ReadAllText(@"C:\FrontDeskData\ServerLoc.txt") + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2];
            Studs = loc + "\\Student.txt";
            Viss = loc + "\\Visitor.txt";
            pics = loc + "\\Pictures";
            if (!File.Exists(badge)) { File.Create(badge).Dispose(); }
            if (!File.Exists(checkPrint)) { File.Create(checkPrint).Dispose(); }
            string check = File.ReadAllText(checkPrint);
            if (check == "True")
            {
                chkPrint.Checked = true;
            }
            else
            {
                chkPrint.Checked = false;
            }
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            txtName.Text = txtName.Text.Trim();
            txtReason.Text = txtReason.Text.Trim();
            if (txtName.Text == "")
            {
                MessageBox.Show("Enter your name.", "Missed One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtReason.Text == "")
            {
                MessageBox.Show("Enter your reason.", "Missed One", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string radchecked; string by = "";
                if (radStu.Checked)
                {
                    if (radIn.Checked)
                    {
                        radchecked = "Checked In";
                    }
                    else
                    {
                        radchecked = "Checked Out";
                        do
                        {
                            if (chkSpanish.Checked)
                            {
                                by = Microsoft.VisualBasic.Interaction.InputBox("Nombre de la persona que firma estudiante fuera.", "Nombre del Padre.");
                            }
                            else
                            {
                                by = Microsoft.VisualBasic.Interaction.InputBox("Name of person signing student out.", "Name of Parent");
                            }
                            by = by.Trim();
                        }
                        while (by == "");
                    }
                    //pictureBoxVideo.Visible = true;
                    if (radchecked == "Checked In")
                    {
                        File.WriteAllText(badge, txtName.Text + "\r\n" + "Excused: Y/N" + "\r\n" + DateTime.Now.ToString("M/d/yyyy") + " " + DateTime.Now.ToString("h:mm") + "\r\n" + "Signature:");
                        if (chkPrint.Checked == true)
                        {
                            BadgePrint();
                        }
                    }
                    Picture(txtName.Text);
                    File.AppendAllText(Studs, txtName.Text + "," + DateTime.Now.ToString("M/d/yyyy") + "," + radchecked + "," + DateTime.Now.ToString("h:mm") + "," + txtReason.Text + "," + by + "," + link + "\r\n");
                }
                else if (radVis.Checked)
                {
                    File.WriteAllText(badge, "Visitor: " + DateTime.Now.ToString("M/d/yyyy") + "\r\n" + DateTime.Now.ToString("h:mm") + "\r\n" + txtName.Text);
                    if (chkPrint.Checked == true)
                    {
                        BadgePrint();
                    }
                    Picture(txtName.Text);
                    File.AppendAllText(Viss, txtName.Text + "," + DateTime.Now.ToString("M/d/yyyy") + "," + DateTime.Now.ToString("h:mm") + "," + txtReason.Text + "," + link + "\r\n");
                }

                if (chkSpanish.Checked)
                {
                    MessageBox.Show("¡Gracias tenga un buen día!", "CTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thank you and have a good day!", "CTEC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtName.Text = ""; txtReason.Text = ""; radStu.Checked = true; radIn.Checked = true; if (chkSpanish.Checked) chkSpanish.Checked = false;
                //pictureBoxVideo.Image = null;
                pictureBoxVideo.Visible = false;
                txtName.Focus();
                cntr = 0;
                timer1.Start();
            }
        }

        private void BadgePrint()
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c Start NotePAD /P %USERPROFILE%\\Desktop\\Badge.txt";
            process.StartInfo = startInfo;
            process.Start();
        }
        private void radVis_CheckedChanged(object sender, EventArgs e)
        {
            grpInOut.Enabled = false;
        }
        private void radStu_CheckedChanged(object sender, EventArgs e)
        {
            grpInOut.Enabled = true;
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
                    //videoSource.Start();
                }
                catch { camera = false; } 
            }
        }
        public void Picture(string text)
        {
            if (camera == false || pictureBoxVideo.Image == null)
            {
                pictureBoxVideo.Image = Wells_FrontDesk_Check_In.Properties.Resources.img_not_found;
            }
            pictureBoxVideo.Image.Save(pics + "\\" + text + DateTime.Now.ToString("hh_mm") + ".jpg");
            link = pics + "\\" + text + DateTime.Now.ToString("hh_mm") + ".jpg";
        }
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            pictureBoxVideo.Image = (Bitmap)eventArgs.Frame.Clone();    
        }
        private void radStu_CheckedChanged_1(object sender, EventArgs e)
        {
            grpInOut.Enabled = true;
        }
        private void radVis_CheckedChanged_1(object sender, EventArgs e)
        {
            grpInOut.Enabled = false;
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            PictureSet();
            pBLogo.Location = new Point((grpAll.Location.X + (grpAll.Width / 2)) - (pBLogo.Width / 2), this.Top);
            try
            {
                if (!File.Exists(loc + "\\Student.txt")) { Directory.CreateDirectory(loc).Create(); File.Create(loc + "\\Student.txt").Dispose(); File.Create(loc + "\\Visitor.txt").Dispose(); Directory.CreateDirectory(loc + "\\Pictures").Create(); File.Create(loc + "\\Subs.txt").Dispose(); }
            }
            catch
            {
                MessageBox.Show("Unable to connect to server.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            try
            {
                pBLogo.Image = Image.FromFile(File.ReadAllText(@"C:\FrontDeskData\ServerLoc.txt") + "Logos\\" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2] + ".jpg");
            }
            catch
            {
                pBLogo.Image = Wells_FrontDesk_Check_In.Properties.Resources.abss;
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PictureOff();
        }

        private void PictureOff()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.Stop();
                videoSource.SignalToStop();
                videoSource = null;
            }
        }
        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("This program was created by Matthew E. Wells" + "\r\n" + "All Rights Reserved." + "V1.5", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {

            pictureBoxVideo.Visible = true;
            if (camera == false) { pictureBoxVideo.Image = Wells_FrontDesk_Check_In.Properties.Resources.img_not_found; } else { videoSource.Start(); }
            btnHelp.Visible = true;
            chkPrint.Visible = true;
        }
        private void btnHelp_Click(object sender, EventArgs e)
        {
            chkPrint.Visible = false;
            pictureBoxVideo.Visible = false;
            pictureBoxVideo.Image = null;
            btnHelp.Visible = false;
            videoSource.SignalToStop();
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        private void btnTime_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://timekeeper.abss.k12.nc.us/Default.aspx");
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            videoSource.Start();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cntr++;
            if (cntr == 1000)
            {
                videoSource.SignalToStop();
                timer1.Stop();
            }
        }

        private void chkPrint_CheckedChanged(object sender, EventArgs e)
        {
            File.WriteAllText(checkPrint, chkPrint.Checked.ToString());
        }

        private void chkSpanish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpanish.Checked)
            {
                grpInOut.Text = "Dentro/Fuera";
                grpStuVis.Text = "Estudiante/Visitante";
                radStu.Text = "Estudiante";
                radVis.Text = "Visitante";
                radIn.Text = "Registrarse";
                radOut.Text = "Revisa";
                btnGo.Text = "Guardar";
                label2.Text = "Nombre de Estudiante/Visitante";
                label1.Text = "El Motivo";
            }
            else
            {
                grpInOut.Text = "In/Out";
                grpStuVis.Text = "Student/Visitor";
                radStu.Text = "Student";
                radVis.Text = "Visitor";
                radIn.Text = "Check In";
                radOut.Text = "Check Out";
                btnGo.Text = "Save";
                label2.Text = "Name of Student/Visitor";
                label1.Text = "Reason";
            }
        }

    }
}
