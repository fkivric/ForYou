namespace ForYou
{
    partial class frm_Barkod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Barkod));
            this.panel10 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbsKodu = new System.Windows.Forms.ComboBox();
            this.btnBarkodIslem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtFirmaStokAd = new System.Windows.Forms.TextBox();
            this.txtFirmaStokKod = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridBarkod = new DevExpress.XtraGrid.GridControl();
            this.ViewBarkod = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BarkodnStokID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarkodsBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarkodsFirmaKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarkodsKarsiStokKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BarkodsKarsiStokAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.panel10.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBarkod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label1);
            this.panel10.Controls.Add(this.cmbsKodu);
            this.panel10.Controls.Add(this.btnBarkodIslem);
            this.panel10.Controls.Add(this.simpleButton1);
            this.panel10.Controls.Add(this.label17);
            this.panel10.Controls.Add(this.label26);
            this.panel10.Controls.Add(this.label27);
            this.panel10.Controls.Add(this.label28);
            this.panel10.Controls.Add(this.radioButton1);
            this.panel10.Controls.Add(this.txtFirmaStokAd);
            this.panel10.Controls.Add(this.txtFirmaStokKod);
            this.panel10.Controls.Add(this.txtFirma);
            this.panel10.Controls.Add(this.txtBarkod);
            resources.ApplyResources(this.panel10, "panel10");
            this.panel10.Name = "panel10";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cmbsKodu
            // 
            this.cmbsKodu.FormattingEnabled = true;
            resources.ApplyResources(this.cmbsKodu, "cmbsKodu");
            this.cmbsKodu.Name = "cmbsKodu";
            this.cmbsKodu.SelectedIndexChanged += new System.EventHandler(this.cmbsKodu_SelectedIndexChanged);
            // 
            // btnBarkodIslem
            // 
            resources.ApplyResources(this.btnBarkodIslem, "btnBarkodIslem");
            this.btnBarkodIslem.Name = "btnBarkodIslem";
            this.btnBarkodIslem.Click += new System.EventHandler(this.btnBarkodIslem_Click);
            // 
            // simpleButton1
            // 
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // label26
            // 
            resources.ApplyResources(this.label26, "label26");
            this.label26.Name = "label26";
            // 
            // label27
            // 
            resources.ApplyResources(this.label27, "label27");
            this.label27.Name = "label27";
            // 
            // label28
            // 
            resources.ApplyResources(this.label28, "label28");
            this.label28.Name = "label28";
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtFirmaStokAd
            // 
            resources.ApplyResources(this.txtFirmaStokAd, "txtFirmaStokAd");
            this.txtFirmaStokAd.Name = "txtFirmaStokAd";
            // 
            // txtFirmaStokKod
            // 
            resources.ApplyResources(this.txtFirmaStokKod, "txtFirmaStokKod");
            this.txtFirmaStokKod.Name = "txtFirmaStokKod";
            // 
            // txtFirma
            // 
            resources.ApplyResources(this.txtFirma, "txtFirma");
            this.txtFirma.Name = "txtFirma";
            // 
            // txtBarkod
            // 
            resources.ApplyResources(this.txtBarkod, "txtBarkod");
            this.txtBarkod.Name = "txtBarkod";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridBarkod);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // gridBarkod
            // 
            resources.ApplyResources(this.gridBarkod, "gridBarkod");
            this.gridBarkod.MainView = this.ViewBarkod;
            this.gridBarkod.Name = "gridBarkod";
            this.gridBarkod.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewBarkod,
            this.gridView1});
            // 
            // ViewBarkod
            // 
            this.ViewBarkod.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BarkodnStokID,
            this.BarkodsBarkod,
            this.BarkodsFirmaKodu,
            this.BarkodsKarsiStokKodu,
            this.BarkodsKarsiStokAciklama});
            this.ViewBarkod.GridControl = this.gridBarkod;
            this.ViewBarkod.Name = "ViewBarkod";
            this.ViewBarkod.OptionsView.ShowGroupPanel = false;
            this.ViewBarkod.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewBarkod_RowClick);
            // 
            // BarkodnStokID
            // 
            resources.ApplyResources(this.BarkodnStokID, "BarkodnStokID");
            this.BarkodnStokID.FieldName = "nStokID";
            this.BarkodnStokID.Name = "BarkodnStokID";
            // 
            // BarkodsBarkod
            // 
            resources.ApplyResources(this.BarkodsBarkod, "BarkodsBarkod");
            this.BarkodsBarkod.FieldName = "sBarkod";
            this.BarkodsBarkod.Name = "BarkodsBarkod";
            this.BarkodsBarkod.OptionsColumn.AllowEdit = false;
            // 
            // BarkodsFirmaKodu
            // 
            resources.ApplyResources(this.BarkodsFirmaKodu, "BarkodsFirmaKodu");
            this.BarkodsFirmaKodu.FieldName = "sFirmaKodu";
            this.BarkodsFirmaKodu.Name = "BarkodsFirmaKodu";
            this.BarkodsFirmaKodu.OptionsColumn.AllowEdit = false;
            // 
            // BarkodsKarsiStokKodu
            // 
            resources.ApplyResources(this.BarkodsKarsiStokKodu, "BarkodsKarsiStokKodu");
            this.BarkodsKarsiStokKodu.FieldName = "sKarsiStokKodu";
            this.BarkodsKarsiStokKodu.Name = "BarkodsKarsiStokKodu";
            this.BarkodsKarsiStokKodu.OptionsColumn.AllowEdit = false;
            // 
            // BarkodsKarsiStokAciklama
            // 
            resources.ApplyResources(this.BarkodsKarsiStokAciklama, "BarkodsKarsiStokAciklama");
            this.BarkodsKarsiStokAciklama.FieldName = "sKarsiStokAciklama";
            this.BarkodsKarsiStokAciklama.Name = "BarkodsKarsiStokAciklama";
            this.BarkodsKarsiStokAciklama.OptionsColumn.AllowEdit = false;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridBarkod;
            this.gridView1.Name = "gridView1";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnKaydet.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnKaydet.Appearance.Font")));
            this.btnKaydet.Appearance.Options.UseBackColor = true;
            this.btnKaydet.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnKaydet, "btnKaydet");
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnYeni.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnYeni.Appearance.Font")));
            this.btnYeni.Appearance.Options.UseBackColor = true;
            this.btnYeni.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnYeni, "btnYeni");
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnSil
            // 
            this.btnSil.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnSil.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnSil.Appearance.Font")));
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnSil, "btnSil");
            this.btnSil.Name = "btnSil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // frm_Barkod
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnYeni);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel10);
            this.Name = "frm_Barkod";
            this.Load += new System.EventHandler(this.frm_Barkod_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBarkod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel10;
        private DevExpress.XtraEditors.SimpleButton btnBarkodIslem;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtFirmaStokAd;
        private System.Windows.Forms.TextBox txtFirmaStokKod;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraGrid.GridControl gridBarkod;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn BarkodsBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn BarkodsFirmaKodu;
        private DevExpress.XtraGrid.Columns.GridColumn BarkodsKarsiStokKodu;
        private DevExpress.XtraGrid.Columns.GridColumn BarkodsKarsiStokAciklama;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbsKodu;
        private DevExpress.XtraGrid.Columns.GridColumn BarkodnStokID;
    }
}