using DevExpress.XtraEditors;
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
    public partial class frm_FiyatGir : Form
    {
        string smodel;
        public frm_FiyatGir(string _smodel)
        {
            InitializeComponent();
            smodel = _smodel;
        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring);
        SqlConnectionObject conn = new SqlConnectionObject();
        DataTable fiyatlar = new DataTable();
        public static string sFiyatTipi = "";
        private void frm_FiyatGir_Load(object sender, EventArgs e)
        {
            FiyatCek(smodel, "");
        }

        private void btnFiyatTipiAc_Click(object sender, EventArgs e)
        {
            sFiyatTipi = "";
            frm_Ac_FiyatTipi fiyatTipi = new frm_Ac_FiyatTipi(this.Name.ToString());
            fiyatTipi.ShowDialog();
            txtTipi.Text = sFiyatTipi;
            Fiyatbul(smodel);
            txtYeniFiyat.Enabled = true;
            dteYeniFiyat.Enabled = true;
        }
        public void Fiyatbul(string _sModel)
        {
            string q = "select tbFiyatTipi.sFiyatTipi ,  isnull(lFiyat,0) , isnull(convert(char(10), dteFiyatTespitTarihi, 103), '01/01/1900') " +
                        "from tbFiyatTipi " +
                        "left outer join " +
                        "( select distinct(sFiyatTipi) as sFiyatTipi, lFiyat, dteFiyatTespitTarihi " +
                        "from tbStokFiyati,tbStok " +
                        "Where tbStokFiyati.nStokID = tbStok.nStokID " +
                        "and tbStok.sModel = '" + smodel + "' ) as Fiyat on tbFiyatTipi.sFiyatTipi = Fiyat.sFiyatTipi " +
                        "order by tbFiyatTipi.sFiyatTipi";
            SqlCommand cmd = new SqlCommand(q, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][1].ToString() == txtTipi.Text)
            {
                txtYeniFiyat.Text = dt.Rows[0][0].ToString();
                dteYeniFiyat.DateTime = Convert.ToDateTime(dt.Rows[0]["dteFiyatTespitTarihi"].ToString());
            }
            else
            {

                txtYeniFiyat.Text = "0";
                dteYeniFiyat.DateTime = DateTime.Now;
            }
        }
        public void FiyatCek(string _sModel, string _tipi)
        {
            gridFiyatlar.DataSource = null;
            Dictionary<string, string> fiyat = new Dictionary<string, string>();
            fiyat.Add("@sModel", _sModel);
            fiyat.Add("@sFiyatTipi", _tipi);
            fiyatlar = conn.DfQuery("FK_Select_Fiyat", fiyat);
            gridFiyatlar.DataSource = fiyatlar;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (grpFTipiSec.SelectedIndex.ToString() == "0")
            {
                Dictionary<string, string> FiyatGir = new Dictionary<string, string>();
                FiyatGir.Add("@sModel", smodel);
                FiyatGir.Add("@sFiyatTipi", txtTipi.Text);
                FiyatGir.Add("@lFiyat", txtYeniFiyat.Text);
                FiyatGir.Add("@User", frm_Login.user);
                FiyatGir.Add("@tarih", Convert.ToDateTime(dteYeniFiyat.EditValue).ToString("dd/MM/yyyy"));
                FiyatGir.Add("@ReturnDesc", "");
                var dt = conn.DfInsertBack("FK_insert_Fiyat_Gir", FiyatGir);
                XtraMessageBox.Show(dt.ToString() + " Adet Renk / Beden / Kavala olarak Fiyat oluştu");
                FiyatCek(smodel, "");
                txtTipi.Text = null;
                txtYeniFiyat.Text = null;
                dteYeniFiyat.DateTime = DateTime.Now;


            }
            if (grpFTipiSec.SelectedIndex.ToString() == "1")
            {
                for (int i = 0; i < ViewTopluFiyat.RowCount; i++)
                {
                    Dictionary<string, string> FiyatGir = new Dictionary<string, string>();
                    FiyatGir.Add("@sModel", smodel);
                    FiyatGir.Add("@sFiyatTipi", ViewTopluFiyat.GetRowCellValue(i, "sFiyatTipi").ToString());
                    FiyatGir.Add("@lFiyat", ViewTopluFiyat.GetRowCellValue(i, "YeniFiyat").ToString());
                    FiyatGir.Add("@User", frm_Login.user);
                    FiyatGir.Add("@tarih", ViewTopluFiyat.GetRowCellValue(i, "dteFiyatTespitTarihi").ToString());
                    FiyatGir.Add("@ReturnDesc", "");
                    var dt = conn.DfInsertBack("FK_insert_Fiyat_Gir", FiyatGir);
                }
            }
        }

        private void grpFTipiSec_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (grpFTipiSec.SelectedIndex.ToString() == "0")
            {
                simpleButton4.Text = "Fiyat Gir";
                pnlTopluFiyat.Visible = false;
                pnlTekfiyat.Visible = true;
                txtTipi.Text = null;
                gridFiyatlar.Visible = true;
                gridFiyatlar.Dock = DockStyle.Fill;
            }
            if (grpFTipiSec.SelectedIndex.ToString() == "1")
            {
                simpleButton4.Text = "Fiyatları Güncelle";
                pnlTopluFiyat.Visible = true;
                pnlTekfiyat.Visible = false;
                pnlTopluFiyat.Dock = DockStyle.Fill;
                gridFiyatlar.Visible = false;

                DataTable fiyat_yeni = new DataTable();
                Dictionary<string, string> fiyat = new Dictionary<string, string>();
                fiyat.Add("@sModel", smodel);
                fiyat.Add("@sFiyatTipi", "T");
                fiyat_yeni = conn.DfQuery("FK_Select_Fiyat", fiyat);

                //string Fiyatsql = "select ff.nStokID,t.sFiyatTipi, t.sAciklama,dteFiyatTespitTarihi,lFiyat,0 from tbFiyatTipi t ";
                //Fiyatsql = Fiyatsql + " left join(select f.nStokID,f.lFiyat, f.dteFiyatTespitTarihi, f.sFiyatTipi from tbStokFiyati f ";
                //Fiyatsql = Fiyatsql + "inner join tbstok s on s.nStokID= f.nStokID where s.sModel = isnull('" + txtStokKodu.Text + "','')";
                //Fiyatsql = Fiyatsql + ") ff on ff.sFiyatTipi = t.sFiyatTipi";
                //SqlCommand cmd = new SqlCommand(Fiyatsql, connection);
                //SqlDataAdapter da = new SqlDataAdapter(cmd);
                //if (connection.State == ConnectionState.Closed)
                //{
                //    connection.Open();
                //}
                //da.Fill(fiyat_yeni);
                //connection.Close();
                gridTopluFiyat.DataSource = fiyat_yeni;
            }
        }
    }
}
