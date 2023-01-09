using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class frm_Ac_FiyatTipi : Form
    {
        string formname;
        public frm_Ac_FiyatTipi(string _formname)
        {
            InitializeComponent();
            formname = _formname;
        }

        SqlConnection sql = new SqlConnection(Properties.Settings.Default.connectionstring);
        SqlConnectionObject conn = new SqlConnectionObject();
        private void frm_FiyatTipi_Load(object sender, EventArgs e)
        {
            DataTable fiyattipi = new DataTable();
            DataTable doviz = new DataTable();

            if (sql.State == ConnectionState.Closed)
            {
                sql.Open();
            }
            string query = "select sDovizCinsi as [Döviz Cinsi], sAciklama as dovizadi from tbDovizCinsi";
            SqlCommand cmd = new SqlCommand(query, sql);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(doviz);
            repositoryItemLookUpEdit1.DisplayMember = "dovizadi";
            repositoryItemLookUpEdit1.ValueMember = "Döviz Cinsi";
            repositoryItemLookUpEdit1.DataSource = doviz;

            fiyattipi = conn.DfQuerySpOnly("FK_Select_FiyatTipi");
            gridFiyatTipi.DataSource = fiyattipi;
        }

        private void ViewFiyatTipi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                if (formname == "frm_FiyatGir")
                {
                    frm_FiyatGir.sFiyatTipi = ViewFiyatTipi.GetRowCellValue(e.RowHandle, "Fiyat Tipi").ToString();
                }
                this.Close();
                this.Dispose();
            }
        }
    }
}
