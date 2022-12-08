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
using System.IO.Ports;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.Management;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Collections;

namespace IL_Tools
{
    public partial class Home : Form
    {
        //setting
        string whatToRun = null;
        public Process proc = null;
        helperData data = new helperData();
        public string[] ports;
        public string listAdbOnline;



        //ADB
        private delegate void updatedelegatee(string LogText);
        String toolsLoc = helperData.getToolsDataLoction();

        //Com Port String
        String cPortDone = "cPortDone OK";
        String cPortError = "cPort Error";


        public Home()
        {
            InitializeComponent();
            //מידע כניסה
            loadInfoAboutMe();
            cBoxComPort.DropDownStyle = ComboBoxStyle.DropDownList;
            devicescomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            infoTXT.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            log("IL Tools - נבנה על יד לידור מליח", Color.Green);
            newLine();
            log("הכלי שברשותך ברישיון", Color.Blue);
            infoTXT.SelectionColor = Color.DarkCyan;
            infoTXT.AppendText(helperData.getsnNumber());
            infoTXT.AppendText(Environment.NewLine);
            adbPhonePicConnect(true);

        }



        private void RemoveKosher_Click(object sender, EventArgs e)
        {
            RemoveKosher ope2n = new RemoveKosher();
            ope2n.Show();
        }

        private void unlockSim_Click(object sender, EventArgs e)
        {
            unlock ope2n = new unlock();
            ope2n.Show();
        }

        private void reapirBlockByFRP_Click(object sender, EventArgs e)
        {
            reapirBlockByFRP ope2n = new reapirBlockByFRP();
            ope2n.Show();
        }

