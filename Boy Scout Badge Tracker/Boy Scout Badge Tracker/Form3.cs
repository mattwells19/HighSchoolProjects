using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Boy_Scout_Badge_Tracker
{
    public partial class lvl2 : Form
    {
        string systemname = Environment.UserName;
        string[] scouts;
        int i = 0;

        public lvl2()
        {
            InitializeComponent();
            chkBaBW.Enabled = false; chkDtGiA.Enabled = false; chkcamp.Enabled = false; chkSA.Enabled = false;
            btnsave.Enabled = false;
            if (File.Exists(Class1.lvl2))
            {
                scouts = File.ReadAllLines(Class1.lvl2);
                for (i = 0; i < scouts.Length; i++)
                {
                    if (scouts[i] == "No" || scouts[i] == "Yes" || scouts[i] == "")
                    {
                        scouts.Skip(i);
                    }
                    else
                    {
                        cmblvl2sc.Items.Add(scouts[i]);
                    }
                }
                cmblvl2sc.Sorted = true;
            }
           
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            chkBaBW.Checked = false; chkDtGiA.Checked = false; chkcamp.Checked = false; chkSA.Checked = false;
            chkBaBW.Enabled = true; chkDtGiA.Enabled = true; chkcamp.Enabled = true; chkSA.Enabled = true;


            string[] scouts = File.ReadAllLines(Class1.lvl2);
            i = 0;
           
                while (scouts[i] != cmblvl2sc.Text)
                {
                    i++;
                }
            
          
            if (scouts[i + 1] == "Yes")
            {
                chkBaBW.Checked = true;
            }
            if (scouts[i + 2] == "Yes")
            {
                chkDtGiA.Checked = true;
            }
            if (scouts[i + 3] == "Yes")
            {
                chkcamp.Checked = true;
            }
            if (scouts[i + 4] == "Yes")
            {
                chkSA.Checked = true;
            }
            
            
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string[] scouts = File.ReadAllLines(Class1.lvl2);
            i = 0;

            while (scouts[i] != cmblvl2sc.Text)
            {
                i++;
            }

            btnsave.Enabled = false;
            if (chkBaBW.Checked == true)
            {
                scouts[i + 1] = "Yes";
            }
            else
            {
                scouts[i + 1] = "No";
            }
            if (chkDtGiA.Checked == true)
            {
                scouts[i + 2] = "Yes";
            }
            else
            {
                scouts[i + 2] = "No";
            }
            if (chkcamp.Checked == true)
            {
                scouts[i + 3] = "Yes";
            }
            else
            {
                scouts[i + 3] = "No";
            }
            if (chkSA.Checked == true)
            {
                scouts[i + 4] = "Yes";
            }
            else
            {
                scouts[i + 4] = "No";
            }

            File.WriteAllText(Class1.lvl2, "");
            i = 0;
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(Class1.lvl2, scouts[i] + "\r\n");
            }
            if (chkBaBW.Checked == true && chkDtGiA.Checked == true && chkcamp.Checked == true && chkSA.Checked == true)
            {
                Class1.InitCheck(cmblvl2sc.Text);

                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Matt Wells." + "\r\n" + "On the date of: October, 2015." + "\r\n" + "V1.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level3 form = new level3();
            form.Show();
            this.Hide();
        }
    }
}
