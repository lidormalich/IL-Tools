using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IL_Tools
{
    public partial class modelFRPDwonlodsMode : Form
    {
        public modelFRPDwonlodsMode()
        {
            InitializeComponent();
        }

        private void Qualcomm_Click(object sender, EventArgs e)
        {
            Q.Visible = true;
            E.Visible = false;
        }

        private void Exynos_Click(object sender, EventArgs e)
        {
            Q.Visible = false;
            E.Visible = true;
        }
    }
}