        private void AddADBKosher_Click(object sender, EventArgs e)
        {
            Boolean isSelecte = false;

            setProgressBar(0);
            logOneLine("מבצע הכשרה...");
            if (checkBox1.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.android.chrome");
                setProgressBar(5);
                isSelecte = true;
            }
            if (checkBox2.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.app.sbrowser");
                setProgressBar(10);
                isSelecte = true;
            }

            if (checkBox3.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm hide com.android.vending");
                setProgressBar(15);
                isSelecte = true;
            }
            if (checkBox4.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.gms");
                if (checkBox3.Checked)
                {
                    AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.android.vending");
                }
                setProgressBar(20);
                isSelecte = true;
            }

            if (checkBox5.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.googlequicksearchbox");
                setProgressBar(25);
                isSelecte = true;
            }
            if (checkBox6.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.youtube");
                setProgressBar(30);
                isSelecte = true;
            }
            if (checkBox7.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.orca");
                setProgressBar(35);
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.lite");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.katana");
                setProgressBar(45);
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.pages.app");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.mlite");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.creatorapp");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.katana");
                isSelecte = true;
            }
            if (checkBox8.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.linkedin.android");
                setProgressBar(55);
                isSelecte = true;
            }
            if (checkBox9.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.app.samsungapps");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.widgetapp.samsungapps");
                setProgressBar(60);
                isSelecte = true;
            }
            if (checkBox10.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.wssyncmldm");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.soagent");
                setProgressBar(65);
                isSelecte = true;
            }
            if (checkBox11.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.skype.raider");
                setProgressBar(70);
                isSelecte = true;
            }
            if (isSelecte)
            {
                logOneLine("בוצע", Color.Green); newLine();
            }
            else
            {
                logOneLine("נכשל", Color.Red); newLine();
                log("לא נבחר ישום להסרה/ישום לא מותקן על המכשיר - אנא נסה שנית....", Color.Red);
            }
            setProgressBar(100);
            AdbCmd.AdbCommand("reboot");
            AdbCmd.killProcess();
        }

        private void loadInfoAboutMe()
        {
            AboutTextLBL.AppendText("הכלי נוצר על ידי");
            AboutTextLBL.AppendText(" לידור מליח");
            AboutTextLBL.AppendText(Environment.NewLine);
            AboutTextLBL.AppendText("התוכנה ברישיון של - " + helperData.getUserName());
            AboutTextLBL.AppendText(Environment.NewLine);

        }

        private void RemoveUSApp_Click(object sender, EventArgs e)
        {
            log("שים לב!");

            log("אם קיים יישום של המפעילה שהותקן על ידי המשתמש- הוא ימחק גם");
            log("לכן כדאי לגבות לפני זה - את ישומי המפעילה הנחוצים");
            newLine();
            log("בהצלחה");

            log("תומך T-Mobile/Sprint/At&t/Verizon/Amazon");
            log("התהליך החל.....");


            setProgressBar(0);
            helperRun.runAmricanAppRemove();
            setProgressBar(100);


            log("התהליך הסתיים.....");

        }

        private void removeDemo_Click(object sender, EventArgs e)
        {
            //Code 1: 1122334455
            //Code 2: 00CDIAGE
            logOneLine("קוד ראשון להסרת הדמו", Color.Blue);
            log("1122334455", Color.Blue);
            logOneLine("קוד שני להסרת הדמו", Color.Blue);
            log("00CDIAGE", Color.Blue);
            log("חשוב אותיות גדולות כמו שרשום", Color.Blue);
            
            AdbCmd.AdbShellCommand("cmd package uninstall -k --user 0 com.huawei.retaildemo");
            AdbCmd.AdbShellCommand("cmd package uninstall -k --user 0 com.huawei.experience.vog.mea");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.huawei.retaildemo");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.huawei.experience.vog.mea");updateMsgAndRun();

        }

        private void FixTuch_Click(object sender, EventArgs e)
        {
            fixTuch ope2n = new fixTuch();
            ope2n.Show();
        }

        private String sendComendToPort(string commend)
        {
            //if (cBoxComPort.SelectedIndex > -1)
            //{
            //    MessageBox.Show("לא נבחרה יציאת COM" + "\n אנא בחר שוב יציאת COM ונסה שוב", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return cPortFail;
            //}
            try
            {
                progressBar1.Value = 0;
                serialPort1.PortName = cBoxComPort.Text;
                serialPort1.BaudRate = 115200;//Convert.ToInt32(cBoxBaundRate.Text);
                serialPort1.ReadTimeout = 1500;
                serialPort1.WriteTimeout = 1500;
                progressBar1.Value = 50;
                ClosePort();
                serialPort1.Open();
                serialPort1.WriteLine(commend + System.Environment.NewLine); //System.Environment.NewLine == new line
                progressBar1.Value = 100;
                ClosePort();
                return cPortDone;
            }
            catch (Exception)
            {
                MessageBox.Show("לא נבחרה יציאת COM" + "\n אנא בחר שוב יציאת COM ונסה שוב", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //MessageBox.Show(err.Message+"", "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Console.WriteLine(err.Message);
                return cPortError;
            }
        }

        private void downloadMode_Click(object sender, EventArgs e)
        {
            setProgressBar(0);

            logOneLine("מעבר אל מצב הורדה...");
            setProgressBar(25);
            String res = sendComendToPort("AT+FUS?");
            if (res.Equals(cPortDone))
            {
                //AdbCmd.AdbCommand("reboot bootloder");
                setProgressBar(100);
                logOneLine("בוצע", Color.Green);
                newLine();
                updateMsgAndRun("נכנס אל מצב הורדה, אנא המתן");
            }
            else
            {
                //log(res);
                setProgressBar(0);
                logOneLine("נכשל", Color.Red);
                newLine();
            }
        }



        private void ClosePort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void PhoneInfo_Click(object sender, EventArgs e)
        {
        }

        private void PhoneInfoFast()
        {
            
            setProgressBar(0);
            log("אנא המתן -קורא מידע מהמכשיר");
            setProgressBar(20);
            updatePhoneInfo();
            setProgressBar(100);
//            log("בוצע....");
        }

        public  void updatePhoneInfo()
        {
            logOneLine2Str("Android:" , AdbCmd.AdbShellCommand("getprop ro.build.version.release")); 
            logOneLine2Str("Android SDK:" , AdbCmd.AdbShellCommand("getprop ro.build.version.sdk")); 
            logOneLine2Str("דגם:" , AdbCmd.AdbShellCommand("getprop ro.product.model")); 
            logOneLine2Str("כמות סימים:" , AdbCmd.AdbShellCommand("getprop ro.multisim.simslotcount"));
            logOneLine2Str("יצרן:" , AdbCmd.AdbShellCommand("getprop ro.product.manufacturer "));
            logOneLine2Str("שפה:" , AdbCmd.AdbShellCommand("getprop ro.product.locale.language"));
            logOneLine2Str("אזור:" , AdbCmd.AdbShellCommand("getprop ro.product.locale.region"));
            logOneLine2Str("סטטוס נעילת סים:" , AdbCmd.AdbShellCommand("getprop gsm.sim.state"));
            logOneLine2Str("קוד איזור מכירה:" , AdbCmd.AdbShellCommand("getprop ro.csc.sales_code"));
            logOneLine2Str("מצב הנוקס:" , AdbCmd.AdbShellCommand("getprop ro.boot.warranty_bit"));
            logOneLine2Str("בייסבנד:" , AdbCmd.AdbShellCommand("getprop gsm.version.baseband"));
            logOneLine2Str("Fingerprint:" , AdbCmd.AdbShellCommand("getprop ro.build.fingerprint"));
            logOneLine2Str("סוג חיבור:" , AdbCmd.AdbShellCommand("getprop persist.sys.usb.config"));
            logOneLine2Str("איזור זמן:" , AdbCmd.AdbShellCommand("getprop persist.sys.timezone"));
            logOneLine2Str("סטטוס הצפנת מכשיר:" , AdbCmd.AdbShellCommand("getprop ro.crypto.state")); 
        }




        private void exitDL()
        {
            if (chackStatusSamsungDL() == false)
            {
                return;
            }
            setProgressBar(0);
            infoTXT.AppendText("יוצא ממצב הורדה...");
            setProgressBar(20);
            Samsung.sendOdinCMD("reboot");
            setProgressBar(100);
            log("בוצע", Color.Green);
        }

        private void log(String logToWrite)
        {
            infoTXT.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
            infoTXT.SelectionColor = Color.Black;
            infoTXT.AppendText(logToWrite);
            newLine();
        }
        private void log(String logToWrite, Color colorT)
        {
            infoTXT.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
            infoTXT.SelectionColor = colorT;
            infoTXT.AppendText(logToWrite);
            newLine();
        }
        private void logOneLine(String logToWrite)
        {
            infoTXT.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
            infoTXT.SelectionColor = Color.Black;
            infoTXT.AppendText(logToWrite);
        }
        private  void logOneLine2Str(String logToWrite,String secendstr)
        {
            infoTXT.SelectionFont = new Font("David", 11, FontStyle.Bold);
            infoTXT.SelectionColor = Color.Black;
            infoTXT.AppendText(logToWrite);
            Delay(1);
            infoTXT.SelectionColor = Color.Blue;
            infoTXT.AppendText(secendstr);
            //newLine();


        }
        private void logOneLine(String logToWrite, Color colorT)
        {
            infoTXT.SelectionFont = new Font("Verdana", 11, FontStyle.Bold);
            infoTXT.SelectionColor = colorT;
            infoTXT.AppendText(logToWrite);
            infoTXT.SelectionColor = Color.Black;
        }
        private void newLine()
        {
            infoTXT.AppendText(Environment.NewLine);
        }



        private void RACRemove_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            updateInfo("RAC");
            updateLog("     עובד על גלקסי 7 ומעלה");
            updateLog("הוראות      " + "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:");
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת Rent A Center");


            runFile("RAC-RunMe.exe", false, "10");




            updateLog("הסרת Rent A Center הסתימה");
        }

        private void updateInfo(string oprtion)
        {
            String temp = null;
            if (oprtion == "RAC")
                temp = "infoRAC.img";


            loadFileTolbl(temp);

        }

        public void updateLog(String newLog)
        {
            infoTXT.SelectionFont = new Font("Verdana", 12, FontStyle.Bold);
            infoTXT.AppendText(Environment.NewLine);
            infoTXT.AppendText(newLog);

        }

        public void loadFileTolbl(String company)
        {
            String filename;
            filename = toolsLoc + company;
            infoTXT.Text = File.ReadAllText(filename);
        }

        private void SamsungAccountRemoveADB_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            setProgressBar(0);
            log("מסיר חשבון סמסונג...");
            log(AdbCmd.AdbShellCommand("pm uninstall - k--user 0 com.osp.app.signin"));
            setProgressBar(100);
            log("OnKeyDown");
        }

        private void factoryReset_Click(object sender, EventArgs e)
        {
            setProgressBar(0);

            logOneLine("מבצע איפוס למכשיר סמסונג...");
            setProgressBar(25);
            if (sendComendToPort("AT+FACTORST=0,0").Equals(cPortDone))
            {
                setProgressBar(100);
                logOneLine("בוצע", Color.Green);
                newLine();
                updateMsgAndRun("האיפוס בוצע \n בעוד כמה שניות המכשיר יפעיל את עצמו ויתאפס");
            }
            else
            {
                setProgressBar(0);
                logOneLine("נכשל", Color.Red);
                newLine();
            }
        }
        private void runFile(String fileName, Boolean isHidden, String textToSend)
        {
            try
            {

                string targetDir = string.Format(toolsLoc);   //this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = fileName;
                proc.StartInfo.Arguments = string.Format(textToSend);  //this is argument
                proc.StartInfo.CreateNoWindow = true;
                if (isHidden)
                {
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;  //this is for hiding the cmd window...so execution will happen in back ground.
                }
                proc.Start();
                //proc.WaitForExit();
            }
            catch (Exception ex)
            {
                log("" + ex, Color.Lime);
                newLine();
            }
        }

        public void Status_Output(string text)
        {
            if (this.infoTXT.InvokeRequired)
                this.Invoke((Delegate)new Home.updatedelegatee(this.Status_Output), (object)text);
            else
                this.infoTXT.AppendText(Environment.NewLine + text);
        }
        private void RemoveMiAccount_Click(object sender, EventArgs e)
        {
            notSelecteMIremove();

            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.StartInfo.Arguments = "/c adb get-state";
            process.Start();
            if (!process.StandardOutput.ReadToEnd().Contains("device"))
            {

                log("שגיאה, מכשיר לא מחובר!!", Color.Red);
                setProgressBar(100);

            }
            else
            {
                log("מתחבר למכשיר...");
                setProgressBar(30);
                logOneLine("מכשיר מחובר...");
                logOneLine("בוצע!", Color.Green);
                newLine();
                setProgressBar(50);
                log("מנקה את החשבון...");
                setProgressBar(70);
                if (radioButtonBaypas.Checked == true)
                {
                    AdbCmd.AdbCommand("shell am set-debug-app -w --persistent com.xiaomi.finddevice");
                    AdbCmd.AdbCommand("shell am set-debug-app -w --persistent com.miui.cloudservice");
                    AdbCmd.AdbCommand("shell settings get --user 0 global wait_for_debugger");
                }
                else
                {
                    AdbCmd.AdbShellCommand("pm uninstall -k –user 0 com.xiaomi.finddevice");
                    AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.miui.cloudservice");
                }

                //this.Status_Output("בוצע בהצלחה!");
                log("בוצע בהצלחה!");

                setProgressBar(100);
            }
        }

        private void notSelecteMIremove()
        {
            if ((radioButtonBaypas.Checked == false) && (radioButtonRemove.Checked == false))
            {
                log("לא נבחר");
                return;
            }
        }

        public void setProgressBar(int precent)
        {
            if (precent == progressBar1.Maximum)
            {
                // Special case as value can't be set greater than Maximum.
                progressBar1.Maximum = precent + 1;     // Temporarily Increase Maximum
                progressBar1.Value = precent + 1;       // Move past
                progressBar1.Maximum = precent;         // Reset maximum
            }
            else
            {
                progressBar1.Value = precent + 1;       // Move past
            }
            progressBar1.Value = precent;               // Move to correct value

            int percent = (int)(((double)(progressBar1.Value - progressBar1.Minimum) /
                (double)(progressBar1.Maximum - progressBar1.Minimum)) * 100);
            using (Graphics gr = progressBar1.CreateGraphics())
            {
                gr.DrawString(percent.ToString() + "%",
                SystemFonts.DefaultFont,
                Brushes.AliceBlue,
                new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                SystemFonts.DefaultFont).Width / 2.0F),
                progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                SystemFonts.DefaultFont).Height / 2.0F)));
            }

            // Set the custom text at different intervals for demo purposes
            if (precent == 100)
            {
                using (Graphics gr = progressBar1.CreateGraphics())
                {

                    gr.DrawString("בוצע בהצלחה",
                    SystemFonts.DefaultFont,
                    Brushes.AliceBlue,
                    new PointF(progressBar1.Width / 2 - (gr.MeasureString(percent.ToString() + "%",
                    SystemFonts.DefaultFont).Width / 2.0F),
                    progressBar1.Height / 2 - (gr.MeasureString(percent.ToString() + "%",
                    SystemFonts.DefaultFont).Height / 2.0F)));
                }
            }
        }

        private void cleanLog()
        {
            infoTXT.Clear();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            AdbCmd.killProcess();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setProgressBar(0);
            if (!chackStatus())
            {
                log("לא מחובר מכשיר");
                setProgressBar(100);
                return;
            }
            setProgressBar(40);
            AdbCmd.AdbCmdCall();
            setProgressBar(60);
            AdbCmd.AdbCommand("install -r Data/Huawei/Gboard.apk");
            AdbCmd.AdbCommand("install -r Data/Huawei/gmsinstaller.apk");
            //open gmsInstaller or run in gms the commend
            AdbCmd.AdbShellCommand("am start -a android.intent.action.MAIN -n com.huawei.gmsinstaller");
            AdbCmd.AdbCommand("install -r Data/Huawei/GooglePlay.apk");
            setProgressBar(100);
            log("בוצע בהצלחה",Color.Green);
            log("מומלץ לשנות גם וונדור וקנטרי לשל גלובלי", Color.Blue);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            setProgressBar(0);
            log("הסרת סיוקרטי לוג ועדכוני תוכנה למכשיר לאחר רוט");
            if (!chackStatus())
            {
                return;
            }

            logOneLine("SecurityLogAgent מסיר...");
            AdbCmd.AdbShellCommand(" rm /system/app/SecurityLogAgent");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.samsung.android.securitylogagent");
            logOneLine("בוצע", Color.Green); newLine();
            setProgressBar(20);
            logOneLine("מסיר עדכוני תוכנה...");
            AdbCmd.AdbShellCommand(" rm /system/priv-app/SOAgent");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sec.android.soagent");
            logOneLine("בוצע", Color.Green);
            setProgressBar(40);
            logOneLine("Knox Enrollment Service מסיר");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.sec.enterprise.knox.cloudmdm.smdms");
            logOneLine("בוצע", Color.Green);
            setProgressBar(60);
            logOneLine("KLMS Agent מסיר");
            AdbCmd.AdbShellCommand("pm uninstall -k --user 0 com.samsung.klmsagent");
            logOneLine("בוצע", Color.Green);
            AdbCmd.AdbCommand("reboot");
            setProgressBar(100);
            updateMsgAndRun("ההסרה בוצעה, \n מבצע הפעלה מחדש");
        }



        private bool chackStatus()
        {

            if (!helperData.phoneIsOnlineInADB())
            {
                log("לא נמצא מכשיר מחובר!!!!", Color.Red);
                setProgressBar(100);
                phoneConectedPic(false);
                return false;
            }
            phoneConectedPic(true);
            //PhoneInfoFast();
            //log("זיהיתי מכשיר חדש שחובר אליי... רוצה לבצע עליו משהו?");
            return true;
        }
        private bool chackStatusSamsungDL()
        {

            if (Samsung.phoneIsOnlineInDL() == false)
            {
                log("לא נמצא מכשיר מחובר במצב הורדה!!!!", Color.Red);
                setProgressBar(100);
                return false;
            }
            return true;
        }
        private bool chackStatusFB()
        {

            if (helperData.phoneIsOnlineInFB())
            //AdbCmd.devState.Equals("Offline"))
            {
                log("לא נמצא מכשיר מחובר במצב פאסטבוט!!!!", Color.Red);
                setProgressBar(100);
                phoneConectedPic(false);
                return false;
            }
            phoneConectedPic(true);
            return true;
        }

        private void phoneConectedPic(bool a)
        {
            if (a)
            {
                conectedPic.Visible = true;
                disconectedPic.Visible = false;
            }
            else
            {
                conectedPic.Visible = false;
                disconectedPic.Visible = true;
            }

        }
        private void adbPhonePicConnect(bool a)
        {
            if (a)
            {
                Update.Visible = true;
                disconectBTN.Visible = false;
            }
            else
            {
                Update.Visible = false;
                disconectBTN.Visible = true;
            }

        }
        private void close_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            log("רק רגע - המערכת מבצעת יציאה....", Color.GreenYellow);
            ClosePort();
            AdbCmd.killProcess();
            this.Close();
        }

        private void infoTXT_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            infoTXT.SelectionStart = infoTXT.Text.Length;
            // scroll it automatically
            infoTXT.ScrollToCaret();
        }

        private void RemoveNativ_Click(object sender, EventArgs e)
        {
          //88888888888888888888888888888888888888888
            setProgressBar(0); 
            infoTXT2.Text =  "אנא קרא את הצעדים הבאים ועבוד על פי ההוראות:";
            updateLog("קרא את ההוראות");
            setProgressBar(10);



            smallTxtLableUpdate("איפוס והסרת כשרות למכשיר נתיב הכולל MDM");
            smallTxtLableUpdate("1.איפוס דרך יציאת COM PORT לבחור");
            smallTxtLableUpdate("2.לאחר שהמכשיר יעלה- אל תחבר אותו לרשת");
            smallTxtLableUpdate("3.סיים את הגדרת המכשיר (לאל שקופץ ישר נתיב - לעשות BAYPASS כדי להגיע אל ההגדרות)");
            smallTxtLableUpdate("4.כניסה אל ההגדרות והפעל ADB");
            smallTxtLableUpdate("5.פתיחת ADB/OEM");
            smallTxtLableUpdate("6.הרצת הסקריפט");
            smallTxtLableUpdate("7.עבור לצריבת הסרת MDM");
            smallTxtLableUpdate("8.צרוב את קובץ הפיקס");
            smallTxtLableUpdate("9.צרוב גרסא מלאה");
            smallTxtLableUpdate("10. לא חייב- איפוס");
            smallTxtLableUpdate("בהצלחה.....");
            smallTxtLableUpdate("**המכשיר כמו חדש - כאלו נרכש עכשיו מסאני.....***");
            setProgressBar(30);

            updateLog("מתחיל הסרת נתיב");
            setProgressBar(40);
            setProgressBar(50);
            if (!chackStatus())
            {
                setProgressBar(100);
                return;
            }
            AdbCmd.AdbShellCommand("pm clear com.nativ.vpn");
            setProgressBar(60);
            setProgressBar(70);
            setProgressBar(80);
            setProgressBar(90);
            updateLog("הסרת נתיב הסתימה");
            setProgressBar(100);

        }

        private void smallTxtLableUpdate(string txtToUpdate)
        {
            infoTXT2.AppendText(txtToUpdate);
            infoTXT2.AppendText(Environment.NewLine);
        }

        private void RemoveAskan_Click(object sender, EventArgs e)
        {
            updateLog(helperData.updateInfo("RAC"));
            updateLog("מתחיל הסרת עסקן");
            whatToRun = "RunMeAuto.exe";
            updateInfo("Askan");
            updateLog("הסרת עסקן הסתימה");

        }

        private void RemoveShoham_Click(object sender, EventArgs e)
        {
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת שוהם");
            whatToRun = "null";
            updateInfo("Shoham");
            updateLog("הסרת שוהם הסתימה");
        }

        private void RemoveHadran_Click(object sender, EventArgs e)
        {
            updateLog("קרא את ההוראות");
            updateLog("מתחיל הסרת הדרן");
            updateLog(" ");
            updateLog("הדרן כרגע לא נתמך");
            updateLog(" ");
            whatToRun = "null";
            updateInfo("Hadran");
            updateLog("הסרת הדרן הסתימה");
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (whatToRun != null)
            {
                infoTXT2.Text = "המשימה החלה- אנא עקוב אחרי ההוראות";
                whatToRun = null;
            }
            else
                infoTXT2.Text = "לא נבחר משימה לביצוע";
        }

        private void resetFRP_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            AdbCmd.BypassFRP();
        }

        private void genricFRP_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            AdbCmd.BypassFRP();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ActiveControl = null;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            addKosherApp.Visible = false;
            disconectedPic.Visible = false;
            conectedPic.Visible = false;
            //chackStatus();

            RemovePLZCall.Text = "הסרת please call me \n חלק א'";
            RemovePLZCall2.Text = "הסרת please call me \n חלק ב'";

            filCommend();
        }

        private void scanPort()
        {
            cBoxComPort.Items.Clear();

            ports = null;
            ports = SerialPort.GetPortNames();
            cBoxComPort.Items.AddRange(ports);

        }

        private void filCommend()
        {
            string[] option = { "factory reset", "set new csc (LUC)", "DOWNLOAD MODE", "Read IMEI", "Phone Version Info",
            "Read S/N"};
            string[] androidOption = { "c", "fff" };
            //cBoxCommend.Items.Clear();
            //cBoxCommend.Items.AddRange(option);
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chackStatus();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            chackStatus();
        }

        private void MotoFixCall_Click(object sender, EventArgs e)
        {
            MotoFixNetFRP();
        }
        private void MotoFixNetFRP()
        {
            AdbCmd.fcmd(" oem config bootmode \"\"");
            AdbCmd.fcmd(" oem fb_mode_clear");
            AdbCmd.fcmd(" reboot");
        }

        private void updateMsgAndRun(String updte = null)
        {
            messegBox ope2n = new messegBox(updte);
            ope2n.Show();
        }

        

        private void MotoADBEnble_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("הכנס את המכשיר למצב פאסטבוט, ולאחר מכן לחץ על אישור", "נדרש עזרה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setProgressBar(0);

                log("אנחנו מתחילים...");
                if (chackStatusFB())
                {
                    return;
                }

                AdbCmd.fcmd(" oem config bootmode {bp-tools,factory}");
                AdbCmd.fcmd(" oem bp-tools-on");
                AdbCmd.fcmd(" reboot");
                setProgressBar(50);

                MessageBox.Show("כאשר המכשיר עולה - אנא לחץ על אישור ", "נדרש עזרה", MessageBoxButtons.OK);

                if (!chackStatus())
                {
                    MessageBox.Show("כאשר המכשיר עולה - אנא לחץ על אישור ", "לא נמצא מכשיר מחובר- מנסה שוב", MessageBoxButtons.OK);
                }

                AdbCmd.BypassFRP();
                AdbCmd.AdbCommand("reboot fastboot");
                if (chackStatusFB())
                {
                    DialogResult dialogResult2 = MessageBox.Show("אם המכשיר נכנס אל פאסטבוט- לחץ כן, אם לא - לחץ לא", "נדרש עזרה", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.No)
                    {
                        MessageBox.Show("אנא הכנס את המכשיר לפאסטבוט- ולחץ אישור לאחר מכן", "נדרש עזרה", MessageBoxButtons.OK);
                    }
                }
                if (chackStatusFB())
                {
                    log("לא נמצא מכשיר - הכנס לפאסבוט ידני ובחר לאחר מכן בתוכנה את התיקון רשת לאחר FRP");
                    return;
                }

                MotoFixNetFRP();
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void RemovePLZCall_Click(object sender, EventArgs e)
        {
            //String info = "1.צרוב combination" + "\n" +
            //                "2.לחץ על כפתור ההתחל שיופיע" + "\n" +
            //                "3. צרוב Flash bl + ap + cp + home" + "\n" +
            //                "4. גש להגדרות והלהפעיל oem unlock" + "\n" +
            //                "5.צרוב TWRP ואז הפעל adb sideload" + "\n" +
            //                "6.צרוב את  pcm.zip דרך adb sideload או twrp" + "\n" +
            //                "7.התיקון בוצע לתמיד { efs + please call me}";
            DialogResult dialogResult = MessageBox.Show("האם המכשיר עם קומבינשיין?", "נבצע שלב שלב", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("נא לצרוב קומבינשיין על המכשיר ולחזור לכאן שוב");
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                // runFile("remover.bat", true,"10");
                if (!chackStatus())
                {
                    return;
                }
                AdbCmd.killProcess();
                //using (Process compiler = new Process())
                //{
                //    compiler.StartInfo.FileName = "remover.bat";
                //    compiler.StartInfo.Arguments = "";
                //    compiler.StartInfo.UseShellExecute = false;
                //    compiler.StartInfo.RedirectStandardOutput = true;
                //    compiler.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                //    compiler.Start();
                //    Console.WriteLine(compiler.StandardOutput.ReadToEnd());

                //    compiler.WaitForExit();
                //}
                AdbCmd.AdbCommand(" push txt /sdcard/");
                AdbCmd.AdbCommand(" shell mkdir /efs");
                AdbCmd.AdbCommand(" shell mount /dev/block/sda3 /efs");
                AdbCmd.AdbCommand(" shell mount /dev/block/mmcblk0p3 /efs");
                AdbCmd.AdbCommand(" shell mount /dev/block/mmcblk0p11 /efs");
                AdbCmd.AdbCommand(" shell mount /dev/block/mmcblk0p12 /efs");
                AdbCmd.AdbCommand(" hell mount /dev/block/mmcblk0p13 /efs");
                AdbCmd.AdbCommand(" shell mv /sdcard/*.txt /efs/sec_efs/sktdm_mem");
                AdbCmd.AdbCommand(" shell chmod 0400 /efs/sec_efs/sktdm_mem/*.txt");
                AdbCmd.AdbCommand(" shell chmod 0400 /efs/sec_efs/sktdm_mem");
                AdbCmd.AdbCommand(" shell chmod 0400 /efs/sec_efs");
                AdbCmd.AdbCommand(" reboot");


                MessageBox.Show(" צרוב Flash bl + ap + cp + home" + "\n" +
                            " גש להגדרות והלהפעיל oem unlock" + "\n" +
                            "צרוב TWRP ואז הפעל adb sideload");
            }

        }

        private void CBoxComPort_DropDown(object sender, EventArgs e)
        {
            scanPort();
        }

        private void RmmADB_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            setProgressBar(0);
            logOneLine("אנחנו מתחילים...");
            DialogResult dialogResult = MessageBox.Show("האם המכשיר עם קומבינשיין", "נדרש עזרה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setProgressBar(0);
                newLine();
                logOneLine("מבצע עקיפת RMM למכשירי סמסונג...");

                setProgressBar(20);
                AdbCmd.AdbShellCommand(" pm uninstall -k --user 0 com.samsung.android.rlc");
                AdbCmd.AdbShellCommand(" rm /system/priv-app/Rlc");
                AdbCmd.AdbShellCommand(" setprop ro.security.vaultkeeper.feature 0");
                AdbCmd.AdbCommand(" reboot");
                setProgressBar(100);
                log("בוצע", Color.Green);
            }
            else if (dialogResult == DialogResult.No)
            {
                log("נכשל", Color.Red);
                MessageBox.Show("מצטערים - אבל נדרש קומשיינישין \n צרוב קומבינשיין ונסה שנית", "נדרש קומבינשיין", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void RemovePLZCall2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("הכנס את המכשיר למצב ריקוברי -ADB SIDELOADE ,\n ולאחר מכן לחץ על אישור", "נדרש עזרה");

            setProgressBar(0);

            log("אנחנו מתחילים...");
            //if (chackStatusFB())
            //{
            //setProgressBar(0);
            //    return;
            //}
            setProgressBar(40);
            AdbCmd.AdbCommand(" sideload  Data/PCM_REMOVE.zip");
            setProgressBar(70);
            AdbCmd.AdbCommand(" reboot");
            setProgressBar(100);

        }

        

        private void fixMipi()
        {
            if (!chackStatus())
            {
                return;
            }
            setProgressBar(0);
            logOneLine("אנחנו מתחילים...");
            DialogResult dialogResult = MessageBox.Show("האם המכשיר עם קומבינשיין", "נדרש עזרה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setProgressBar(0);
                newLine();
                logOneLine("מבצע תיקון לMIPI שנכשל - התיקון לא קבוע");

                setProgressBar(20);
                //88888888888888888888888888888888888888888888888888888888888
                AdbCmd.AdbShellCommand("su -c 'am broadcast -a android.provider.Telephony.SECRET_CODE -d android_secret_code://33725327'");

                AdbCmd.AdbCommand(" reboot");
                setProgressBar(100);
                log("בוצע", Color.Green);
            }
            else if (dialogResult == DialogResult.No)
            {
                log("נכשל", Color.Red);
                MessageBox.Show("מצטערים - אבל נדרש קומשיינישין \n צרוב קומבינשיין ונסה שנית", "נדרש קומבינשיין", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChackAntiMiBTN_Click(object sender, EventArgs e)
        {
            if (!chackStatusFB())
            {
                return;
            }
            else
            {
                setProgressBar(0);
                newLine();
                logOneLine("בודק את רמת האנטי רולבק במכשיר");

                setProgressBar(20);

                String anti = AdbCmd.fcmd("getvar anti");

                AdbCmd.fcmd(" reboot");
                log("ANTI במכשיר הוא" + anti);
                setProgressBar(100);
                //log("בוצע", Color.Green);
            }
        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            else
            {
                setProgressBar(0);
                newLine();
                logOneLine("מבצע הוספת כפתורים לסטטוס בר");
                logOneLine("...");


                setProgressBar(20);

                String backupQS = AdbCmd.AdbShellCommand("settings get secure sysui_qs_tiles");
                String Model = AdbCmd.AdbShellCommand("getprop ro.product.model");
                String Manufacturer = AdbCmd.AdbShellCommand("getprop ro.product.manufacturer");
                String AndroidVersion = AdbCmd.AdbShellCommand("getprop ro.build.version.release");





                AdbCmd.AdbShellCommand("settings put secure sysui_qs_tiles \"Wifi,SoundMode,Bluetooth,RotationLock,Flashlight,MobileData,Location,BlueLightFilter,Hotspot,AirplaneMode,Dnd,UDS,BikeMode,work\"");

                //לכתוב לקובץ גיבוי את הגיבוי שלו
                AdbCmd.AdbCommand(" reboot");

                setProgressBar(100);
                log("בוצע", Color.Green);
                updateMsgAndRun("המתגים התווספו בהצלחה \n המכשיר מבצע הפעלה מחדש...");
                writeBackUpFile(Manufacturer + " " + Model + " " + AndroidVersion + " " + DateTime.UtcNow.Date.ToString("dd/MM/yyyy"));

            }
        }

        private void writeBackUpFile(String backup)
        {

        }
        private String readBackUpFile(String phone)
        {
            return "fsfs";
        }

        private void ExitDLbtn_Click(object sender, EventArgs e)
        {
            if (!chackStatusDL())
            {
                return;
            }
            else
            {
                exitDL();
            } 
        }

        private bool chackStatusDL()
        {
            if (!helperData.phoneIsOnlineInDL())
            {
                log("לא נמצא מכשיר מחובר במצב הורדה!!!", Color.Red);
                setProgressBar(100);
                return false;
            }
            return true;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void notWork(String errorSTR = null)
        {
            MessageBox.Show("עדיין לא מוכן" + errorSTR, "בקרוב", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Button7_Click(object sender, EventArgs e)
        {
            notWork();

            //string strFileName = null;
            ////DRK
            //OpenFileDialog fileDialogopn = new OpenFileDialog();
            //fileDialogopn.InitialDirectory = "c:\\";
            //fileDialogopn.Filter = "Samsung rom |*.tar|*.md5|";
            //fileDialogopn.FilterIndex = 2;
            //if (fileDialogopn.ShowDialog() == DialogResult.OK)
            //{
            //    strFileName = fileDialogopn.SafeFileName;
            //}
            //stockTXT.Text = strFileName;
        }

        private string getFileName()
        {
            string strFileName = null;
            //DRK
            OpenFileDialog fileDialogopn2 = new OpenFileDialog();
            fileDialogopn2.InitialDirectory = "c:\\";
            fileDialogopn2.Filter = "Samsung rom |*.tar|*.md5|";
            fileDialogopn2.FilterIndex = 2;
            if (fileDialogopn2.ShowDialog() == DialogResult.OK)
            {
                strFileName = fileDialogopn2.SafeFileName;
            }
            return strFileName;
        }

        private void ComboBTN_Click(object sender, EventArgs e)
        {
            notWork();
            //var fileContent = string.Empty;
            //var filePath = string.Empty;

            //using (OpenFileDialog openFileDialog = new OpenFileDialog())
            //{
            //    openFileDialog.InitialDirectory = "c:\\";
            //    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //    openFileDialog.FilterIndex = 2;
            //    openFileDialog.RestoreDirectory = true;

            //    if (openFileDialog.ShowDialog() == DialogResult.OK)
            //    {
            //        //Get the path of specified file
            //        filePath = openFileDialog.FileName;

            //        //Read the contents of the file into a stream
            //        var fileStream = openFileDialog.OpenFile();

            //        using (StreamReader reader = new StreamReader(fileStream))
            //        {
            //            fileContent = reader.ReadToEnd();
            //        }
            //    }
            //}

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            notWork();
        }

        private void Button3_Click_3(object sender, EventArgs e)
        {
            setProgressBar(0);

            logOneLine("מעבר אל מצב הורדה...");
            setProgressBar(25);
            String res = sendComendToPort("AT+FUS?");
            if (res.Equals(cPortDone))
            {
                //AdbCmd.AdbCommand("reboot bootloder");
                setProgressBar(100);
                logOneLine("בוצע", Color.Green);
                newLine();
                updateMsgAndRun("נכנס אל מצב הורדה, אנא המתן");
            }
            else
            {
                //log(res);
                setProgressBar(0);
                logOneLine("נכשל", Color.Red);
                newLine();
            }
        }

        private void FResetBTN_Click(object sender, EventArgs e)
        {
            setProgressBar(0);

            logOneLine("מבצע איפוס למכשיר סמסונג...");
            setProgressBar(25);
            if (sendComendToPort("AT+FACTORST=0,0").Equals(cPortDone))
            {
                setProgressBar(100);
                logOneLine("בוצע", Color.Green);
                newLine();
                updateMsgAndRun("האיפוס בוצע \n בעוד כמה שניות המכשיר יפעיל את עצמו ויתאפס");
            }
            else
            {
                setProgressBar(0);
                logOneLine("נכשל", Color.Red);
                newLine();
            }
        }

        private void FbFRPbtn_Click(object sender, EventArgs e)
        {
            if (!chackStatusFB())
            {
                return;
            }
            setProgressBar(0);
            AdbCmd.fcmd("oem unlock");
            setProgressBar(20);
            AdbCmd.fcmd("erase config");
            setProgressBar(40);
            AdbCmd.fcmd("oem lock");
            setProgressBar(70);
            AdbCmd.fcmd("reboot");
            setProgressBar(100);
            updateMsgAndRun("איפוס FRP דרך פאסבוט הסתיים \n המכשיר מבצע הפעלה מחדש כעת \n אנא המתן...");

        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
        public void Delay(double dblSecs)
        {
            DateAndTime.Now.AddSeconds(1.15740740740741E-05);
            DateTime dateTime = DateAndTime.Now;
            dateTime = dateTime.AddSeconds(1.15740740740741E-05);
            DateTime t2 = dateTime.AddSeconds(dblSecs);
            while (DateTime.Compare(DateAndTime.Now, t2) <= 0)
                Application.DoEvents();
        }

        private void RepairBBbtn_Click(object sender, EventArgs e)
        {
            
            if (checkBoxADBbb.Checked == false && checkBoxDLbb.Checked == false)
            {
                return;
            }
            if (AdbCmd.AdbShellCommand("getprop gsm.version.baseband")!= "unknown")
            {
                log("נראה שגרסת פס-הבסיס תקינה");
                //return;
            }
            if (checkBoxADBbb.Checked == true)
            {
                AdbCmd.AdbShellCommand("su -c id");
                AdbCmd.AdbShellCommand("su -c mount -o rw,remount /system");
                AdbCmd.AdbShellCommand("su -c mount -o rw,remount /data");
                AdbCmd.AdbShellCommand("su -c mount -o rw,remount /");
                AdbCmd.AdbShellCommand("su -c mount -o rw,remount /");
                AdbCmd.AdbShellCommand("su -c mount -o remount,rw /efs");
                AdbCmd.AdbShellCommand("su -c chmod 777 /efs");
                AdbCmd.AdbShellCommand("su -c rm -rf /efs");
                AdbCmd.AdbCommand("reboot");
            }
            else
            {
                repairSamsungBB();
            }
        }

        private void הריגתשרתADBToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            setProgressBar(0);
            this.ActiveControl = null;
            setProgressBar(30);
            logOneLine("רק רגע - המערכת מבצעת סגירת תהליכוני ADB....", Color.Violet);
            setProgressBar(55);
            AdbCmd.killProcess();
            setProgressBar(80);
            logOneLine("בוצע!", Color.Green); newLine();
            setProgressBar(100);
            phoneConectedPic(false);
            //updateMsgAndRun();
            //updateMsgAndRun();
        }

        private void עדכוןמכשירמחוברToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chackStatus();
        }

        private void Button3_Click_4(object sender, EventArgs e)
        {

        }

        private void מעברלפאסטבוטToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.AdbCommand("reboot fastboot");
        }

        private void ClearLog_Click(object sender, EventArgs e)
        {
            cleanLog();
        }

        private void פאסבוטמערכתToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.fcmd("reboot");
        }

        private void הפעלהמחדשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.AdbCommand("reboot");
        }

        private void מעברלבוטלואדורToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.AdbCommand("reboot bootloader");
        }

        private void ריקבריToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.AdbCommand("reboot recovery");
        }

        private void איפוסדרךפאסטבוטToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdbCmd.fcmd("erase userdata");
            AdbCmd.fcmd("erase cache");
            AdbCmd.fcmd("reboot");
        }

        private void DivecesDropDwon_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void DivecesDropDwon_Click(object sender, EventArgs e)
        {
            log("4040");
        }

        

        private async void DeltaBTN_ClickAsync(object sender, EventArgs e)
        {
            
            logOneLine("a");
            Task.Delay(10).Wait();
            await Task.Delay(2000); // for .Net 4.5
            logOneLine("b");
        }
        private async void delayILAsync()
        {
            Task.Delay(10).Wait();
            await Task.Delay(5000); // for .Net 4.5
        }

        private void FixMipiBTN_Click(object sender, EventArgs e)
        {
            fixMipi();
        }

        private void DevicescomboBox_DropDown(object sender, EventArgs e)
        {

            updateAdbDevicesList();
        }

        private void updateAdbDevicesList()
        {
            devicescomboBox.Items.Clear();
            listAdbOnline = AdbCmd.adbPhoneList();
            string[] option =listAdbOnline.Split('\n');
            option =removeFirst(option);
            devicescomboBox.Items.AddRange(option);
        }

        private string[] removeFirst(string[] option)
        {
            //delete empty item
            option = option.Skip(1).ToArray();
            option = option.Take(option.Count() - 1).ToArray();
            option = option.Take(option.Count() - 1).ToArray();
            return option;

            ////delete tab and device
            //int size = option.Length;
            //ArrayList myAL = new ArrayList();

            //while (size!=0)
            //{
            //     myAL.Add(option[size].Replace("      device", ""));
            //    size--;
            //}
            //string[] array = myAL.ToArray(typeof(string)) as string[];
            //return array;
        }

        private void DevicescomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //update adb list
           updateAdbDevicesList();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            adbPhonePicConnect(false);
            devicescomboBox.Enabled = false;
            string adbPhone_SN = devicescomboBox.GetItemText(devicescomboBox.SelectedItem);
            log(devicescomboBox.GetItemText(devicescomboBox.SelectedItem));

            AdbCmd.setSerial(adbPhone_SN);
            chackStatus();
            devicescomboBox.Text = AdbCmd.AdbCommand(adbPhone_SN, "getprop ro.product.manufacturer")+ AdbCmd.AdbCommand(adbPhone_SN, "getprop ro.product.model");
            
        }

        private void DisconectBTN_Click(object sender, EventArgs e)
        {
            devicescomboBox.Enabled = true;
            AdbCmd.setSerial(null);
            log("המכשיר נותק על ידי המשתמש, המשימה נעצרה!!!", Color.Red);
            AdbCmd.killProcess();
            adbPhonePicConnect(true);
        }

        private void UpdateAdbListBtn_Click(object sender, EventArgs e)
        {
            updateAdbDevicesList();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (!chackStatusDL())
            {
                return;
            }
            else
            {
                repairSamsungBB();
            }
        }

        private void repairSamsungBB()
        {
            string res;
            using (StreamReader reader = new StreamReader(Samsung.reapirBB()))
            {
                 res = reader.ReadToEnd();
            }

            if (res.Contains("EFS upload successful"))
            {
                log("התיקון בוצע בהצלחה", Color.Green);
            }
            else
                log("התיקון נכשל - נסה שוב", Color.Red);
            log(res);
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {

        }

        private void HauweiRemovwApp_Click(object sender, EventArgs e)
        {
            helperRun.removeApp("com.smile.gifmaker");
            helperRun.removeApp("com.mapswithme.maps.pro");
            helperRun.removeApp("com.sankuai.meituan");
            helperRun.removeApp("com.ss.android.ugc.aweme");


            setProgressBar(70);
            helperRun.removeApp("com.huawei.skytone");
            helperRun.removeApp("com.huawei.hiskytone");
            helperRun.removeApp("com.ss.android.article.news");
            helperRun.removeApp("com.huawei.hwfairy");
            helperRun.removeApp("com.baidu.input_huawei");
            helperRun.removeApp("com.zhihu.android");



            setProgressBar(80);
            helperRun.removeApp("com.vmall.client");
            helperRun.removeApp("com.sina.weibo");
            helperRun.removeApp("com.iflytek.speechsuite");
            helperRun.removeApp("com.unionpay.tsmservice");


            setProgressBar(90);
            helperRun.removeApp("com.taobao.mobile.dipei");
            helperRun.removeApp("com.achievo.vipshop");
            helperRun.removeApp("com.huawei.hwireader");
        }

        private void AsusFRPfast_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("הכנס את המכשיר למצב פאסטבוט, ולאחר מכן לחץ על אישור", "נדרש עזרה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                setProgressBar(0);

                log("אנחנו מתחילים...");
                if (chackStatusFB())
                {
                    return;
                }
                setProgressBar(30);
                AdbCmd.fcmd(" oem adb_enable");
                AdbCmd.fcmd(" oem adb_enable 1");
                AdbCmd.fcmd(" reboot");
                setProgressBar(50);

                MessageBox.Show("כאשר המכשיר עולה - אנא לחץ על אישור ", "נדרש עזרה", MessageBoxButtons.OK);
                setProgressBar(60);
                if (!chackStatus())
                {
                    MessageBox.Show("כאשר המכשיר עולה - אנא לחץ על אישור ", "לא נמצא מכשיר מחובר- מנסה שוב", MessageBoxButtons.OK);
                }
                AdbCmd.adbWaitForPhone();
                setProgressBar(70);
                AdbCmd.BypassFRP();
                setProgressBar(100);
            }
            if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (!chackStatusFB())
            {
                return;
            }
            setProgressBar(0);
            String frpKey = huweiFrpKeyTXT.Text;
            setProgressBar(20);
            AdbCmd.fcmd("fastboot oem frp-unlock "+frpKey);
            setProgressBar(40);
            setProgressBar(60);

            setProgressBar(70);
            AdbCmd.fcmd("reboot");
            setProgressBar(75);
            setProgressBar(100);
            updateMsgAndRun("בוצע- המכשיר מוחק את הFRP");

        }

        private void RepairSNbtn_Click(object sender, EventArgs e)
        {
            
            if (!chackStatus())
            {
                return;
            }
            setProgressBar(0);
            String snKey = snString.Text;
            setProgressBar(20);
            setProgressBar(30);
            //AdbCmd.AdbShellCommand("su");
            log(AdbCmd.AdbShellCommand("echo " +snKey+ " >/efs/FactoryApp/serial_no", true));

            //AdbCmd.AdbShellCommand("su \"" + snKey + "\"");
            setProgressBar(50);
            setProgressBar(70);
            //AdbCmd.AdbCommand("reboot");
            setProgressBar(100);


        }

        private void EnbleAllLangugeBTN_Click(object sender, EventArgs e)
        {
            if (!chackStatus())
            {
                return;
            }
            setProgressBar(0);
           
            setProgressBar(20);
            setProgressBar(30);
            enbleLangugeCmd();
            setProgressBar(30);
            setProgressBar(40);
            setProgressBar(50);
            setProgressBar(60);
            setProgressBar(70);
            AdbCmd.AdbCommand("reboot");
            setProgressBar(100);
        }

        private void enbleLangugeCmd()
        {
            AdbCmd.AdbCommand("install -r Data/acl.apk");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language iw\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country US\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language de -e country AT\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language nl -e country BE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fr -e country BE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language da -e country DK\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fi -e country FI\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fr -e country FR\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language de -e country DE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language it -e country IT\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fr -e country LU\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country EG\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country EG\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language nl -e country NL\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language no -e country NO\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language pl -e country PL\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language pt -e country PT\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language sv -e country SE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language de -e country CH\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fr -e country CH\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language es -e country ES\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country ES\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en-ZA -e country ZA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language af -e country ZA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en-GB -e country GB\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ru -e country RU\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language sk -e country SK\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language tr -e country TR\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country OM\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country OM\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country SA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country SA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country AE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country AE\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country BH\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country BH\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country KW\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country KW\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country LB\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country LB\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country JO\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country JO\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language ar -e country QA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en -e country QA\"");
            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language fr -e country CA\"");


            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language en\"");

            AdbCmd.AdbShellCommand("\"pm grant net.sanapeli.adbchangelanguage android.permission.CHANGE_CONFIGURATION\"");
            AdbCmd.AdbShellCommand("\"am start -n net.sanapeli.adbchangelanguage/.AdbChangeLanguage -e language iw -e country IL\"");

            AdbCmd.AdbCommand("uninstall net.sanapeli.adbchangelanguage");
        }

        private void HuaweiAddGooglePlayV2_Click(object sender, EventArgs e)
        {
            setProgressBar(0);
            if (!chackStatus())
            {
                log("לא מחובר מכשיר");
                setProgressBar(100);
                return;
            }
            setProgressBar(40);
            AdbCmd.AdbCmdCall();
            setProgressBar(60);
            AdbCmd.AdbCommand("install -r Data/Huawei/Gboard.apk");
            AdbCmd.AdbCommand("install -r Data/Huawei/a.apk");
            AdbCmd.AdbCommand("install -r Data/Huawei/b.apk");
            //open gmsInstaller or run in gms the commend
            AdbCmd.AdbShellCommand("am start -a android.intent.action.MAIN -n com.huawei.gmsinstaller");
            AdbCmd.AdbCommand("install -r Data/Huawei/GooglePlay.apk");
            setProgressBar(100);
            log("בוצע בהצלחה", Color.Green);
            log("מומלץ לשנות גם וונדור וקנטרי לשל גלובלי", Color.Blue);
        }
    }
    }


