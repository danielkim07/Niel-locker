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
using System.Runtime.Remoting.Contexts;

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

            /*TopMost = false;
            string t메시지 = "설정에 접근하려면 기존 비밀번호나 복구키를 입력해야합니다."; string t타이틀 = "니엘락커";
            string t입력값 = Microsoft.VisualBasic.Interaction.InputBox(t메시지, t타이틀, "기존 비밀번호나 복구키를 입력하세요.");
            TopMost = true;
            if (t입력값 == Properties.Settings.Default.비밀번호)
            {
                setting frm = new setting();
                frm.ShowDialog();
            }else
            {
                MessageBox.Show(new Form { TopMost = true }, "기존 비밀번호 또는 복구키와 다릅니다","니엘락커",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

            setting frm = new setting();
            frm.ShowDialog();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.locking == "is")
            {
                e.Cancel= true;
                return;
            }
            else if (Properties.Settings.Default.locking == "un")
            {
                this.TopMost = false;
                MessageBox.Show("잠금해제되었습니다", "니엘락커", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
