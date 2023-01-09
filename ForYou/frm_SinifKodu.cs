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
    public partial class frm_SinifKodu : DevExpress.XtraEditors.XtraForm
    {
        string sira;
        string tur;
        public frm_SinifKodu(string _sira,string _tur)
        {
            InitializeComponent();
            sira = _sira;
            tur = _tur;
        }

        private void frmSinifKodu_Load(object sender, EventArgs e)
        {
            gridSinif.DataSource = null;
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select sSinifKodu,sAciklama from tbSSinif" + sira;
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
            gridSinif.DataSource = dt2;
        }

        private void ViewSinif_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.RowHandle >= 0 && e.Clicks == 2 && e.Button == MouseButtons.Left)
            {
                var kod = ViewSinif.GetRowCellValue(e.RowHandle, "sSinifKodu").ToString();
                if (sira == "1")
                {
                    if (tur == "1")
                    {
                        frm_StandartKartAc.sinifkodu1 = kod;
                    }
                    else
                    {
                        frm_Stok.sinifkodu1 = kod;
                        frm_StokSinifi.Secili = kod;
                    }
                }
                else if (sira == "2")
                {
                    if (tur == "1")
                    {
                        
                    }
                    else
                    {
                        frm_Stok.sinifkodu2 = kod;
                        frm_StokSinifi.Secili = kod;
                    }
                }
                else if (sira == "3")
                {
                    if (tur == "1")
                    {
                        frm_StandartKartAc.sinifkodu2 = kod;
                    }
                    else
                    {
                        frm_Stok.sinifkodu3 = kod;
                        frm_StokSinifi.Secili = kod;
                    }
                }
                else if (sira == "4")
                    {
                    if (tur == "1")
                    {
                        frm_StandartKartAc.sinifkodu3 = kod;
                    }
                    else
                    {
                        frm_Stok.sinifkodu4 = kod;
                        frm_StokSinifi.Secili = kod;
                    }
                }
                else if (sira == "5")
                {
                    if (tur == "1")
                    {
                        frm_StandartKartAc.sinifkodu4 = kod;
                    }
                    else
                    {
                        frm_Stok.sinifkodu5 = kod;
                        frm_StokSinifi.Secili = kod;
                    }
                }
                else if (sira == "6")
                {
                    frm_Stok.sinifkodu6 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "7")
                {
                    frm_Stok.sinifkodu7 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "8")
                {
                    frm_Stok.sinifkodu8 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "9")
                {

                    frm_Stok.sinifkodu9 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "10")
                {
                    frm_Stok.sinifkodu10 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "11")
                {
                    frm_Stok.sinifkodu11 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "12")
                {
                    frm_Stok.sinifkodu12 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "13")
                {
                    frm_Stok.sinifkodu13 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "14")
                {
                    frm_Stok.sinifkodu14 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                else if (sira == "15")
                {
                    frm_Stok.sinifkodu15 = kod;
                    frm_StokSinifi.Secili = kod;
                }
                this.Close();
            }
        }
    }
}