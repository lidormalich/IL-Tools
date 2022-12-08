namespace IL_Tools
{
    partial class RemoveKosher
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
            this.RemoveNativ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveAskan = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.infoTXT2 = new System.Windows.Forms.TextBox();
            this.plzRead = new System.Windows.Forms.Label();
            this.logTXT = new System.Windows.Forms.TextBox();
            this.logLBL = new System.Windows.Forms.Label();
            this.RemoveHadran = new System.Windows.Forms.Button();
            this.plzReadMore = new System.Windows.Forms.Label();
            this.RemoveShoham = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RemoveNativ
            // 
            this.RemoveNativ.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.RemoveNativ.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveNativ.Location = new System.Drawing.Point(435, 126);
            this.RemoveNativ.Name = "RemoveNativ";
            this.RemoveNativ.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemoveNativ.Size = new System.Drawing.Size(175, 46);
            this.RemoveNativ.TabIndex = 7;
            this.RemoveNativ.Text = "נתיב";
            this.RemoveNativ.UseVisualStyleBackColor = true;
            this.RemoveNativ.Click += new System.EventHandler(this.RemoveNativ_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yoav", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(449, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "הסרת כשרות";
            // 
            // RemoveAskan
            // 
            this.RemoveAskan.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.RemoveAskan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveAskan.Location = new System.Drawing.Point(636, 126);
            this.RemoveAskan.Name = "RemoveAskan";
            this.RemoveAskan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemoveAskan.Size = new System.Drawing.Size(175, 46);
            this.RemoveAskan.TabIndex = 6;
            this.RemoveAskan.Text = "עסקן";
            this.RemoveAskan.UseVisualStyleBackColor = true;
            this.RemoveAskan.Click += new System.EventHandler(this.RemoveAskan_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(12, 461);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 22;
            this.start.Text = "בצע";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // infoTXT2
            // 
            this.infoTXT2.BackColor = System.Drawing.SystemColors.Control;
            this.infoTXT2.Location = new System.Drawing.Point(235, 230);
            this.infoTXT2.Multiline = true;
            this.infoTXT2.Name = "infoTXT2";
            this.infoTXT2.ReadOnly = true;
            this.infoTXT2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.infoTXT2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.infoTXT2.Size = new System.Drawing.Size(576, 254);
            this.infoTXT2.TabIndex = 10;
            this.infoTXT2.Text = ".                                                                                " +
    "                                                                                " +
    "                        .";
            this.infoTXT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // plzRead
            // 
            this.plzRead.AutoSize = true;
            this.plzRead.ForeColor = System.Drawing.Color.Red;
            this.plzRead.Location = new System.Drawing.Point(328, 72);
            this.plzRead.Name = "plzRead";
            this.plzRead.Size = new System.Drawing.Size(472, 17);
            this.plzRead.TabIndex = 11;
            this.plzRead.Text = "                                                                                 " +
    "                                   ";
            // 
            // logTXT
            // 
            this.logTXT.AllowDrop = true;
            this.logTXT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.logTXT.ForeColor = System.Drawing.Color.Red;
            this.logTXT.Location = new System.Drawing.Point(12, 20);
            this.logTXT.Multiline = true;
            this.logTXT.Name = "logTXT";
            this.logTXT.ReadOnly = true;
            this.logTXT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logTXT.Size = new System.Drawing.Size(217, 435);
            this.logTXT.TabIndex = 0;
            this.logTXT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logLBL
            // 
            this.logLBL.AutoSize = true;
            this.logLBL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logLBL.Location = new System.Drawing.Point(176, 0);
            this.logLBL.Name = "logLBL";
            this.logLBL.Size = new System.Drawing.Size(53, 17);
            this.logLBL.TabIndex = 15;
            this.logLBL.Text = "Log לוג";
            // 
            // RemoveHadran
            // 
            this.RemoveHadran.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.RemoveHadran.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveHadran.Location = new System.Drawing.Point(636, 178);
            this.RemoveHadran.Name = "RemoveHadran";
            this.RemoveHadran.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemoveHadran.Size = new System.Drawing.Size(175, 46);
            this.RemoveHadran.TabIndex = 8;
            this.RemoveHadran.Text = "הדרן";
            this.RemoveHadran.UseVisualStyleBackColor = true;
            this.RemoveHadran.Click += new System.EventHandler(this.RemoveHadran_Click);
            // 
            // plzReadMore
            // 
            this.plzReadMore.AutoSize = true;
            this.plzReadMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plzReadMore.ForeColor = System.Drawing.Color.Red;
            this.plzReadMore.Location = new System.Drawing.Point(239, 103);
            this.plzReadMore.Name = "plzReadMore";
            this.plzReadMore.Size = new System.Drawing.Size(284, 20);
            this.plzReadMore.TabIndex = 23;
            this.plzReadMore.Text = "                                                       ";
            // 
            // RemoveShoham
            // 
            this.RemoveShoham.Font = new System.Drawing.Font("Yoav Cursive", 13.8F, System.Drawing.FontStyle.Bold);
            this.RemoveShoham.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveShoham.Location = new System.Drawing.Point(243, 126);
            this.RemoveShoham.Name = "RemoveShoham";
            this.RemoveShoham.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RemoveShoham.Size = new System.Drawing.Size(175, 46);
            this.RemoveShoham.TabIndex = 24;
            this.RemoveShoham.Text = "שוהם";
            this.RemoveShoham.UseVisualStyleBackColor = true;
            this.RemoveShoham.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveKosher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 496);
            this.Controls.Add(this.RemoveShoham);
            this.Controls.Add(this.plzReadMore);
            this.Controls.Add(this.RemoveHadran);
            this.Controls.Add(this.logTXT);
            this.Controls.Add(this.logLBL);
            this.Controls.Add(this.plzRead);
            this.Controls.Add(this.infoTXT2);
            this.Controls.Add(this.start);
            this.Controls.Add(this.RemoveNativ);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveAskan);
            this.Name = "RemoveKosher";
            this.Text = "RemoveKosher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RemoveNativ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveAskan;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox infoTXT2;
        private System.Windows.Forms.Label plzRead;
        private System.Windows.Forms.TextBox logTXT;
        private System.Windows.Forms.Label logLBL;
        private System.Windows.Forms.Button RemoveHadran;
        private System.Windows.Forms.Label plzReadMore;
        private System.Windows.Forms.Button RemoveShoham;
    }
}