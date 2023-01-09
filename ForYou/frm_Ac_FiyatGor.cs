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
    public partial class frm_Ac_FiyatGor : Form
    {
        string smodel;
        public frm_Ac_FiyatGor(string _smodel)
        {
            InitializeComponent();
            smodel = _smodel;
        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring);
        DataTable fiyatlar = new DataTable();
        private void frm_FiyatGor_Load(object sender, EventArgs e)
        {
            string query = "select distinct f.sFiyatTipi,ft.sAciklama,lFiyat,f.dteFiyatTespitTarihi from tbStokFiyati f ";
            query = query + "inner join tbFiyatTipi ft on ft.sFiyatTipi=f.sFiyatTipi ";
            query = query + "inner join tbStok s on s.nStokID = f.nStokID ";
            query = query + "where s.sModel = '"+ smodel + "'";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            da.Fill(fiyatlar);
            gridControl1.DataSource = fiyatlar;
            connection.Close();

        }
    }
}
