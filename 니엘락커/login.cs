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
using AdsJumboWinForm;

namespace 니엘락커
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            this.TopMost = true;
            bannerAds1.ShowAd(468, 60, "w68j2zsswe3o");
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == Properties.Settings.Default.비밀번호)
            {
                //Process.Start("explorer.exe");
                WIN32Helper.ShowTaskbar();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("비밀번호가 틀립니다!","비밀번호 틀림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
