namespace IL_Tools
{
    partial class activeTools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(activeTools));
            this.label1 = new System.Windows.Forms.Label();
            this.activeCode = new System.Windows.Forms.TextBox();
            this.active = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // activeCode
            // 
            resources.ApplyResources(this.activeCode, "activeCode");
            this.activeCode.Name = "activeCode";
            this.activeCode.TextChanged += new System.EventHandler(this.activeCode_TextChanged);
            // 
            // active
            // 
            resources.ApplyResources(this.active, "active");
            this.active.Name = "active";
            this.active.UseVisualStyleBackColor = true;
            this.active.Click += new System.EventHandler(this.active_Click);
            // 
            // close
            // 
            resources.ApplyResources(this.close, "close");
            this.close.Name = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // activeTools
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.Controls.Add(this.close);
            this.Controls.Add(this.active);
            this.Controls.Add(this.activeCode);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "activeTools";
            this.Load += new System.EventHandler(this.activeTools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox activeCode;
        private System.Windows.Forms.Button active;
        private System.Windows.Forms.Button close;
    }
}