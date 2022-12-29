namespace ForYou
{
    partial class frmBedenTipiAktif
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
            this.gridBeden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBeden.Location = new System.Drawing.Point(0, 0);
            this.gridBeden.MainView = this.ViewBeden;
            this.gridBeden.Name = "gridBeden";
            this.gridBeden.Size = new System.Drawing.Size(671, 543);
            this.gridBeden.TabIndex = 0;
            this.gridBeden.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ViewBeden});
            // 
            // ViewBeden
            // 
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
            this.gridColumn1.Caption = "Beden Tipi";
            this.gridColumn1.FieldName = "sBedenTipi";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.FixedWidth = true;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Açıklama";
            this.gridColumn2.FieldName = "sAciklama";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // frmBedenTipiAktif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 543);
            this.Controls.Add(this.gridBeden);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBedenTipiAktif";
            this.Text = "Beden Tipi Seç";
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