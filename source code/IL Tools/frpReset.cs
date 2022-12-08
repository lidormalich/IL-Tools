using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace IL_Tools
{
    public partial class frpReset : Form
    {
        public frpReset()
        {
            InitializeComponent();
        }

        private void chackModel_Click(object sender, EventArgs e)
        {
            modelFRPDwonlodsMode open = new modelFRPDwonlodsMode();
            open.Show();
        }

        private void frpResetADB_Click(object sender, EventArgs e)
        {
            AdbCmd.BypassFRP();
        }

        private void Qualcomm_Click(object sender, EventArgs e)
        {
            
                //flashsystemTextbox.Text = openfile.FileName;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " flash userdata \"C:\"IL Tools\"File\"Qualcomm\"userdata.img";
                process.StartInfo = startInfo;
                process.Start();
            }

        private void Exynos_Click(object sender, EventArgs e)
        {
            {

                //flashsystemTextbox.Text = openfile.FileName;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "fastboot.exe";
                startInfo.Arguments = " flash system \"C:\"IL Tools\"File\"Qualcomm\"userdata.img";
                process.StartInfo = startInfo;
                process.Start();
            }
        }
    }
}
