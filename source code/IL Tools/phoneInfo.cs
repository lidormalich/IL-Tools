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
    public partial class phoneInfo : Form
    {
        public phoneInfo()
        {
            InitializeComponent();
            string a;

            String filename = string.Format(@"C:\IL Tools\File\");
            filename = filename + "imeiFast.bat";
            a = File.ReadAllText(filename);

            imeiLBL.Text = (phoneInf(a));

            filename = string.Format(@"C:\IL Tools\File\");
            filename = filename + "imeiFast.bat";
            a = File.ReadAllText(filename);
            textBox1.AppendText("Start");
            label2.Text = (phoneInf("adb shell getprop ro.product.name"));
            label10.Text = (phoneInf("adb shell getprop ro.product.model"));
            textBox1.AppendText("Hi");



        }
        public String phoneInf(String cmd)
        {
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.CreateNoWindow = true;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardOutput = true;
                startInfo.FileName = "adb.exe";
                startInfo.Arguments = cmd;
                process.StartInfo = startInfo;
                process.Start();
                //Console.Text = Console.Text + process.StandardOutput.ReadToEnd();

                String output = (process.StandardOutput.ReadToEnd());
                process.WaitForExit();
                //Process p = new Process();
                //// Redirect the output stream of the child process.
                //p.StartInfo.UseShellExecute = false;
                //p.StartInfo.RedirectStandardOutput = true;
                //p.StartInfo.FileName = "adb.exe";
                //p.Arguments = cmd;
                //p.Start();
                // Do not wait for the child process to exit before
                // reading to the end of its redirected stream.
                // p.WaitForExit();
                // Read the output stream first and then wait.
                //string output = p.StandardOutput.ReadToEnd();
                //p.WaitForExit();
                if (output != null)
                {
                    textBox1.AppendText("Done");
                    return output;
                }

                else
                {
                    textBox1.AppendText("Null");
                    return "Have Problem";
                }
                }
            }
        }
    }
