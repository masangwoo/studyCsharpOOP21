using NLog;
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
        public object TxtPassword { get; private set; }

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

            try
            {
                var val = TxtPassword.Text.Substring(3, 2);//문자열 자르는 메서드
                MessageBox.Show($"{val}");
                Logger.Info("제대로 완료!");
            }
            catch (Exception)
            {
                MessageBox.Show("예외발생, 관리자에게 문의 요망");
                Logger.Error("예외발생");
               
            }
        }

        private void BtnLogin_Resize(object sender, EventArgs e)
        {

        }

     
    }
}
