using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class Frm_Stok : Form
    {
        public Frm_Stok()
        {
            InitializeComponent();
        }

        public static string sRenkKodu = "";
        public static string sModel = "";
        public static string sFiyatTipi = "";

        public static string sinifsira1;
        public static string sinifsira2;
        public static string sinifsira3;
        public static string sinifsira4;
        public static string sinifsira5;
        public static string sinifsira6;
        public static string sinifsira7;
        public static string sinifsira8;
        public static string sinifsira9;
        public static string sinifsira10;
        public static string sinifsira11;
        public static string sinifsira12;


        public static string Fiyatlandirma;
        public static string nFiyatlandirma;
        public static string nStokTipi;
        public static string Beden;
        public static string Kavala;
        public static string BedenTipi;
        public static string KavalaTipi;
        public static bool Renk = false;
        public static int Atturubite;

        string nStokID;

        DataTable KDV = new DataTable();
        DataTable birim1 = new DataTable();
        DataTable birim2 = new DataTable();
        DataTable Otv = new DataTable();
        DataTable Barkod = new DataTable();
        DataTable Urun = new DataTable();
        DataTable Fiyat = new DataTable();
        DataTable Sinif = new DataTable();
        DataTable StkSinif = new DataTable();
        DataTable renkolanlar = new DataTable();

        SqlConnectionObject cnn = new SqlConnectionObject();
        private void simpleButton18_Click(object sender, EventArgs e)
        {
            sModel = txtStokKodu.Text;
            cmbBirim1.DisplayMember = "sAciklama";
            cmbBirim1.ValueMember = "sBirimCinsi";
            cmbBirim2.DisplayMember = "sAciklama";
            cmbBirim2.ValueMember = "sBirimCinsi";
            cmbKDV.DisplayMember = "nKdvOrani";
            cmbKDV.ValueMember = "sKdvTipi";

            birim1 = cnn.DfQuerySpOnly("FK_Select_BirimCinsi");
            birim2 = cnn.DfQuerySpOnly("FK_Select_BirimCinsi");
            KDV = cnn.DfQuerySpOnly("FK_Select_KDV");
            Sinif = cnn.DfQuerySpOnly("FK_Select_SinifKodu");

            Dictionary<string, string> stksnf = new Dictionary<string, string>();
            stksnf.Add("@kod", txtStokKodu.Text);
            StkSinif = cnn.DfQuery("FK_Select_Stok_SinifKodu", stksnf);



            for (int i = 0; i < Sinif.Rows.Count; i++)
            {
                if (Sinif.Rows[i]["Sira"].ToString() == "1")
                {
                    lblSinif1.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf1.Text = StkSinif.Rows[0][i].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "2")
                {
                    lblSinif2.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf2.Text = StkSinif.Rows[0][i].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "3")
                {
                    lblSinif3.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf3.Text = StkSinif.Rows[0][i].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "4")
                {
                    lblSinif4.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf4.Text = StkSinif.Rows[0][i].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "5")
                {
                    lblSinif5.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf5.Text = StkSinif.Rows[0][i].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "6")
                {
                    lblSinif6.Visible = true;
                    txtsnf6.Visible = true;
                    lblSinif6.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf6.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif6.Visible = false;
                    txtsnf6.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "7")
                {
                    lblSinif7.Visible = true;
                    txtsnf7.Visible = true;
                    lblSinif7.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf7.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif7.Visible = false;
                    txtsnf7.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "8")
                {
                    lblSinif8.Visible = true;
                    txtsnf8.Visible = true;
                    lblSinif8.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf8.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif8.Visible = false;
                    txtsnf8.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "9")
                {
                    lblSinif9.Visible = true;
                    txtsnf9.Visible = true;
                    lblSinif9.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf1.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif9.Visible = false;
                    txtsnf9.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "10")
                {
                    lblSinif10.Visible = true;
                    txtsnf10.Visible = true;
                    lblSinif10.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf1.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif10.Visible = false;
                    txtsnf10.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "11")
                {
                    lblSinif11.Visible = true;
                    txtsnf11.Visible = true;
                    lblSinif11.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf11.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif11.Visible = false;
                    txtsnf11.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "12")
                {
                    lblSinif12.Visible = true;
                    txtsnf12.Visible = true;
                    lblSinif12.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf12.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif12.Visible = false;
                    txtsnf12.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "13")
                {
                    lblSinif13.Visible = true;
                    txtsnf13.Visible = true;
                    lblSinif13.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf13.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif13.Visible = false;
                    txtsnf13.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "14")
                {
                    lblSinif14.Visible = true;
                    txtsnf14.Visible = true;
                    lblSinif14.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf14.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif14.Visible = false;
                    txtsnf14.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "15")
                {
                    lblSinif15.Visible = true;
                    txtsnf15.Visible = true;
                    lblSinif15.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf15.Text = StkSinif.Rows[0][i].ToString();
                }
                else
                {
                    lblSinif15.Visible = false;
                    txtsnf15.Visible = false;
                }
            }

            cmbBirim1.DataSource = birim1;
            cmbBirim2.DataSource = birim2;
            cmbKDV.DataSource = KDV;

            Dictionary<string, string> Value = new Dictionary<string, string>();
            Value.Add("@smodel", txtStokKodu.Text);
            var Urun = cnn.DfQuery("FK_Select_Stok", Value);

            renkolanlar.Clear();
            renkolanlar.Columns.Clear();
            renkolanlar.Columns.Add("sBedenTipi");
            renkolanlar.Columns.Add("sKavalaTipi");
            renkolanlar.Columns.Add("sRenk");
            renkolanlar.Columns.Add("sBeden");
            renkolanlar.Columns.Add("sKavala");
            renkolanlar.Columns.Add("sRenkAdi");
            DataRow _ravi = renkolanlar.NewRow();
            nStokID = null;
            if (Urun.Rows.Count > 1)
            {
                for (int i = 0; i < Urun.Rows.Count; i++)
                {
                    if (nStokID != null)
                    {
                        nStokID = nStokID + "-" + Urun.Rows[i]["nStokID"].ToString();
                    }
                    else
                    {
                        nStokID = Urun.Rows[i]["nStokID"].ToString();
                    }
                    var b = Urun.Rows[i]["sBedenTipi"].ToString();
                    var k = Urun.Rows[i]["sKavalaTipi"].ToString();
                    var r = Urun.Rows[i]["sRenk"].ToString();

                    renkolanlar.Rows.Add(new object[] { Urun.Rows[i]["sBedenTipi"].ToString(), Urun.Rows[i]["sKavalaTipi"].ToString(), Urun.Rows[i]["sRenk"].ToString(), Urun.Rows[i]["sBeden"].ToString(), Urun.Rows[i]["sKavala"].ToString(), Urun.Rows[i]["sRenkAdi"].ToString() });
                }
                nStokID = Urun.Rows[0]["nStokID"].ToString();
                KavalaTipi = Urun.Rows[0]["sKavalaTipi"].ToString();
                BedenTipi = Urun.Rows[0]["sBedenTipi"].ToString();
                txtsAciklama.Text = Urun.Rows[0]["sAciklama"].ToString();
                txtKisaAdi.Text = Urun.Rows[0]["sKisaAdi"].ToString();
                cmbBirim1.SelectedItem = Urun.Rows[0]["sBirimCinsi1"].ToString();
                cmbBirim2.SelectedItem = Urun.Rows[0]["sBirimCinsi2"].ToString();
                cmbKDV.SelectedItem = Urun.Rows[0]["sKdvTipi"].ToString();
                lblFiyattipi.Visible = true;
                lblFiyattipi.Text = Urun.Rows[0]["Fiyatlandirma"].ToString();
                lblBeden.Visible = true;
                lblBeden.Text = Urun.Rows[0]["BedenAdi"].ToString();
            }
            else if (Urun.Rows.Count == 1)
            {

                nStokID = Urun.Rows[0]["nStokID"].ToString();
                txtsAciklama.Text = Urun.Rows[0]["sAciklama"].ToString();
                txtKisaAdi.Text = Urun.Rows[0]["sKisaAdi"].ToString();
                cmbBirim1.SelectedItem = Urun.Rows[0]["sBirimCinsi1"].ToString();
                cmbBirim2.SelectedItem = Urun.Rows[0]["sBirimCinsi2"].ToString();
                cmbKDV.SelectedItem = Urun.Rows[0]["sKdvTipi"].ToString();
                lblFiyattipi.Visible = true;
                lblFiyattipi.Text = Urun.Rows[0]["BedenAdi"].ToString();
                lblBeden.Visible = true;
                lblBeden.Text = Urun.Rows[0]["FiyatAdi"].ToString();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
        }

        private void Frm_Stok_Load(object sender, EventArgs e)
        {

        }
        public void RenkBedenTablo()
        {
            dataGridView1.DataSource = null;
            pnlRenkBedenOlan.Dock = DockStyle.Fill;
            pnlRenkBeden.Visible = false;
            string renk = "";
            for (int i = 0; i < renkolanlar.Rows.Count; i++)
            {
                if (renk == "")
                {
                    renk = renkolanlar.Rows[i][2].ToString();
                }
                else if (renk != renkolanlar.Rows[i][2].ToString())
                {
                    renk = renk.ToString() + "," + renkolanlar.Rows[i][2].ToString();
                }
            }
            Dictionary<string, string> MM = new Dictionary<string, string>();
            MM.Add("@smodel", txtStokKodu.Text.Substring(0, 12));
            if (string.IsNullOrEmpty(KavalaTipi) == true)
            {
                MM.Add("@sKavalaTipi", "");
            }
            else
            {
                MM.Add("@sKavalaTipi", KavalaTipi.ToString());
            }
            if (string.IsNullOrEmpty(KavalaTipi) == true)
            {
                MM.Add("@sBedenTipi", "");
            }
            else
            {
                MM.Add("@sBedenTipi", BedenTipi);
            }
            MM.Add("@sRenkKodu", renk);
            var dt = cnn.DfQuery("FK_Select_Renk_Beden_Kavala_Sec", MM);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }
        private void simpleButton19_Click(object sender, EventArgs e)
        {
            Frm_Renk frm = new Frm_Renk(KavalaTipi, BedenTipi);
            frm.ShowDialog();
            RenkBedenTablo();
        }

        private void ultraTabPageControl3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
