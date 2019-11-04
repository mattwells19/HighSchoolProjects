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
    public partial class level3 : Form
    {
        string systemname = Environment.UserName;
        CheckBox[] check = new CheckBox[18];
        string[] scouts;
        
        int i = 0;

        public level3()
        {
            InitializeComponent();

            CheckArray();
            btnsave.Enabled = false;
            for (int j = 0; j < 18; j++)
            {
                check[j].Enabled = false;
            }
            if (File.Exists(Class1.lvl3))
            {
                scouts = File.ReadAllLines(Class1.lvl3);
                for (i = 0; i < scouts.Length; i++)
                {
                    if (scouts[i] == "No" || scouts[i] == "Yes" || scouts[i] == "")
                    {
                        scouts.Skip(i);
                    }
                    else
                    {
                        comboBox1.Items.Add(scouts[i]);
                    }
                }
                comboBox1.Sorted = true;
            }
            else
            {
                File.WriteAllText(Class1.lvl3,"");
            }
        }

        private void CheckArray()
        {
            check[0] = chkAaC;
            check[1] = chkAiS;
            check[2] = chkAqua;
            check[3] = chkArtEx;
            check[4] = chkBmOH;
            check[5] = chkBuild;
            check[6] = chkCast;
            check[7] = chkEng;
            check[8] = chkER;
            check[9] = chkFix;
            check[10] = chkGD;
            check[11] = chkItWds;
            check[12] = chkItWld;
            check[13] = chkLBLF;
            check[14] = chkMae;
            check[15] = chkMM;
            check[16] = chkPF;
            check[17] = chkSport;
        }

        public void btnsave_Click(object sender, EventArgs e)
        {
            string[] scouts = File.ReadAllLines(Class1.lvl3);
            i = 0;

            while (scouts[i] != comboBox1.Text)
            {
                i++;
            }

            btnsave.Enabled = false;

            for (int j = 0; j < 18; j++)
            {
                if (check[j].Checked == true)
                {
                    scouts[i + (j + 1)] = "Yes";
                }
                else
                {
                    scouts[i + (j + 1)] = "No";
                }
            }
           
             File.WriteAllText(Class1.lvl3, "");
             i = 0;
             for (i = 0; i < scouts.Length; i++)
             {
                 File.AppendAllText(Class1.lvl3, scouts[i] + "\r\n");
             }
             i = 0;
            
             while (scouts[i] != comboBox1.Text)
             {
                 i++;
             }
            scouts = File.ReadAllLines(Class1.lvl3);
            int lvl3ctr = 0;
            for (int h = 0; h < 19; h++)
            {
                if (scouts[i] == "Yes")
                {
                    lvl3ctr++;
                }
                i++;
            }
           
             if (lvl3ctr == 18)
             {
                 Class1.lvl3done = true;
                 if (Class1.ran == false)
                 {
                     Class1.ran = true;
                     Class1.InitCheck(comboBox1.Text);
                     Class1.CheckAll(comboBox1.Text);
                     
                     
                 }
             }
            
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            btnsave.Enabled = true;
           
            for (int j = 0; j < 18; j++)
            {
                check[j].Checked = false;
            }
            for (int j = 0; j < 18; j++)
            {
                check[j].Enabled = true;
            }
            
            string[] scouts = File.ReadAllLines(Class1.lvl3);
            i = 0;

            while (scouts[i] != comboBox1.Text)
            {
                i++;
            }

            for (int h = 0; h < 18; h++)
            {
                if (scouts[i + 1] == "Yes")
                {
                    check[h].Checked = true;
                }
                else
                {
                    check[h].Checked = false;
                }
                i++;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            lvl2 form = new lvl2();
            form.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Matt Wells." + "\r\n" + "On the date of: October, 2015." + "\r\n" + "V1.0.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        
    }
}
