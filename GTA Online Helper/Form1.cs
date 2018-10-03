using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTA_Online_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processName = "Taskmgr";
            while (true)
            {
                var allProcesses = Process.GetProcesses().Where(p => p.ProcessName == processName);
                foreach (var proc in allProcesses)
                Thread.Sleep(5000);
            }
        }
    }
}