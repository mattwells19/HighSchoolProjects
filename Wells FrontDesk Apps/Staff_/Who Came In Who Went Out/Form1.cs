using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace Who_Came_In_Who_Went_Out
{
    public partial class Form1 : Form
    {
        string Studs;
        string Viss;
        string sub;
        string dayselected;
        string[] studes, part, vises, subs;
        int i;
        public string loc;
        string ServerLoc = @"C:\FrontDeskData";
        bool connected = false, connected2 = false;

        public Form1()
        {
            InitializeComponent();

            try
            {
                Directory.CreateDirectory(ServerLoc);
                Directory.Delete(ServerLoc);
            }
            catch
            {
                string temp = Interaction.InputBox("You do not have access to your C:\\ drive. Please speicify a drive you do have access to (For ex: W:\\)", "Access Denied"); //FIXME hidden files maybe?
                if (temp.Trim() == "")
                {
                    MessageBox.Show("Unable to find Server.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    ServerLoc = temp + "FrontDeskData\\";
                    connected = true;
                }
            }


            if (!File.Exists(ServerLoc + "\\ServerLoc.txt")) // In case data server goes down we create a txt file the stores the path of the data server
            {
                Directory.CreateDirectory(@ServerLoc);
                File.Create(ServerLoc + "\\ServerLoc.txt").Dispose(); // Create txt file if it does not exist

                // Get the location of the data server. This will only happen one time unless the program cannot connect to the data server
                string temp = Interaction.InputBox("Please paste the file location.\r\nEx: \\\\CTEC_SERVER\\Data\\\r\nPlease include the last backslash as well.", "New Server Location");
                if (temp.Trim() == "")
                {
                    MessageBox.Show("Unable to find Server.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    File.WriteAllText(ServerLoc + "\\ServerLoc.txt", temp);
                    connected2 = true;
                }
                
            }
            // loc is the folder location where all data is stored for a school. Folders are accessed based on the first three letters of the computer name. For ex: CTC computers can only access CTEC information
            loc = File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2];
            
            // Data grid properties being set
            dG.MultiSelect = false;
            dGVis.MultiSelect = false;

            // Setting location of logo image
            pBLogo.Location = new Point((dG.Location.X / 2) - pBLogo.Width / 2, (dG.Location.Y) + (pBLogo.Location.Y/4));
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            pB.Image = null;
            dG.Rows.Clear();
            dGVis.Rows.Clear();
            dGSubs.Rows.Clear();
            dayselected = e.Start.ToShortDateString().ToString();
            try             // If the program cannot access the file for Students we must stop the program and reconnect to the server
            {
                studes = File.ReadAllLines(Studs);
            }
            catch
            {
                MessageBox.Show("Server temporarily unavailable.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // This for loop populates the student data grid based on the day selected
            int t = 0;
            for (i = 0; i < studes.Length; i++)
            {
                part = studes[i].Split(',');
                if (part[1] == dayselected)
                {
                    dG.Rows.Add();
                    dG.Rows[t].Cells[0].Value = part[0]; dG.Rows[t].Cells[1].Value = part[2]; dG.Rows[t].Cells[2].Value = part[3]; dG.Rows[t].Cells[3].Value = part[4]; dG.Rows[t].Cells[4].Value = part[5];
                    t++;
                }

            }
            
            // This loop populates the visitor data grid
            t=0;
            vises = File.ReadAllLines(Viss);
            for (i = 0; i < vises.Length; i++)
            {
                part = vises[i].Split(',');
                if (part[1] == dayselected)
                {
                    dGVis.Rows.Add();
                    dGVis.Rows[t].Cells[0].Value = part[0]; dGVis.Rows[t].Cells[1].Value = part[2]; dGVis.Rows[t].Cells[2].Value = part[3];
                    t++;
                }
            }

            // This loop populates the substitute data grid
            t = 0;
            subs = File.ReadAllLines(sub);
            for (i = 0; i < subs.Length; i++)
            {
                part = subs[i].Split(',');
                if (part[3] == dayselected)
                {
                    dGSubs.Rows.Add();
                    dGSubs.Rows[t].Cells[0].Value = part[0]; dGSubs.Rows[t].Cells[1].Value = part[1]; dGSubs.Rows[t].Cells[2].Value = part[2];
                    t++;
                }
            }
    
           
        }


        private void Picture(DataGridView data) // This method displays the picture that was taken when the Student/Visitor/Sub signed in
        {
            i = 0;
            string[] all; string line;
            try
            {
                all = File.ReadAllLines(Studs);
            }
            catch
            {
                MessageBox.Show("Server temporarily unavailable.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try { line = data.Rows[data.CurrentCell.RowIndex].Cells[0].Value.ToString() + "," + data.Rows[data.CurrentCell.RowIndex].Cells[2].Value.ToString(); }
            catch { return; }
            if (line != "Students: " && line != "Visitors: ")
            {
                string[] piece = line.Split(',');
                try 
                { 
                    while (piece[0] + piece[1] != (all[i].Split(','))[0] + all[i].Split(',')[3].Replace("_",":")) { i++; } 
                }
                catch 
                {
                    try
                    {
                        all = File.ReadAllLines(Viss); i = 0; while (piece[0] + piece[1] != (all[i].Split(','))[0] + all[i].Split(',')[3].Replace("_", ":")) { i++; } 
                    }
                    catch
                    {
                        piece[1] = dGSubs.CurrentRow.Cells[2].Value.ToString();
                        all = File.ReadAllLines(sub); i = 0; while (piece[0] + piece[1] != (all[i].Split(','))[0] + all[i].Split(',')[2].Replace("_", ":")) { i++; } 
                    }
                }
                string link = (all[i].Split(','))[(all[i].Split(',')).Length - 1];
                pB.Image = Image.FromFile(link);
               
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!connected || !connected2) this.Close();
            else
            {
                // In case this is the first time running this program we must make sure the correct directories have been made. If not, we must create them 
                try
                {
                    if (!File.Exists(loc + "\\Student.txt"))
                    {
                        Directory.CreateDirectory(loc).Create(); File.Create(loc + "\\Student.txt").Dispose(); File.Create(loc + "\\Visitor.txt").Dispose(); Directory.CreateDirectory(loc + "\\Pictures").Create(); File.Create(loc + "\\Subs.txt").Dispose();
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to connect to server.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try // if user has set an image for the program to use, it will be grabbed here. If no image is found, it will use the default ABSS logo that is tied to the program
                {
                    pBLogo.Image = Image.FromFile(File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + "Logos\"" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2] + ".jpg");
                }
                catch
                {
                    pBLogo.Image = Who_Came_In_Who_Went_Out.Properties.Resources.abss;
                }

                // loc will be the same for all, but we need to distinguish which folder in loc we are talking about. 
                Studs = loc + "\\Student.txt";
                Viss = loc + "\\Visitor.txt";
                sub = loc + "\\Subs.txt";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dG_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            pB.Image = null;
            Picture(dG); // Clears then populates picture of selected Student
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Matthew E. Wells." + "\r\n" + "To report a bug, or request a feature, go to Help -> Feedback, and then fill out the form accordingly." + "\r\n" + "All Rights Reserved." + "\r\n" + "V1.5", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Select a date you would like to see the activity for. You can then do the following: " + "\r\n" + "Select a certain student/visitor to view the picture of." + "\r\n" + "Print the days records using File -> Print." + "\r\n" + "\r\n" + "You can also change the logo that appears on your and the Check In screen. Go to Edit -> Change Logo, and then select the picture file you wish to use." + "\r\n" + "\r\n" + "Please, also, feel free to provide feedback. You can suggest features, or report a bug. Just go to File -> Feedback.", "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dGVis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pB.Image = null;
            Picture(dGVis); // Clears then populates picture of selected Visitor
        }

        private void dGSubs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pB.Image = null;
            Picture(dGSubs); // Clears then populates picture of selected Substitute
        }

        private void changeLogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allows user to change logo image that is displayed on the main page on this program and the check in program

            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            pBLogo.Image = Image.FromFile(open.FileName);
            if (!File.Exists(File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + "Logos\\" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2] + ".jpg")){
                Directory.CreateDirectory(File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + "Logos\\");
            }
            File.Delete(File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + "Logos\\" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2] + ".jpg");
            pBLogo.Image.Save(File.ReadAllText(ServerLoc + "\\ServerLoc.txt") + "Logos\\" + Environment.MachineName[0] + Environment.MachineName[1] + Environment.MachineName[2] + ".jpg");
        }

        private void feedbackToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Feedback idea, staff knows to email me if there are any concerns

            Process.Start("http://goo.gl/forms/K4vY2mexSM");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) // Experimental feature (in progress) Potential to search a specific person of interest
        {
           /* if (txtSearch.Text == "")
            {
                dG.Rows.Clear();
                dGVis.Rows.Clear();
                dGSubs.Rows.Clear();
            }
            else
            {
                foreach (DataGridViewRow n in dG.Rows)
                {
                    if (n.Cells[0].Value == null)
                    {
                        dG.Rows.Remove(n);
                    }
                }
                foreach (DataGridViewRow n in dGVis.Rows)
                {
                    if (n.Cells[0].Value == null)
                    {
                        dGVis.Rows.Remove(n);
                    }
                }
                foreach (DataGridViewRow n in dGSubs.Rows)
                {
                    if (n.Cells[0].Value == null)
                    {
                        dGSubs.Rows.Remove(n);
                    }
                }


                string[] s = File.ReadAllLines(Studs);
                int t = 0;
                for (i = 0; i < s.Length; i++)
                {
                    part = s[i].Split(',');
                    if (part[0].Contains(txtSearch.Text))
                    {
                        dG.Rows.Add();
                        dG.Rows[t].Cells[0].Value = part[0]; dG.Rows[t].Cells[1].Value = part[2]; dG.Rows[t].Cells[2].Value = part[3]; dG.Rows[t].Cells[3].Value = part[4]; dG.Rows[t].Cells[4].Value = part[5];
                        t++;
                    }
                }
                string[] v = File.ReadAllLines(Viss);
                t = 0;
                for (i = 0; i < v.Length; i++)
                {
                    part = v[i].Split(',');
                    if (part[0].Contains(txtSearch.Text))
                    {
                        dGVis.Rows.Add();
                        dGVis.Rows[t].Cells[0].Value = part[0]; dGVis.Rows[t].Cells[1].Value = part[2]; dGVis.Rows[t].Cells[2].Value = part[3];
                        t++;
                    }
                }
                string[] su = File.ReadAllLines(sub);
                t = 0;
                for (i = 0; i < su.Length; i++)
                {
                    part = su[i].Split(',');
                    if (part[0].Contains(txtSearch.Text))
                    {
                        //dGSubs.Rows.Add();
                        dGSubs.Rows[t].Cells[0].Value = part[0]; dGSubs.Rows[t].Cells[1].Value = part[1]; dGSubs.Rows[t].Cells[2].Value = part[2];
                        t++;
                    }
                }
            }*/
        }
        public string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Print.txt";
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Allows staff user to print the selected day's entries
            // Automatically prints off of default printer

            if (!File.Exists(file)) { File.Create(file).Close(); }
            File.AppendAllText(file, "Day: " + dayselected + "\r\n");
            AddToPrint(dG,5, "Students: ");
            AddToPrint(dGVis,3, "Visitors: ");
            AddToPrint(dGSubs,3, "Substitutes: ");
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c Start NotePAD /P" + file;
            process.StartInfo = startInfo;
            process.Start();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            while (watch.ElapsedMilliseconds < 2000) { }
            File.Delete(file);
        }

        private void AddToPrint(DataGridView data, int cnt, string group)
        {
            string[] all = new string[data.Rows.Count];
            i = 0;
            foreach (DataGridViewRow n in data.Rows)
            { 
                for (int c = 0; c < cnt; c++)
                {
                    all[i] += n.Cells[c].Value.ToString() + ", ";
                }
                i++;
            }
            File.AppendAllText(file, "\r\n" + group + "\r\n");
            File.AppendAllLines(file, all);
        }
    
        // The following three methods allow staff user to highlight specific rows

        private void dG_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dG.Rows[dG.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Yellow; 
        }

        private void dGVis_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dGVis.Rows[dGVis.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Yellow; 
        }
   
        private void dGSubs_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dGSubs.Rows[dGSubs.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Yellow; 
        }

        private void dG_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();
                menu.Items.Add("Change to Substitute");
                menu.Items.Add("Change to Visitor");
                menu.Items.Add("Change to Check In");
                menu.Items.Add("Change to Check Out");
                menu.Show(dG, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
                
            }
        }

        void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            studes = File.ReadAllLines(Studs);
            vises = File.ReadAllLines(Viss);
            subs = File.ReadAllLines(sub);
           

            if (e.ClickedItem.ToString() == "Change to Check Out")
            {
                if (dG.CurrentRow.Cells[1].Value.ToString() == "Checked In")
                {
                    for (i = 0; i < studes.Length; i++)
                    {
                        if (studes[i].Split(',')[0] == dG.CurrentRow.Cells[0].Value.ToString())
                        {
                            break;
                        }
                    }
                    studes[i].Split(',')[2].Replace("Checked In","Checked Out");
                    studes[i].Split(',')[5].Replace(" ","Changed by Adminstration");
                    File.WriteAllLines(Studs, studes);
                }
                else
                {
                    MessageBox.Show("Student already checked out.","Already Done",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                }
            }
        }
        
        private void buttAddTeach_Click(object sender, EventArgs e)
        {
            if (!File.Exists(loc + "\\TeachersList.txt"))
            {
                File.Create(loc + "\\TeachersList.txt").Close();
            }
            Form2 form = new Form2();
            form.Show();
        }

        private void changeDataServerLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loc = Microsoft.VisualBasic.Interaction.InputBox("Please paste the file location.\r\nEx: \\\\CTEC_SERVER\\Data","New Server Location");
            File.WriteAllText(ServerLoc + "\\ServerLoc.txt", loc);
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
    }
}
