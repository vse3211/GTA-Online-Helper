using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Online_Helper
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 MyForm1 = new Form1();
            MyForm1.ShowDialog();
            Close();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label1.Text = "В процессе...";
            button1.Visible = false;

            Process p = new Process();
            p.StartInfo.FileName = Application.StartupPath + @"\ps.exe";
            p.StartInfo.Arguments = "-s GTA5";
            p.Start();

            progressBar1.Value = 0;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 10;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 20;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 30;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 40;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 50;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 60;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 70;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 80;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 90;
            System.Threading.Thread.Sleep(1500);
            progressBar1.Value = 100;

            p.StartInfo.FileName = Application.StartupPath + @"\ps.exe";
            p.StartInfo.Arguments = "-r GTA5";
            p.Start();

            button1.Visible = true;
            label1.Text = "Можно играть";
        }
    }
}
