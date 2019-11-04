using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Boy_Scout_Badge_Tracker
{
    public partial class newsc : Form
    {
        
        public newsc()
        {
            InitializeComponent();
            this.AcceptButton = btngo;
        }

        private void txtscout_TextChanged(object sender, EventArgs e)
        {
            if (txtscout.Text != "")
            {
                btngo.Enabled = true;
            }
            else
            {
                btngo.Enabled = false;
            }
        }

        private void btncanc_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();

        }

        private void btngo_Click(object sender, EventArgs e)
        {
            bool yes = false;
            Class1.newscout = txtscout.Text.Trim();
            Regex regex = new Regex("^[A-Za-z ]+$");
            if (regex.IsMatch(Class1.newscout) == false)
            {
                yes = false;
            }
            else
            {
                yes = true;
            }
           
            if (Class1.newscout == "" || yes == false)
            {
                MessageBox.Show("Please enter a valid name.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtscout.Text = "";
                return;
            }
            
            int i = 0;
            string[] scouts;

            scouts = File.ReadAllLines(Class1.lvl1);
            for (i = 0; i < scouts.Length; i++)
            {
                string name = scouts[i];
                if (scouts[i] == Class1.newscout || scouts[i].ToLower() == Class1.newscout.ToLower())
                {
                    MessageBox.Show("Please enter a new name.","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            File.AppendAllText(Class1.lvl1, "\r\n" + Class1.newscout + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No");
            File.AppendAllText(Class1.lvl2, Class1.newscout + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n");
            File.AppendAllText(Class1.lvl3, Class1.newscout + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n" + "No" + "\r\n");
            MessageBox.Show("Congratulations! You can now track your collected badges!","WooWoo!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            DialogResult result = MessageBox.Show("Would you like to add another scout?", "Add Another?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                txtscout.Text = "";
                return;
            }
            Class1.go = true;
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }
       

        private void newsc_Load(object sender, EventArgs e)
        {

        }

    }

}
