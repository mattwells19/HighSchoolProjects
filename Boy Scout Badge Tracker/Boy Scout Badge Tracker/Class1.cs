using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Diagnostics;


namespace Boy_Scout_Badge_Tracker
{
    
    class Class1
    {
        public static string newscout = "";
        public static bool go = false;
        public static bool ran;
        public static string lvl2 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "level2.txt";
        public static string lvl1 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "level1.txt";
        public static string lvl3 = AppDomain.CurrentDomain.BaseDirectory + @"\" + "level3.txt";
        public static bool lvl1done = false;
        public static bool lvl2done = false;
        public static bool lvl3done = false;

        public static void CheckAll(string name)
        {
            if (lvl2done == true && lvl1done == true && lvl3done == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(AppDomain.CurrentDomain.BaseDirectory + @"\" + "cheer.wav");
                player.Play();
                MessageBox.Show("Congratulations! You have completed all of the Webelo's badges!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                string spaces = "";
                for (int e = 0; e < (120 - (name.Length + 10))/2; e++) 
                {
                    spaces += " ";
                }
                File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\" + "certificate.txt", "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + "\r\n" + spaces + name);
                
                System.Diagnostics.Process.Start("notepad.exe", "certificate.txt");
                
            }

        }
        public static bool CheckChecks(string[] lvl, string box, int times)
        {
            int i = 0, ctr = 0;
            while (lvl[i] != box)
            {
                i++;
            }
            for (int q = 0; q < times; q++)
            {
                if (lvl[i] == "Yes")
                {
                    ctr++;
                }
                i++;
            }
            if (ctr == times - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void InitCheck(string box)
        {
            string[] lvl1 = File.ReadAllLines(Class1.lvl1);
            Class1.lvl1done = Class1.CheckChecks(lvl1, box, 6);
            string[] lvl2 = File.ReadAllLines(Class1.lvl2);
            Class1.lvl2done = Class1.CheckChecks(lvl2, box, 5);

            level3 form = new level3();

            form.comboBox1.Text = box;
            form.btnsave_Click(form, null);

            ran = false;
            
        }

    }
}
