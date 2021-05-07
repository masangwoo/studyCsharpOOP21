using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = textUserID.Text + "\n" + textPassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result} 입니다.");
        }

        private void BtnLogin_Resize(object sender, EventArgs e)
        {

        }

     
    }
}
