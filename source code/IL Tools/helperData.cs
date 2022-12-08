using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;
using Microsoft.Win32;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace IL_Tools
{
    class helperData
    {
        //private string toolsDataLoction = string.Format(@"C:\IL Tools\File");
        string pathOfTools = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        static string snNumber = "סיראל";
        static string userName = " ופלוץ";

        public static string getToolsDataLoction()
        {
            //return (string.Format(@"C:\IL Tools\File").ToString());
            return (string.Format(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\"));
        }
        public static  string getSpcificFile(string filename)
        {
            return (string.Format(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\" + filename));
        }
        public static bool chackLicense(string lin)
        {
            bool isLin = false;
            switch (lin)
                {
                case "DY2W-JCQ8-9DLR-HLG9-3NE2-GLSY-T6":
                    isLin = true;
                    break;
                case "S9JA-JSLR-9H3Z-7RY8-ATKW-F4M8-PE":
                    isLin = true;
                    break;
                case "QMKS-MGXT-TX9F-7EUT-PJEA-5UEG-GC":
                    isLin = true;
                    break;
                case "NH4S-8DP6-FE3G-ZDVN-EG24-HMQD-X7":
                    isLin = true;
                    break;
                case "WUFY-RFS8-8AN4-N4Q3-2Y4X-SMQM-U6":
                    isLin = true;
                    break;
                case "E5EV-CTBV-N8LW-6KTP-FBC5-924L-QU":
                    isLin = true;
                    break;
                case "RQ5A-DA88-E29X-AKL6-ANBA-22CJ-52":
                    isLin = true;
                    break;
                case "QQPM-R6Y4-6XNT-TKQS-LZGS-TYC4-7Q":
                    isLin = true;
                    break;
                case "5UF3-3Y76-HJSZ-5DFP-TH2K-27B4-S3":
                    isLin = true;
                    break;
                case "PDZD-DMD7-ZY57-6PTK-J5R4-24TD-D7":
                    isLin = true;
                    break;
                case "PMNV-RSHJ-9ZLB-K9H9-2ZQC-UA9Y-B4":
                    isLin = true;
                    break;
                case "FHAT-H9QB-9ZRY-4FXF-4DSF-BZUM-73":
                    isLin = true;
                    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;
                //case "1":
                //    isLin = true;
                //    break;

                default:
                    return false;
            }
            return isLin;
        
        }

        public static bool phoneIsOnlineInADB()
        {
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
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool phoneIsOnlineInDL()
        {
            Process process = new Process();
            process.StartInfo.FileName = "bin/dm.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.StartInfo.Arguments = "detect";
            process.Start();
            if (!process.StandardOutput.ReadToEnd().Contains("Device detected"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }




        public static string updateInfo(string oprtion)
        {
            String temp = null;
            switch (oprtion)
            { 
                case "RAC": temp = "איפוס והסרת Rent-A-Center למכשיר סמסונג הכולל MDM \n"+
                        "שלבים: \n" +
                        " \n" +
                        "1.להסיר חשבון גוגל וסמסונג(כדי שלא יהיה FRP) \n" +
                        "2.איפוס דרך יציאת COM PORT -קיים בעמוד הראשי \n" +
                        "3.לתת לסמסונג KNOX להגדיר את המכשיר(על מנת שיוסר הMDM ויהיה אפשר לצרוב את המכשיר) \n" +
                        "4.הפעלה מחדש \n" +
                        "5.פתיחת OEM וגם USB דיבאג \n" +
                        "6.צריבת קומבינשיין \n" +
                        "7.צריבת רום סטוק (מלא שיכלול איפוס- אבל לראות שOEM דולק) \n" +
                        "8.לצרוב ריקוברי TWRP מתאים למכשיר \n" +
                        " \n" +
                        "11.איפוס למכשיר(או צריבת גרסא מלאה בלי ריקוברי) \n" +
                        "12.לתת למכשיר להגדיר את הסמסונג נוקס(אבל בפועל לא יוגדר כלום) \n" +
                        "	יתווספו להגדרות במכשיר עוד כמ דברים- אל דאגה==זה תקין \n" +
                        "13.לצרוב גרסא מלאה שוב(כולל CSC בשביל איפוס) \n" +
                        " \n" +
                        "*******	המכשיר יעלה ויגדיר שוב את הסמסונג KNOX אבל ריק והכל תקין- כאלו נרכש עכשיו מסאני.....*** \n";
                    break;
                
            }
            return temp;
        }

        public static bool phoneIsOnlineInFB()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardError = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.WorkingDirectory = Application.StartupPath;
            process.StartInfo.Arguments = "/c fastboot get-state";
            process.Start();
            if (!process.StandardOutput.ReadToEnd().Contains("device"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static string getUserName()
        {
            return userName;
        }
        public static void setUserName(String user)
        {
            userName = user;
        }
        public static string getsnNumber()
        {
            return snNumber;
        }
        public static void setsnNumber(String sn)
        {
            snNumber = sn;
        }

        public string[] GetAllPosibleCommendInText()
        {
            string[] option = { "factory reset", "set new csc (LUC)", "DOWNLOAD MODE", "Read IMEI", "Phone Version Info",
            "Read S/N"};
            return option;
        }
        
    }

}

