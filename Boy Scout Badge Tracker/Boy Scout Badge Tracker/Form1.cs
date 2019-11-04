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
    public partial class Form1 : Form
    {
        string systemname = Environment.UserName;
        string[] scouts;
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
            chkchef.Enabled = false; chkfirstresp.Enabled = false; chkgod.Enabled = false; chksfh.Enabled = false; chkwebwalk.Enabled = false;
            if (File.Exists(Class1.lvl1))
            {
                scouts = File.ReadAllLines(Class1.lvl1);
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
                File.WriteAllText(Class1.lvl1, "");
            }
            btnsave.Enabled = false;
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnsave.Enabled = true;
            chkchef.Enabled = true; chkfirstresp.Enabled = true; chkgod.Enabled = true; chksfh.Enabled = true; chkwebwalk.Enabled = true;
            chkchef.Checked = false; chkfirstresp.Checked = false; chkgod.Checked = false; chksfh.Checked = false; chkwebwalk.Checked = false;
            if (comboBox1.Text == "'Add Scout")
            {
               
                Class1.go = false;
                newsc form2 = new newsc();
                form2.Show();
                

                if (Class1.go == false)
                {
                    this.Hide();
                    return;
                }
                
            }


            string[] scouts = FindName();

                if (scouts[i + 2] == "Yes")
                {
                    chkgod.Checked = true;
                }
                if (scouts[i + 3] == "Yes")
                {
                    chkfirstresp.Checked = true;
                }
                if (scouts[i + 4] == "Yes")
                {
                    chksfh.Checked = true;
                }
                if (scouts[i + 5] == "Yes")
                {
                    chkwebwalk.Checked = true;
                }
                if (scouts[i + 1] == "Yes")
                {
                    chkchef.Checked = true;
                }
            
        }

        private string[] FindName()
        {
            string[] scouts = File.ReadAllLines(Class1.lvl1);
            i = 0;
            while (scouts[i] != comboBox1.Text)
            {
                i++;
            }
            return scouts;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            btnsave.Enabled = false;
            if (chkchef.Checked == true)
            {
                scouts[i + 1] = "Yes";
            }
            else
            {
                scouts[i + 1] = "No";
            }
            if (chkgod.Checked == true)
            {
                scouts[i + 2] = "Yes";
            }
            else
            {
                scouts[i + 2] = "No";
            }
            if (chkfirstresp.Checked == true)
            {
                scouts[i + 3] = "Yes";
            }
            else
            {
                scouts[i + 3] = "No";
            }
            if (chksfh.Checked == true)
            {
                scouts[i + 4] = "Yes";
            }
            else
            {
                scouts[i + 4] = "No";
            }
            if (chkwebwalk.Checked == true)
            {
                scouts[i + 5] = "Yes";
            }
            else
            {
                scouts[i + 5] = "No";
            }
            File.WriteAllText(Class1.lvl1, "");
            i = 0;
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(Class1.lvl1, scouts[i] + "\r\n");
            }
            if (chkchef.Checked == true && chkfirstresp.Checked == true && chkgod.Checked == true && chksfh.Checked == true && chkwebwalk.Checked == true)
            {

                Class1.InitCheck(comboBox1.Text);

            }
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was created by Matt Wells." + "\r\n" + "On the date of: October, 2015." + "\r\n" + "V1.0.0","About",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnAoL_Click(object sender, EventArgs e)
        {
            lvl2 form3 = new lvl2();
            form3.Show();
            this.Hide();
        }
        

        private void changeNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a scout to be edited.", "Edit Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string nw = Microsoft.VisualBasic.Interaction.InputBox("Enter new name.", "Name Change");
            EditName(nw, Class1.lvl1);
            EditName(nw, Class1.lvl2);
            EditName(nw, Class1.lvl3);
            
          
            MessageBox.Show("Name changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void EditName(string nw, string lvl)
        {
            scouts = File.ReadAllLines(lvl);
            i = 0;
            while (scouts[i] != comboBox1.Text)
            {
                i++;
            }
            File.WriteAllText(lvl, "");
            scouts[i] = nw;
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(lvl, scouts[i] + "\r\n");
            }
        }

        private void deleteScoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select a scout to be deleted.", "Delete Scout", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you wish to delete?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (result == DialogResult.Yes)
            {
                scouts = File.ReadAllLines(Class1.lvl1);
            i = 0; 
            while (scouts[i] != comboBox1.Text)
            {
                i++;
            }
            int j = 0;
            int c = 0;
            for (j = i ; c < 6; j++)
            {
                scouts[j] = "";
                c++;
            }

            File.WriteAllText(Class1.lvl1, "");
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(Class1.lvl1, scouts[i] + "\r\n");
            }
            File.WriteAllText(Class1.lvl2, "");
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(Class1.lvl2, scouts[i] + "\r\n");
            }
            File.WriteAllText(Class1.lvl3, "");
            for (i = 0; i < scouts.Length; i++)
            {
                File.AppendAllText(Class1.lvl3, scouts[i] + "\r\n");
            }

               MessageBox.Show("Name deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               Form1 form = new Form1();
               form.Show();
               this.Hide();
           }
        }

        private void deleteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
        DialogResult result = MessageBox.Show("Are you sure you would like to delete all data?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        if (result == DialogResult.Yes)
        {
            File.Delete(Class1.lvl2);
            File.Delete(Class1.lvl1);
            File.Delete(Class1.lvl3);
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            level3 form = new level3();
            form.Show();
            this.Hide();
        }

      
        
    }
}
