using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IL_Tools
{
    public class AdbCmd
    {
        public static string serial;
        public static string devState;
        public static string imei;
        public static string languge;
        public AdbCmd()
        {
            if (AdbCmd.isProcessRunning())
                AdbCmd.killProcess();
            AdbCmd.AdbCommand("start-server");
            devState = "Offline";
        }

        public static void AdbCmdCall()
        {
            if (AdbCmd.isProcessRunning())
            {
                AdbCmd.killProcess();
            }
            AdbCmd.AdbCommand("start-server");
            devState = "Offline";
            UpdateDeviceFast();
        }

        
        private static void UpdateDeviceFast()
        {
            StringReader stringReader = new StringReader(AdbCmd.AdbCommand("devices"));
            {
                Process process = new Process();
                process.StartInfo.FileName = "adb.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.WorkingDirectory = Application.StartupPath;
                process.StartInfo.Arguments = "/c get-state";
                process.Start();

                string Left1 = stringReader.ReadLine();
                if (!process.StandardOutput.ReadToEnd().Contains("device"))
                {
                    devState = "Online";
                }
                process.WaitForExit();
            }
        }
        public static bool killProcess()
        {
            foreach (var process in Process.GetProcessesByName("adb"))
            {
                try
                {
                    process.Kill();
                }
                catch
                {
                    return false;
                }


            }
            return true;
        }

        private static bool isProcessRunning()
        {
            foreach (var process in Process.GetProcessesByName("adb"))
            {
                return true;
            }
            return false;
        }
        public static string AdbCommand(string cmd)
        {
           // if (AdbCmd.isProcessRunning())
                AdbCmd.killProcess();
            return AdbCmd.Adb(cmd);
        }
        public String getSerial()
        {
            return serial;
        }
        private static string Adb(string cmd)
        {

            Process process = new Process();
            ProcessStartInfo startInfo = process.StartInfo;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "adb.exe";
            startInfo.Arguments = cmd;
            startInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
        public static string adbState()
        {
            return (Adb("adb devices | findstr \'<' device\'>'"));
        }
        private static string fastboot(string cmd)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = process.StartInfo;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "fastboot.exe";
            startInfo.Arguments = cmd;
            startInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }

        private static string download(string cmd)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = process.StartInfo;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.FileName = "bin/dm.exe";
            startInfo.Arguments = cmd;
            startInfo.RedirectStandardOutput = true;
            process.Start();
            return process.StandardOutput.ReadToEnd();
        }
        public static void AdbShellCommandNoReturn(string serial, string cmd, bool rootShell = false)
        {
            string str = string.Format("-s {0} shell", (object)serial);
            if (rootShell)
                str += "su -c \"";
            string cmd1 = str + cmd;
            if (rootShell)
                cmd1 += "\"";
            AdbCmd.Adb(cmd1);
        }
        public static string adbReturnFull(String cmd)
        {
            string Left1;
            using (StringReader stringReader = new StringReader(AdbCommand(cmd)))
            {
                Left1 = stringReader.ReadLine();

            }
            return Left1;
        }
        public static string adbShellReturnFull(String cmd)
        {
            string Left1;
            using (StringReader stringReader = new StringReader(AdbCommand("shell" + cmd)))
            {
                Left1 = stringReader.ReadLine();

            }
            return Left1;
        }


        public static string findString(string strSource, string strStart = null, string strEnd = null)
        {
            int Start, End;
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            else
            {
                return "";
            }
        }
        public static void AdbShellCommandNoReturn(string cmd, bool rootShell = false)
        {
            string str = string.Format("shell ");
            if (rootShell)
                str += "su -c \"";
            string cmd1 = str + cmd;
            if (rootShell)
                cmd1 += "\"";
            AdbCmd.Adb(cmd1);
        }
        public static void AdbCommandNoReturn(string serial, string cmd)
        {
            AdbCmd.Adb(string.Format("-s {0} " + cmd, (object)serial));
        }

        public static string AdbShellCommand(string serial, string cmd, bool rootShell = false)
        {
            string str = string.Format("-s {0} shell ", (object)serial);
            if (rootShell)
                str += "su -c \"";
            string cmd1 = str + cmd;
            if (rootShell)
                cmd1 += "\"";
            return AdbCmd.Adb(cmd1);
        }

        public static string AdbShellCommand(string cmd, bool rootShell = false)
        {
            string cmd1;
            //messegBox ope2n = new messegBox(cmd);
            //ope2n.Show();
            string str = string.Format("shell ");
            if (rootShell)
                cmd1 = str + "su -c \"";
            else
                cmd1 = str + cmd;

            return AdbCmd.Adb(cmd1);
            //string str = string.Format("shell ");
            //if (rootShell)
            //    str += "su -c \"";
            //string cmd1 = str + cmd;
            //if (rootShell)
            //    cmd1 += "\"";
            //return AdbCmd.Adb(cmd1);
        }
        public static string AdbCommand(string serial, string cmd)
        {
            return AdbCmd.Adb(string.Format("-s {0} " + cmd, (object)serial));
        }
        public static void BypassFRP()
        {
            AdbCmd.AdbShellCommand("content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1", false);

        }

        public static string fcmd(string cmd)
        {
            return AdbCmd.fastboot(cmd);
        }

        public static string flash(string cmd)
        {
            return AdbCmd.download(cmd);
        }

        public static void setSerial(string sn)
        {
            serial = sn;
        }
        public static string adbPhoneList()
        {

            return AdbCmd.AdbCommand("devices");
        }

        public static void adbWaitForPhone()
        {

             AdbCmd.AdbCommand("wait-for-device");
        }
    }
}
