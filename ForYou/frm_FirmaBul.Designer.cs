namespace ForYou
{
    partial class frm_FirmaBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_FirmaBul));
            this.gridFirma = new DevExpress.XtraGrid.GridControl();
            this.ViewFirma = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFirma)).BeginInit();
            this.SuspendLayout();
            // 
            // gridFirma
            // 
            resources.ApplyResources(this.gridFirma, "gridFirma");
            this.gridFirma.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridFirma.EmbeddedNavigator.AccessibleDescription");
            this.gridFirma.EmbeddedNavigator.AccessibleName = resources.GetString("gridFirma.EmbeddedNavigator.AccessibleName");
            this.gridFirma.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridFirma.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridFirma.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridFirma.EmbeddedNavigator.Anchor")));
            this.gridFirma.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridFirma.EmbeddedNavigator.BackgroundImage")));
            this.gridFirma.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridFirma.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridFirma.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridFirma.EmbeddedNavigator.ImeMode")));
            this.gridFirma.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridFirma.EmbeddedNavigator.MaximumSize")));
            this.gridFirma.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridFirma.EmbeddedNavigator.TextLocation")));
            this.gridFirma.EmbeddedNavigator.ToolTip = resources.GetString("gridFirma.EmbeddedNavigator.ToolTip");
            this.gridFirma.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridFirma.EmbeddedNavigator.ToolTipIconType")));
            this.gridFirma.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridFirma.EmbeddedNavigator.ToolTipTitle");
            this.gridFirma.MainView = this.ViewFirma;
            this.gridFirma.Name = "gridFirma";
            this.gridFirma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewFirma});
            // 
            // ViewFirma
            // 
            resources.ApplyResources(this.ViewFirma, "ViewFirma");
            this.ViewFirma.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.ViewFirma.GridControl = this.gridFirma;
            this.ViewFirma.Name = "ViewFirma";
            this.ViewFirma.OptionsFind.Behavior = DevExpress.XtraEditors.FindPanelBehavior.Filter;
            this.ViewFirma.OptionsFind.ClearFindOnClose = false;
            this.ViewFirma.OptionsFind.SearchInPreview = true;
            this.ViewFirma.OptionsFind.ShowClearButton = false;
            this.ViewFirma.OptionsView.ShowAutoFilterRow = true;
            this.ViewFirma.OptionsView.ShowGroupPanel = false;
            this.ViewFirma.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewFirma_RowClick);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "id";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn2
            // 
            this.gridColumn2.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn2.AppearanceHeader.Font")));
            this.gridColumn2.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "sKodu";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.AllowSize = false;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn3
            // 
            this.gridColumn3.AppearanceHeader.Font = ((System.Drawing.Font)(resources.GetObject("gridColumn3.AppearanceHeader.Font")));
            this.gridColumn3.AppearanceHeader.Options.UseFont = true;
            resources.ApplyResources(this.gridColumn3, "gridColumn3");
            this.gridColumn3.FieldName = "sAciklama";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.AllowSize = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // frm_FirmaBul
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridFirma);
            this.Name = "frm_FirmaBul";
            this.Load += new System.EventHandler(this.frm_FirmaBul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFirma)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridFirma;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewFirma;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}