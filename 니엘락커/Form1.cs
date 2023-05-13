using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;
using AdsJumboWinForm;

namespace 니엘락커
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Width = Screen.PrimaryScreen.Bounds.Width;
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.TopMost = true;
            WIN32Helper.HideTaskbar();
            bannerAds1.ShowAd(728, 90, "w68j2zsswe3o");
            


            //foreach (Process process in Process.GetProcesses())
            //{
            //    if (process.ProcessName.StartsWith("explorer"))
            //    {
            //        process.Kill();
            //    }

            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            
            login frm = new login();
            frm.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
            if(e.Alt && e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setting frm= new setting();
            frm.ShowDialog();
        }
    }
}
