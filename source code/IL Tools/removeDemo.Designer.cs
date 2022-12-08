namespace IL_Tools
{
    partial class removeDemo
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
            this.HuaweiDemoRemove = new System.Windows.Forms.Button();
            this.logTXT = new System.Windows.Forms.TextBox();
            this.Samsung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HuaweiDemoRemove
            // 
            this.HuaweiDemoRemove.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.HuaweiDemoRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HuaweiDemoRemove.Location = new System.Drawing.Point(734, 30);
            this.HuaweiDemoRemove.Name = "HuaweiDemoRemove";
            this.HuaweiDemoRemove.Size = new System.Drawing.Size(159, 46);
            this.HuaweiDemoRemove.TabIndex = 9;
            this.HuaweiDemoRemove.Text = "Huawei";
            this.HuaweiDemoRemove.UseVisualStyleBackColor = true;
            this.HuaweiDemoRemove.Click += new System.EventHandler(this.HuaweiDemoRemove_Click);
            // 
            // logTXT
            // 
            this.logTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTXT.BackColor = System.Drawing.SystemColors.Control;
            this.logTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.logTXT.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logTXT.Location = new System.Drawing.Point(428, 281);
            this.logTXT.Multiline = true;
            this.logTXT.Name = "logTXT";
            this.logTXT.ReadOnly = true;
            this.logTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTXT.Size = new System.Drawing.Size(465, 134);
            this.logTXT.TabIndex = 10;
            this.logTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Samsung
            // 
            this.Samsung.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.Samsung.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Samsung.Location = new System.Drawing.Point(569, 30);
            this.Samsung.Name = "Samsung";
            this.Samsung.Size = new System.Drawing.Size(159, 46);
            this.Samsung.TabIndex = 11;
            this.Samsung.Text = "Samsung";
            this.Samsung.UseVisualStyleBackColor = true;
            this.Samsung.Click += new System.EventHandler(this.Samsung_Click);
            // 
            // removeDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 427);
            this.Controls.Add(this.Samsung);
            this.Controls.Add(this.logTXT);
            this.Controls.Add(this.HuaweiDemoRemove);
            this.Name = "removeDemo";
            this.Text = "removeDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HuaweiDemoRemove;
        private System.Windows.Forms.TextBox logTXT;
        private System.Windows.Forms.Button Samsung;
    }
}