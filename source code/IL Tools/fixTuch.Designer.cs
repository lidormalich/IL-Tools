namespace IL_Tools
{
    partial class fixTuch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(374, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "תיקון טאצ למסכי קופי(לא מקורי) שעבדו תקין ולאחר עדכון גרסא הטאצ לא תקין";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yoav", 42F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(278, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(540, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "תיקון טאצ למסכי קופי";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // logTXT
            // 
            this.logTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTXT.BackColor = System.Drawing.SystemColors.Control;
            this.logTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.logTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logTXT.Location = new System.Drawing.Point(72, 147);
            this.logTXT.Multiline = true;
            this.logTXT.Name = "logTXT";
            this.logTXT.ReadOnly = true;
            this.logTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTXT.Size = new System.Drawing.Size(465, 134);
            this.logTXT.TabIndex = 30;
            this.logTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fixTuch
            // 
            this.ClientSize = new System.Drawing.Size(994, 423);
            this.Controls.Add(this.logTXT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "fixTuch";
            this.Text = "תיקון טאצ למסכי קופי שנחסמו";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logTXT;
    }
}