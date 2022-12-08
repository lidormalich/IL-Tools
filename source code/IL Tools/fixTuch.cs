using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IL_Tools
{
    public partial class fixTuch : Form
    {
        public fixTuch()
        {
            InitializeComponent();
            updateLog("נא להפעיל דרך הגדרות >> מפתחים - את האופציה של oem");
            updateLog("על מנת לאפשר צריבה של קבצים לתיקון");
            updateLog("לא כל מכשיר ידרש הפעלת OEM");
        }

        public void updateLog(String newLog)
        {
            logTXT.AppendText(Environment.NewLine);
            logTXT.AppendText(newLog);
        }
    }
}
