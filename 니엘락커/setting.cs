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
            textBox2.Text = "이전 비밀번호나 복구코드를 입력하세요";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == Properties.Settings.Default.비밀번호)
            {
                Properties.Settings.Default.비밀번호 = textBox1.Text;
                Properties.Settings.Default.Save();
                Close();
            }
            else
            {
                MessageBox.Show("이전 비밀번호가 맞지 않습니다","니엘락커",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
