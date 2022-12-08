using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;


using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;




namespace IL_Tools
{
    public partial class activeTools : Form
    {
        //DB
        IFirebaseConfig confing = new FirebaseConfig
        {
            AuthSecret = "9OjqShSAzdpNLOGI6nNq1ckaHg9BiPrNWmMxsXjx",
            BasePath= "https://il-tools.firebaseio.com/"
        };
        IFirebaseClient client;

        //All
        helperData data = new helperData();
        String file = helperData.getSpcificFile("License");
        OpenFileDialog openfile =  new OpenFileDialog();
        Thread th;
        
        public activeTools()
        {
            InitializeComponent();
        }
        private void active_Click(object sender, EventArgs e)
        {
            String code=activeCode.Text;
            creatLicense(code);
            helperData.setUserName("לידור");
            helperData.setsnNumber(code);
            if (helperData.chackLicense(code))
            {
               
                this.Close();              
                th = new Thread(openHomeTab);
                th.Start();
            }
            else
            {
                activeCode.Clear();
                System.Windows.Forms.MessageBox.Show("מספר לא קיים- אנא הזן שנית, או רכוש רישיון");
            }
            
        }

        private  void creatLicense(string value)
        {
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine(value);
                sw.Close();
            }

        }
        private void openHomeTab()
        {
            Application.Run(new Home());
            //Application.Run(new messegBox());

        }

        private void chackIfHaveWorkingLicence()
        {
                if (!File.Exists(file))
                {
                    File.CreateText(file);
                }
                using (StreamReader sr = new StreamReader(file))
                {
                    String code = sr.ReadLine();
                    sr.Close();
                    if (helperData.chackLicense(code))
                    {
                        this.Close();
                        th = new Thread(openHomeTab);
                        th.Start();
                        return;
                    }
                }
                System.Windows.Forms.MessageBox.Show("בעייה במציאת וזיהוי מפתח הרישיון, אנא הקלד את המפתח שוב");
            
            
        }
        

        private void activeTools_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(confing);
            if(client==null)
            {
                MessageBox.Show("חיבור לשרת נכשל - מבצע יציאה");
                this.Close();
            }

            active.Enabled = false;
            chackIfHaveWorkingLicence();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void activeCode_TextChanged(object sender, EventArgs e)
        {
            if (activeCode.Text.Length >= 10)
                active.Enabled = true;
        }

        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            if (activeCode.Text.Length >= 10)
                active.Enabled = true;
        }
    }
}
