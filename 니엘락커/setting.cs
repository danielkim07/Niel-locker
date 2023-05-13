using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 니엘락커
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            this.TopMost = true;
            bannerAds1.ShowAd(468, 60, "w68j2zsswe3o");
            textBox1.Text = Properties.Settings.Default.비밀번호;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.비밀번호 = textBox1.Text;
            Properties.Settings.Default.Save();
        }
    }
}
