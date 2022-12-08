using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IL_Tools
{
    class Samsung
    {
        private static string odin(string cmd)
        {

            Process process = new Process();
            ProcessStartInfo startInfo = process.StartInfo;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "odin.exe";
            startInfo.Arguments = cmd;
            startInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
        public static string sendOdinCMD(string cmd)
        {
            return odin(cmd);
        }
        public static bool phoneIsOnlineInDL()
        {
            Process process = new Process();
            process.StartInfo.FileName = "odin.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.StartInfo.Arguments = " detect";
            process.Start();
            if (process.StandardOutput.ReadToEnd().Equals("WaitingFailed to detect compatible download-mode device."))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string reapirBB()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = "bin\\";
            process.StartInfo.Arguments = "/c dm flash --EFS exDownload.dll";
            process.Start();
            process.BeginErrorReadLine();
            process.BeginOutputReadLine();
            return process.StandardOutput.ReadToEnd();
        }

     }
}
