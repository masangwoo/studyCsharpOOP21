using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformThreadApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void button1_CLick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;


            //스레드로 분리->윈폼의 gui화면 스레드, 처리스레드 분리
            Thread th = new Thread(() =>
            {
                for (int i = 0; i <= 1000; i++)
                {

                    progressBar1.BeginInvoke(
                    new Action(() =>
                    {
                        progressBar1.Value = i;
                    }));
                }
            });


                th.IsBackground = true;
            
            th.Start();
        }

    }
}
