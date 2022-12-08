namespace IL_Tools
{
    partial class modelFRPDwonlodsMode
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
            this.Qualcomm = new System.Windows.Forms.Button();
            this.Exynos = new System.Windows.Forms.Button();
            this.Q = new System.Windows.Forms.PictureBox();
            this.E = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Q)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.E)).BeginInit();
            this.SuspendLayout();
            // 
            // Qualcomm
            // 
            this.Qualcomm.Location = new System.Drawing.Point(848, 12);
            this.Qualcomm.Name = "Qualcomm";
            this.Qualcomm.Size = new System.Drawing.Size(230, 52);
            this.Qualcomm.TabIndex = 33;
            this.Qualcomm.Text = "Qualcomm";
            this.Qualcomm.UseVisualStyleBackColor = true;
            this.Qualcomm.Click += new System.EventHandler(this.Qualcomm_Click);
            // 
            // Exynos
            // 
            this.Exynos.Location = new System.Drawing.Point(12, 12);
            this.Exynos.Name = "Exynos";
            this.Exynos.Size = new System.Drawing.Size(230, 52);
            this.Exynos.TabIndex = 32;
            this.Exynos.Text = "Exynos";
            this.Exynos.UseVisualStyleBackColor = true;
            this.Exynos.Click += new System.EventHandler(this.Exynos_Click);
            // 
            // Q
            // 
            this.Q.Image = global::IL_Tools.Properties.Resources.models_picture;
            this.Q.Location = new System.Drawing.Point(12, 79);
            this.Q.Name = "Q";
            this.Q.Size = new System.Drawing.Size(1063, 650);
            this.Q.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Q.TabIndex = 37;
            this.Q.TabStop = false;
            this.Q.Visible = false;
            // 
            // E
            // 
            this.E.Image = global::IL_Tools.Properties.Resources.models_pic;
            this.E.Location = new System.Drawing.Point(12, 70);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(1063, 339);
            this.E.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.E.TabIndex = 36;
            this.E.TabStop = false;
            this.E.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "אם התמונה חתוכה - אתה יכול לשחק עם גודל \r\nהחלון על מנת לראות את התמונה במלואה";
            // 
            // modelFRPDwonlodsMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Q);
            this.Controls.Add(this.E);
            this.Controls.Add(this.Qualcomm);
            this.Controls.Add(this.Exynos);
            this.Name = "modelFRPDwonlodsMode";
            this.Text = "modelFRPDwonlodsMode";
            ((System.ComponentModel.ISupportInitialize)(this.Q)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Qualcomm;
        private System.Windows.Forms.Button Exynos;
        private System.Windows.Forms.PictureBox E;
        private System.Windows.Forms.PictureBox Q;
        private System.Windows.Forms.Label label1;
    }
}