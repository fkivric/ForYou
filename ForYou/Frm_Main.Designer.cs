namespace ForYou
{
    partial class Frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stokAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokAçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parametreTanımlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedenAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokSınıfıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokAçToolStripMenuItem,
            this.parametreTanımlamaToolStripMenuItem,
            this.dilToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // stokAçToolStripMenuItem
            // 
            this.stokAçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stokAçToolStripMenuItem1});
            this.stokAçToolStripMenuItem.Name = "stokAçToolStripMenuItem";
            resources.ApplyResources(this.stokAçToolStripMenuItem, "stokAçToolStripMenuItem");
            // 
            // stokAçToolStripMenuItem1
            // 
            this.stokAçToolStripMenuItem1.Name = "stokAçToolStripMenuItem1";
            resources.ApplyResources(this.stokAçToolStripMenuItem1, "stokAçToolStripMenuItem1");
            this.stokAçToolStripMenuItem1.Click += new System.EventHandler(this.stokAçToolStripMenuItem1_Click);
            // 
            // parametreTanımlamaToolStripMenuItem
            // 
            this.parametreTanımlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkAçToolStripMenuItem,
            this.bedenAçToolStripMenuItem,
            this.stokSınıfıAçToolStripMenuItem});
            this.parametreTanımlamaToolStripMenuItem.Name = "parametreTanımlamaToolStripMenuItem";
            resources.ApplyResources(this.parametreTanımlamaToolStripMenuItem, "parametreTanımlamaToolStripMenuItem");
            // 
            // renkAçToolStripMenuItem
            // 
            this.renkAçToolStripMenuItem.Name = "renkAçToolStripMenuItem";
            resources.ApplyResources(this.renkAçToolStripMenuItem, "renkAçToolStripMenuItem");
            this.renkAçToolStripMenuItem.Click += new System.EventHandler(this.renkAçToolStripMenuItem_Click);
            // 
            // bedenAçToolStripMenuItem
            // 
            this.bedenAçToolStripMenuItem.Name = "bedenAçToolStripMenuItem";
            resources.ApplyResources(this.bedenAçToolStripMenuItem, "bedenAçToolStripMenuItem");
            this.bedenAçToolStripMenuItem.Click += new System.EventHandler(this.bedenAçToolStripMenuItem_Click);
            // 
            // stokSınıfıAçToolStripMenuItem
            // 
            this.stokSınıfıAçToolStripMenuItem.Name = "stokSınıfıAçToolStripMenuItem";
            resources.ApplyResources(this.stokSınıfıAçToolStripMenuItem, "stokSınıfıAçToolStripMenuItem");
            this.stokSınıfıAçToolStripMenuItem.Click += new System.EventHandler(this.stokSınıfıAçToolStripMenuItem_Click);
            // 
            // dilToolStripMenuItem
            // 
            this.dilToolStripMenuItem.Name = "dilToolStripMenuItem";
            resources.ApplyResources(this.dilToolStripMenuItem, "dilToolStripMenuItem");
            this.dilToolStripMenuItem.Click += new System.EventHandler(this.dilToolStripMenuItem_Click);
            // 
            // Frm_Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stokAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokAçToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parametreTanımlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedenAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokSınıfıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dilToolStripMenuItem;
    }
}