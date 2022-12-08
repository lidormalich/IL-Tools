using System;
using System.IO;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace IL_Tools
{
    public partial class removeDemo : Form
    {
        public removeDemo()
        {
            InitializeComponent();
        }

        public void RunFile(string fileName)
        {
            Process proc = null;
            try
            {
                String targetDir = string.Format(@"C:\IL Tools\File");   //this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.Arguments = string.Format("10");  //this is argument
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                //proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  //this is for hiding the cmd window...so execution will happen in back ground.

                proc.Start();
                proc.WaitForExit();
            }
            catch (Exception ex)
            {
                updateLog("" + ex);
            }
        }

        public void updateLog(String newLog)
        {
            logTXT.AppendText(Environment.NewLine);
            logTXT.AppendText(newLog);
        }

        private void HuaweiDemoRemove_Click(object sender, EventArgs e)
        {
            //Remove Huawei Demo Mode
            RunFile("demo.bat");
        }

        private void Samsung_Click(object sender, EventArgs e)
        {
            //add fix file
            //RunFile("demo.bat");
        }
    }
}
