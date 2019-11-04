using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace Hitting
{
    public partial class Form1 : Form
    {

        double average;
        
       
       int row= 0, col =0, players = 0;
        //EXCEL FORMAT: Col 1: Hits, Col 2: At Bats, Col 3: Walks, Col 4: HBP, Col 5: Sacs, Col 6: singles, Col 7: doubles, Col 8: Triples, Col 9: Homers
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void battingAverageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Batting Average is the percentage of hits to outs for a player.", "Batting Average", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void onBasePercToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On Base Percentage is the percentage of time the player gets on base safely.", "On Base Percentage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void onBasePlusSlgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On Base plus Slugging is how many times a player gets on base safely plus the measure of power a player has.", "On Base Plus Slugging", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sluggingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Slugging Percentage is the measure of a players power when hitting.","Slugging Percentage", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form2.Show();

        }

        private void BA(double [] h, double[] ab)
        {
           
            for (int z = 0; z < ab.Length; z++)
            {
                average = (h[z] / ab[z]);

                dataGridView1.Rows[z].Cells[1].Value = average.ToString("0.###");
            }
            if (average < 0 || average > 1)
            {
                MessageBox.Show("Please check to make sure the inputs you have provided are accurate. Currently the BA is either less than 0 or greater than 1.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }
           
        }

        private void OPS(double[] tb, double[] ab, double[] h,double[] sing, double[] doub, double[]trip,double[] home,double[] bb,double[] hbp,double[]sf )
        {
            double[] slg = new double[players];
            double[] obp1 = new double[players];
            double[] obp2 = new double[players];
            double[] obpf = new double[players];
            //double[] obpf = new double[players];
            //SLUGGING CALCULATION
            {
               
                for (int j = 0; j < players; j++)
                {
                    tb[j] = sing[j] + doub[j] + trip[j] + home[j];
                    if (tb[j] > ab[j])
                    {
                        MessageBox.Show("You cannot have more total bases than at bats. Please fix.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    if (tb[j] != h[j])
                    {
                        MessageBox.Show("Total Bases must equal the number of hits. Please fix.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }
                    slg[j] = ((sing[j] + (doub[j] * 2) + (trip[j] * 3) + (home[j] * 4)) / ab[j]);
                    dataGridView1.Rows[j].Cells[3].Value = slg[j].ToString("0.###");
                }
            }
            //OBP CALCULATION
            {
               
                for (int j = 0; j < players; j++)
                {
                    obp1[j] = (h[j] + bb[j] + hbp[j]);
                    obp2[j] = (ab[j] + bb[j] + hbp[j] + sf[j]);
                    obpf[j] = obp1[j] / obp2[j];
                    dataGridView1.Rows[j].Cells[2].Value = obpf[j].ToString("0.###");

                    if (obpf[j] < 0 || obpf[j] > 1)
                    {
                        MessageBox.Show("Please check to make sure the inputs you have provided are accurate. Currently the OBP is either less than 0 or greater than 1.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }

                }
            }
            double[] ops = new double[players];
            for (int j = 0; j < players; j++)
            {

                if (tb[j] > ab[j])
                {
                    return;
                }
                if (tb[j] != h[j])
                {
                    return;
                }
                ops[j] = obpf[j] + slg[j];
                dataGridView1.Rows[j].Cells[4].Value = ops[j].ToString("0.###");
            }
          
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            textBox1.Text = "";
            dataGridView1.Rows.Clear();
            players = 0;

                button3.Enabled = true;
            
            OpenFileDialog opendia = new OpenFileDialog();
            if (opendia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Text = opendia.FileName;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                
                BinaryReader reader = new BinaryReader(File.OpenRead(textBox1.Text));
                char lastChar = reader.ReadChar();
                char newChar = new char();

                do
                {
                    newChar = reader.ReadChar();
                    if (lastChar == '\r' && newChar == '\n')
                    {
                        players++;
                    }
                    lastChar = newChar;
                } while (reader.PeekChar() != -1);
                
            for (int d = 0; d < players; d++)
            {
                dataGridView1.Rows.Add();
            }
            dataGridView1.Visible = true;
           

            this.Width = 1026;
            this.Height = 558;
            HitsAb();
        
            }
            catch
            {
                MessageBox.Show("Please make sure you selected the right file, the file is saved correctly as CSV (MC DOS), and that the file matches the format as indicated by HELP.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            
            }


        }

        private void HitsAb()
        {
                int[,] calc = new int[players, 8];
                double[] h = new double[players];
                double[] abb = new double[players];
                double[] w = new double[players];
                double[] hp = new double[players];
                double[] s = new double[players];
                double[] si = new double[players];
                double[] dol = new double[players];
                double[] tr = new double[players];
                double[] hr = new double[players];
                double[] tb = new double[players];


                string[] names = new string[players];

                int x = 0, q = 0;
                foreach (string line in File.ReadLines(textBox1.Text))
                {

                    string[] cha = line.Split(',');
                    for (q = 0; q < cha.Length; q++)
                    {
                        if (q > 0)
                        {
                            calc[row, col] = Convert.ToInt32(cha[q]);
                        }

                        if (q == 0)
                        {
                            names[x] = (cha[0]);
                            for (int d = 0; d < players; d++)
                            {
                               
                                dataGridView1.Rows[d].Cells[0].Value = names[d];
                            }
                            
                        }
                        else if (q == 1)
                        {
                            h[x] = calc[row, col];
                          
                        }
                        else if (q == 2)
                        {
                            abb[x] = calc[row, col];
                        }
                        else if (q == 3)
                        {
                            w[x] = calc[row, col];
                        }
                        else if (q == 4)
                        {
                            hp[x] = calc[row, col];
                        }
                        else if (q == 5)
                        {
                            s[x] = calc[row, col];
                        }
                        else if (q == 6)
                        {
                            si[x] = calc[row, col];
                        }
                        else if (q == 7)
                        {
                            dol[x] = calc[row, col];
                        }
                        else if (q == 8)
                        {
                            tr[x] = calc[row, col];
                        }
                        else if (q == 9)
                        {
                            hr[x] = calc[row, col];
                        }

                    }

                    row++;

                    x++;
                    if (row == players)
                    {
                        row = 0;
                        x = 0;
                        col++;
                    }
                    BA(h, abb);
                    OPS(tb, abb, h, si, dol, tr, hr, w, hp, s);


                }

            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (form3.IsDisposed)
            {
                form3 = new Form3();
                form3.Show();
            }
            else
            {
                form3.Show();
            }
        }
    }
}
