namespace ForYou
{
    partial class frm_UzunNot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UzunNot));
            this.ultraPanel1 = new Infragistics.Win.Misc.UltraPanel();
            this.ultraLabel2 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraLabel1 = new Infragistics.Win.Misc.UltraLabel();
            this.ultraPanel2 = new Infragistics.Win.Misc.UltraPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ultraPanel3 = new Infragistics.Win.Misc.UltraPanel();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.ultraPanel1.ClientArea.SuspendLayout();
            this.ultraPanel1.SuspendLayout();
            this.ultraPanel2.ClientArea.SuspendLayout();
            this.ultraPanel2.SuspendLayout();
            this.ultraPanel3.ClientArea.SuspendLayout();
            this.ultraPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ultraPanel1
            // 
            resources.ApplyResources(this.ultraPanel1, "ultraPanel1");
            // 
            // ultraPanel1.ClientArea
            // 
            resources.ApplyResources(this.ultraPanel1.ClientArea, "ultraPanel1.ClientArea");
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel2);
            this.ultraPanel1.ClientArea.Controls.Add(this.ultraLabel1);
            this.ultraPanel1.Name = "ultraPanel1";
            // 
            // ultraLabel2
            // 
            resources.ApplyResources(this.ultraLabel2, "ultraLabel2");
            this.ultraLabel2.Name = "ultraLabel2";
            // 
            // ultraLabel1
            // 
            resources.ApplyResources(this.ultraLabel1, "ultraLabel1");
            this.ultraLabel1.Name = "ultraLabel1";
            // 
            // ultraPanel2
            // 
            resources.ApplyResources(this.ultraPanel2, "ultraPanel2");
            // 
            // ultraPanel2.ClientArea
            // 
            resources.ApplyResources(this.ultraPanel2.ClientArea, "ultraPanel2.ClientArea");
            this.ultraPanel2.ClientArea.Controls.Add(this.richTextBox1);
            this.ultraPanel2.Name = "ultraPanel2";
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            // 
            // ultraPanel3
            // 
            resources.ApplyResources(this.ultraPanel3, "ultraPanel3");
            // 
            // ultraPanel3.ClientArea
            // 
            resources.ApplyResources(this.ultraPanel3.ClientArea, "ultraPanel3.ClientArea");
            this.ultraPanel3.ClientArea.Controls.Add(this.btnKaydet);
            this.ultraPanel3.ClientArea.Controls.Add(this.btnSil);
            this.ultraPanel3.Name = "ultraPanel3";
            // 
            // btnKaydet
            // 
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnKaydet.Appearance.Font")));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnSil.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSil.Appearance.Font")));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Name = "btnSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frm_UzunNot
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ultraPanel3);
            this.Controls.Add(this.ultraPanel2);
            this.Controls.Add(this.ultraPanel1);
            this.Name = "frm_UzunNot";
            this.Load += new System.EventHandler(this.frm_UzunNot_Load);
            this.ultraPanel1.ClientArea.ResumeLayout(false);
            this.ultraPanel1.ResumeLayout(false);
            this.ultraPanel2.ClientArea.ResumeLayout(false);
            this.ultraPanel2.ResumeLayout(false);
            this.ultraPanel3.ClientArea.ResumeLayout(false);
            this.ultraPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel ultraPanel1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Infragistics.Win.Misc.UltraPanel ultraPanel3;
        private Infragistics.Win.Misc.UltraLabel ultraLabel2;
        private Infragistics.Win.Misc.UltraLabel ultraLabel1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
    }
}