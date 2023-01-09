using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace ForYou
{
    public partial class frm_Ac_BedenTipiAktif : DevExpress.XtraEditors.XtraForm
    {
        public frm_Ac_BedenTipiAktif()
        {
            InitializeComponent();
        }

        private void frmBedenTipiAktif_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select  sBedenTipi,sAciklama from tbBedenTipi where sBedenTipi != ''";
            komut2.Connection = baglanti2;
            komut2.CommandType = CommandType.Text;
            SqlDataAdapter adap2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            if (baglanti2.State == ConnectionState.Closed)
            {
                baglanti2.Open();
            }
            adap2.Fill(dt2);
            baglanti2.Close();
            gridBeden.DataSource = dt2;
        }

        private void ViewBeden_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                var kod = ViewBeden.GetRowCellValue(e.RowHandle, "sBedenTipi").ToString();
                frm_BedenTipi.sBedenTipi = kod;
                this.Close();
            }
        }
    }
}