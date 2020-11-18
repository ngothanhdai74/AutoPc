using KAutoHelper;
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
                Process.Start("https://facebook.com");
                //Process.Start("devenv.exe");
                //Process.Start("notepad.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đéo có app này");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = AppDomain.CurrentDomain.BaseDirectory;
            Process.Start(@"D:\secret_at_git\Beethoven - Für Elise (60 Minutes Version).mp3");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string command = "/C ping -t howkteam.com";
            var data =  Process.Start("CMD.exe", command);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process p = new Process();

            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.RedirectStandardInput = true;
            p.Start();


            p.StandardInput.WriteLine("git --version");
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();

            MessageBox.Show(p.StandardOutput.ReadToEnd());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = (int)trucX.Value;
            int y = (int)trucY.Value;

            AutoControl.MouseClick(x, y, EMouseKey.LEFT);

        }
    }
}
