namespace IL_Tools
{
    partial class frpReset
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
            this.frpResetADB = new System.Windows.Forms.Button();
            this.Exynos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Qualcomm = new System.Windows.Forms.Button();
            this.chackModel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frpResetADB
            // 
            this.frpResetADB.Location = new System.Drawing.Point(699, 97);
            this.frpResetADB.Name = "frpResetADB";
            this.frpResetADB.Size = new System.Drawing.Size(230, 52);
            this.frpResetADB.TabIndex = 0;
            this.frpResetADB.Text = "איפוס באמצעות ADB";
            this.frpResetADB.UseVisualStyleBackColor = true;
            this.frpResetADB.Click += new System.EventHandler(this.frpResetADB_Click);
            // 
            // Exynos
            // 
            this.Exynos.Location = new System.Drawing.Point(252, 354);
            this.Exynos.Name = "Exynos";
            this.Exynos.Size = new System.Drawing.Size(230, 52);
            this.Exynos.TabIndex = 1;
            this.Exynos.Text = "Exynos";
            this.Exynos.UseVisualStyleBackColor = true;
            this.Exynos.Click += new System.EventHandler(this.Exynos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 269);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(403, 68);
            this.label1.TabIndex = 2;
            this.label1.Text = "איפוס FRP באמצעות מצב הורדה\r\n\r\nכדי לבדוק את דגם המעבד ואם המכשיר נתמך-בדוק בתמונה" +
    " בצד  \"מודל\"\r\nלדגמים נתמכים בלבד- השימוש על אחריותך";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yoav", 42F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(352, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 70);
            this.label2.TabIndex = 29;
            this.label2.Text = "הסרת FRP";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yoav", 42F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(353, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 70);
            this.label3.TabIndex = 30;
            this.label3.Text = "מצב הורדה";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Qualcomm
            // 
            this.Qualcomm.Location = new System.Drawing.Point(488, 354);
            this.Qualcomm.Name = "Qualcomm";
            this.Qualcomm.Size = new System.Drawing.Size(230, 52);
            this.Qualcomm.TabIndex = 31;
            this.Qualcomm.Text = "Qualcomm";
            this.Qualcomm.UseVisualStyleBackColor = true;
            this.Qualcomm.Click += new System.EventHandler(this.Qualcomm_Click);
            // 
            // chackModel
            // 
            this.chackModel.Location = new System.Drawing.Point(3, 269);
            this.chackModel.Name = "chackModel";
            this.chackModel.Size = new System.Drawing.Size(230, 52);
            this.chackModel.TabIndex = 32;
            this.chackModel.Text = "בדוק מעבד - מודל";
            this.chackModel.UseVisualStyleBackColor = true;
            this.chackModel.Click += new System.EventHandler(this.chackModel_Click);
            // 
            // frpReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 536);
            this.Controls.Add(this.chackModel);
            this.Controls.Add(this.Qualcomm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exynos);
            this.Controls.Add(this.frpResetADB);
            this.Name = "frpReset";
            this.Text = "frpReset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frpResetADB;
        private System.Windows.Forms.Button Exynos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Qualcomm;
        private System.Windows.Forms.Button chackModel;
    }
}