namespace ForYou
{
    partial class frm_Ac_SinifKodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ac_SinifKodu));
            this.gridSinif = new DevExpress.XtraGrid.GridControl();
            this.ViewSinif = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSinif)).BeginInit();
            this.SuspendLayout();
            // 
            // gridSinif
            // 
            resources.ApplyResources(this.gridSinif, "gridSinif");
            this.gridSinif.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridSinif.EmbeddedNavigator.AccessibleDescription");
            this.gridSinif.EmbeddedNavigator.AccessibleName = resources.GetString("gridSinif.EmbeddedNavigator.AccessibleName");
            this.gridSinif.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridSinif.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridSinif.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridSinif.EmbeddedNavigator.Anchor")));
            this.gridSinif.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridSinif.EmbeddedNavigator.BackgroundImage")));
            this.gridSinif.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridSinif.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridSinif.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridSinif.EmbeddedNavigator.ImeMode")));
            this.gridSinif.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridSinif.EmbeddedNavigator.MaximumSize")));
            this.gridSinif.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridSinif.EmbeddedNavigator.TextLocation")));
            this.gridSinif.EmbeddedNavigator.ToolTip = resources.GetString("gridSinif.EmbeddedNavigator.ToolTip");
            this.gridSinif.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridSinif.EmbeddedNavigator.ToolTipIconType")));
            this.gridSinif.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridSinif.EmbeddedNavigator.ToolTipTitle");
            this.gridSinif.MainView = this.ViewSinif;
            this.gridSinif.Name = "gridSinif";
            this.gridSinif.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewSinif});
            // 
            // ViewSinif
            // 
            resources.ApplyResources(this.ViewSinif, "ViewSinif");
            this.ViewSinif.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ViewSinif.GridControl = this.gridSinif;
            this.ViewSinif.Name = "ViewSinif";
            this.ViewSinif.OptionsView.ShowAutoFilterRow = true;
            this.ViewSinif.OptionsView.ShowGroupPanel = false;
            this.ViewSinif.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewSinif_RowClick);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "sSinifKodu";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "sAciklama";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem()});
            // 
            // frm_SinifKodu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridSinif);
            this.Name = "frm_SinifKodu";
            this.Load += new System.EventHandler(this.frmSinifKodu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridSinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewSinif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridSinif;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewSinif;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}