using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Process.Start("firefox");
                Process.Start("WinSCP");
                //Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                Process.Start("firefox");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(@"D:\secret_at_git\Beethoven - Für Elise (60 Minutes Version).mp3");
        }
    }
}
