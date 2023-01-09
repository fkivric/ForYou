namespace ForYou
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            resources.ApplyResources(this.ultraPanel1, "ultraPanel1");
            // 
            // ultraPanel1.ClientArea
            // 
            resources.ApplyResources(this.ultraPanel1.ClientArea, "ultraPanel1.ClientArea");
            this.ultraPanel1.ClientArea.Controls.Add(this.label2);
            this.ultraPanel1.ClientArea.Controls.Add(this.label1);
            this.ultraPanel1.ClientArea.Controls.Add(this.simpleButton1);
            this.ultraPanel1.ClientArea.Controls.Add(this.txtPassword);
            this.ultraPanel1.ClientArea.Controls.Add(this.txtUserName);
            this.ultraPanel1.Name = "ultraPanel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtPassword
            // 
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // txtUserName
            // 
            resources.ApplyResources(this.txtUserName, "txtUserName");
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // dropDownButton1
            // 
            resources.ApplyResources(this.dropDownButton1, "dropDownButton1");
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Click += new System.EventHandler(this.dropDownButton1_Click);
            // 
            // frm_Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.dropDownButton1);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "frm_Login";
            this.Load += new System.EventHandler(this.FRm_Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_Login_KeyDown);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ClientArea.PerformLayout();
            this.ultraPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
    }
}