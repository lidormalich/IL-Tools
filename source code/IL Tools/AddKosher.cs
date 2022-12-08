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
    public partial class AddKosher : Form
    {
        public AddKosher()
        {
            InitializeComponent();
        }
        private void updateInfo(string oprtion)
        {

            if (oprtion == "Strat")
            {
                infoTXT.AppendText(Environment.NewLine);
                infoTXT.Text = "התהליך החל....";
                infoTXT.AppendText(Environment.NewLine);
                infoTXT.Text = "אנא המתן בסבלנות";
                infoTXT.AppendText(Environment.NewLine);
                infoTXT.AppendText(Environment.NewLine);

            }

            //https://www.youtube.com/watch?v=rFhmTccRUpQ
            //tab
        }

        private void StartKosher_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.android.chrome");
            }
            if (checkBox2.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.app.sbrowser");
            }

            if (checkBox3.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm hide com.android.vending");
            }
            if (checkBox4.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.gms");
                if (checkBox3.Checked){
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.android.vending");}
            }
            
            if (checkBox5.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.googlequicksearchbox");
            }
            if (checkBox6.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.google.android.youtube");
            }
            if (checkBox7.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.orca");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.lite");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.katana");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.pages.app");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.mlite");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.creatorapp");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.facebook.katana");
            }
            if (checkBox8.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.linkedin.android");
            }
            if (checkBox9.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.app.samsungapps");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.widgetapp.samsungapps");

            }
            if (checkBox10.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.wssyncmldm");
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.sec.android.soagent");
            }
            if (checkBox11.Checked)
            {
                AdbCmd.AdbShellCommandNoReturn("pm uninstall -k --user 0 com.skype.raider");
            }
            



            AdbCmd.killProcess();

        }
    }
}
