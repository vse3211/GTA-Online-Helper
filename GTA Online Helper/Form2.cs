using System;
using System.Diagnostics;
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
            label1.Text = "^ Убить сейсию ^";
            ActiveForm.Text = "GOH [Создание сейсии]";
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

            for (int i = 0; i <= 100; i = i + 10)
            {
                System.Threading.Thread.Sleep(1000);
                progressBar1.Value = i;
                Application.DoEvents();
            }
            
            p.StartInfo.FileName = Application.StartupPath + @"\ps.exe";
            p.StartInfo.Arguments = "-r notepad";
            p.Start();

            button1.Visible = true;
            label1.Text = "Можно играть";
            ActiveForm.Text = "GOH [Создадим еще одну сейсию?]";
        }
    }
}
