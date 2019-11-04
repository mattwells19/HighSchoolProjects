using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Who_Came_In_Who_Went_Out
{
    public partial class Form2 : Form
    {
        Form1 form = new Form1();
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            string all = File.ReadAllText(form.loc + "\\TeachersList.txt");
            txtInput.Text = all;
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSQ_Click(object sender, EventArgs e)
        {
        
        File.WriteAllText(form.loc + "\\TeachersList.txt", "");
        File.WriteAllText(form.loc + "\\TeachersList.txt", txtInput.Text.Trim());
        this.Close();
        }
    }
}
