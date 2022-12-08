using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IL_Tools
{
    public partial class messegBox : Form
    {
        string updateStr;
        public messegBox(string updte)
        {
            InitializeComponent();
             updateStr= updte;
        }

        private void MessegBox_Load(object sender, EventArgs e)
        {
            start();
        }

        private void BunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            
        }

        
        private void Icon_delay_Tick(object sender, EventArgs e)
        {
            
            icon.Enabled = false;
            icon_delay.Stop();
            okLBL.Visible = true;
            btnok.Visible = true;
        }

        public void start()
        {
            if (updateStr != null)
            { 
                okLBL.Text = updateStr;
            }
            bunifuFormFadeTransition1.ShowAsyc(this);
            icon_delay.Start();
            icon.Enabled = true;
            closeWin.Start();
        }

        private void Btnok_Click(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.HideAsyc(this,true);
            this.Close();
        }

        private void CloseWin_Tick(object sender, EventArgs e)
        {
            closeWin.Stop();
            this.Close();
        }
    }
}
