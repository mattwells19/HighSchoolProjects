using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hitting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                label1.Text = "3. Save your workbook as a CSV (MS-DOS)";
                button2.Visible = true;
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "**There will be a popup like the one below. Select NO and then exit out.";
            button3.Visible = true;
            button2.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "4. Go back to the main program and click the 'Please select your .CSV File here!' button and select the .CSV file." + "\n\r" + "5. Click the 'Go when ready!' button.";
            pictureBox3.Visible = false;
            pictureBox4.Visible = true;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            

        }
    }
}
