namespace ForYou
{
    partial class frm_BedenTipiAktif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BedenTipiAktif));
            this.gridBeden = new DevExpress.XtraGrid.GridControl();
            this.ViewBeden = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridBeden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBeden)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBeden
            // 
            resources.ApplyResources(this.gridBeden, "gridBeden");
            this.gridBeden.EmbeddedNavigator.AccessibleDescription = resources.GetString("gridBeden.EmbeddedNavigator.AccessibleDescription");
            this.gridBeden.EmbeddedNavigator.AccessibleName = resources.GetString("gridBeden.EmbeddedNavigator.AccessibleName");
            this.gridBeden.EmbeddedNavigator.AllowHtmlTextInToolTip = ((DevExpress.Utils.DefaultBoolean)(resources.GetObject("gridBeden.EmbeddedNavigator.AllowHtmlTextInToolTip")));
            this.gridBeden.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gridBeden.EmbeddedNavigator.Anchor")));
            this.gridBeden.EmbeddedNavigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gridBeden.EmbeddedNavigator.BackgroundImage")));
            this.gridBeden.EmbeddedNavigator.BackgroundImageLayout = ((System.Windows.Forms.ImageLayout)(resources.GetObject("gridBeden.EmbeddedNavigator.BackgroundImageLayout")));
            this.gridBeden.EmbeddedNavigator.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gridBeden.EmbeddedNavigator.ImeMode")));
            this.gridBeden.EmbeddedNavigator.MaximumSize = ((System.Drawing.Size)(resources.GetObject("gridBeden.EmbeddedNavigator.MaximumSize")));
            this.gridBeden.EmbeddedNavigator.TextLocation = ((DevExpress.XtraEditors.NavigatorButtonsTextLocation)(resources.GetObject("gridBeden.EmbeddedNavigator.TextLocation")));
            this.gridBeden.EmbeddedNavigator.ToolTip = resources.GetString("gridBeden.EmbeddedNavigator.ToolTip");
            this.gridBeden.EmbeddedNavigator.ToolTipIconType = ((DevExpress.Utils.ToolTipIconType)(resources.GetObject("gridBeden.EmbeddedNavigator.ToolTipIconType")));
            this.gridBeden.EmbeddedNavigator.ToolTipTitle = resources.GetString("gridBeden.EmbeddedNavigator.ToolTipTitle");
            this.gridBeden.MainView = this.ViewBeden;
            this.gridBeden.Name = "gridBeden";
            this.gridBeden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewBeden});
            // 
            // ViewBeden
            // 
            resources.ApplyResources(this.ViewBeden, "ViewBeden");
            this.ViewBeden.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ViewBeden.GridControl = this.gridBeden;
            this.ViewBeden.Name = "ViewBeden";
            this.ViewBeden.OptionsView.ShowAutoFilterRow = true;
            this.ViewBeden.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewBeden_RowClick);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "sBedenTipi";
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
            // frm_BedenTipiAktif
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridBeden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_BedenTipiAktif";
            this.Load += new System.EventHandler(this.frmBedenTipiAktif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBeden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewBeden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridBeden;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewBeden;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}