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
    public partial class frm_RenkSec : Form
    {
        public frm_RenkSec()
        {
            InitializeComponent();
        }

        private string hexValue;
        private int decValue;
        private void frm_RenkSec_Load(object sender, EventArgs e)
        {
            gridRenk.DataSource = null;
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select sRenk,sRenkAdi,lRenkNo from tbRenk";
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
            gridRenk.DataSource = dt2;
        }

        private void ViewRenk_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                var kod = ViewRenk.GetRowCellValue(e.RowHandle, "sRenk").ToString();
                Frm_RenkTipi.sRenk = kod;
                this.Close();
            }
        }
    }
}
