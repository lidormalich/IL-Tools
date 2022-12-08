namespace IL_Tools
{
    partial class messegBox
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messegBox));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuFormFadeTransition1 = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.icon = new System.Windows.Forms.PictureBox();
            this.icon_delay = new System.Windows.Forms.Timer(this.components);
            this.btnok = new Bunifu.Framework.UI.BunifuThinButton2();
            this.okLBL = new System.Windows.Forms.Label();
            this.closeWin = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuFormFadeTransition1
            // 
            this.bunifuFormFadeTransition1.Delay = 1;
            this.bunifuFormFadeTransition1.TransitionEnd += new System.EventHandler(this.BunifuFormFadeTransition1_TransitionEnd);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.Enabled = false;
            this.icon.Image = global::IL_Tools.Properties.Resources.checkmark;
            this.icon.Location = new System.Drawing.Point(12, -51);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(555, 325);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // icon_delay
            // 
            this.icon_delay.Interval = 4000;
            this.icon_delay.Tick += new System.EventHandler(this.Icon_delay_Tick);
            // 
            // btnok
            // 
            this.btnok.ActiveBorderThickness = 1;
            this.btnok.ActiveCornerRadius = 30;
            this.btnok.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.btnok.ActiveForecolor = System.Drawing.Color.White;
            this.btnok.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnok.BackgroundImage")));
            this.btnok.ButtonText = "אישור";
            this.btnok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnok.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnok.IdleBorderThickness = 1;
            this.btnok.IdleCornerRadius = 30;
            this.btnok.IdleFillColor = System.Drawing.Color.White;
            this.btnok.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnok.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnok.Location = new System.Drawing.Point(189, 328);
            this.btnok.Margin = new System.Windows.Forms.Padding(5);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(181, 63);
            this.btnok.TabIndex = 1;
            this.btnok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnok.Visible = false;
            this.btnok.Click += new System.EventHandler(this.Btnok_Click);
            // 
            // okLBL
            // 
            this.okLBL.Font = new System.Drawing.Font("David", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLBL.ForeColor = System.Drawing.Color.Gray;
            this.okLBL.Location = new System.Drawing.Point(8, 222);
            this.okLBL.Name = "okLBL";
            this.okLBL.Size = new System.Drawing.Size(558, 101);
            this.okLBL.TabIndex = 2;
            this.okLBL.Text = "המשימה בוצעה בהצלחה";
            this.okLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.okLBL.Visible = false;
            // 
            // closeWin
            // 
            this.closeWin.Interval = 7000;
            this.closeWin.Tick += new System.EventHandler(this.CloseWin_Tick);
            // 
            // messegBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 405);
            this.Controls.Add(this.okLBL);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "messegBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "דיאלוג";
            this.Load += new System.EventHandler(this.MessegBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition bunifuFormFadeTransition1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Timer icon_delay;
        private Bunifu.Framework.UI.BunifuThinButton2 btnok;
        private System.Windows.Forms.Label okLBL;
        private System.Windows.Forms.Timer closeWin;
    }
}