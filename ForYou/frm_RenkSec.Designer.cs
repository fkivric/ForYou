namespace ForYou
{
    partial class frm_RenkSec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RenkSec));
            this.gridRenk = new DevExpress.XtraGrid.GridControl();
            this.ViewRenk = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridRenk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRenk)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRenk
            // 
            resources.ApplyResources(this.gridRenk, "gridRenk");
            this.gridRenk.MainView = this.ViewRenk;
            this.gridRenk.Name = "gridRenk";
            this.gridRenk.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewRenk});
            // 
            // ViewRenk
            // 
            this.ViewRenk.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ViewRenk.GridControl = this.gridRenk;
            this.ViewRenk.Name = "ViewRenk";
            this.ViewRenk.OptionsView.ShowAutoFilterRow = true;
            this.ViewRenk.OptionsView.ShowGroupPanel = false;
            this.ViewRenk.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.ViewRenk_RowClick);
            // 
            // gridColumn1
            // 
            resources.ApplyResources(this.gridColumn1, "gridColumn1");
            this.gridColumn1.FieldName = "sRenk";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            // 
            // gridColumn2
            // 
            resources.ApplyResources(this.gridColumn2, "gridColumn2");
            this.gridColumn2.FieldName = "sRenkAdi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            // 
            // frm_RenkSec
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridRenk);
            this.Name = "frm_RenkSec";
            this.Load += new System.EventHandler(this.frm_RenkSec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRenk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewRenk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridRenk;
        private DevExpress.XtraGrid.Views.Grid.GridView ViewRenk;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}