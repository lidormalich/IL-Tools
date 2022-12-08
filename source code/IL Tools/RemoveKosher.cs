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
    public partial class RemoveKosher : Form
    {
        //משתני גלובל
        string whatToRun = null;
        public string targetDir;
        helperData data = new helperData();

        public RemoveKosher()
        {
            InitializeComponent();
        }

        //מה להריץ- מקבל שם קובץ להרצה בתיקייה
        public void RunFile(string fileName)
        {
            Process proc = null;
            try
            {
                //targetDir = data.getToolsDataLoction();   //this is where mybatch.bat lies
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
                updateLog(""+ex);
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (whatToRun != null)
            { 
                RunFile(whatToRun);
                
                infoTXT2.Text = "המשימה החלה- אנא עקוב אחרי ההוראות";
                whatToRun =null;
            }
            else
                infoTXT2.Text = "לא נבחר משימה לביצוע";
        }
        
        private void updateInfo(string oprtion)
        {
            String temp = null;
            if (oprtion == "Askan")
                temp = "infoAskan.img";
            else
                if (oprtion == "Nativ")
                temp = "infoNativ.img";
            else
                if (oprtion == "Hadran")
                temp = "notSupport.img";
            else
                if (oprtion == "Shoham")
                temp = "infoShoham.img";

            loadFileTolbl(temp);
            //https://www.youtube.com/watch?v=rFhmTccRUpQ
            //tab
        }

        public void updateLog(String newLog)
        {
            logTXT.AppendText(Environment.NewLine);
            logTXT.AppendText(newLog);

        }
        public void loadFileTolbl(String company)
        {

            //String filename = data.getToolsDataLoction();
            //filename =  filename+company;
            //infoTXT2.Text = File.ReadAllText(filename);
        }
        private void RemoveAskan_Click(object sender, EventArgs e)
        {
            plzReadMore.Text = "     עובד על גלקסי 7 ומעלה";
            plzRead.Text = "הוראות      " + "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:";
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת עסקן");
            whatToRun = "RunMeAuto.exe";
            updateInfo("Askan");
            updateLog("הסרת עסקן הסתימה");

        }

        private void RemoveNativ_Click(object sender, EventArgs e)
        {
            plzRead.Text = "הוראות      " + "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:";
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת נתיב");
            whatToRun = "Nativ-Remove-RunMe.exe";
            updateInfo("Nativ");
            updateLog("הסרת נתיב הסתימה");
        }

        private void RemoveHadran_Click(object sender, EventArgs e)
        {
            plzRead.Text = "הוראות      " + "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:";
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת הדרן");
            updateLog(" ");
            updateLog("הדרן כרגע לא נתמך");
            updateLog(" ");
            whatToRun = "null";
            updateInfo("Hadran");
            updateLog("הסרת הדרן הסתימה");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plzRead.Text = "הוראות      " + "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:";
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת שוהם");
            whatToRun = "null";
            updateInfo("Shoham");
            updateLog("הסרת שוהם הסתימה");
        }
    }
}
