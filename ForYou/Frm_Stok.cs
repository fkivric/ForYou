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
    public partial class frm_Stok : Form
    {
        public frm_Stok()
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
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring);
        private void simpleButton18_Click(object sender, EventArgs e)
        {
            btnStandartAc.Enabled = false;
            ultraButton2.Enabled = false;
            ultraTabControl1.Enabled = true;
            panel1.Enabled = true;
            panel8.Enabled = true;
            txtStokKodu.ReadOnly = true;
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
                    btnsnfac1.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "2")
                {
                    lblSinif2.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf2.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac2.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "3")
                {
                    lblSinif3.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf3.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac3.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "4")
                {
                    lblSinif4.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf4.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac4.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "5")
                {
                    lblSinif5.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf5.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac5.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "6")
                {
                    lblSinif6.Visible = true;
                    txtsnf6.Visible = true;
                    btnsnfac6.Visible = true;
                    lblSinif6.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf6.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac6.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif6.Visible = false;
                    txtsnf6.Visible = false;
                    btnsnfac6.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "7")
                {
                    lblSinif7.Visible = true;
                    txtsnf7.Visible = true;
                    btnsnfac7.Visible = true;
                    lblSinif7.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf7.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac7.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif7.Visible = false;
                    txtsnf7.Visible = false;
                    btnsnfac7.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "8")
                {
                    lblSinif8.Visible = true;
                    txtsnf8.Visible = true;
                    btnsnfac8.Visible = true;
                    lblSinif8.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf8.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac8.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif8.Visible = false;
                    txtsnf8.Visible = false;
                    btnsnfac8.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "9")
                {
                    lblSinif9.Visible = true;
                    txtsnf9.Visible = true;
                    btnsnfac9.Visible = true;
                    lblSinif9.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf1.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac9.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif9.Visible = false;
                    txtsnf9.Visible = false;
                    btnsnfac9.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "10")
                {
                    lblSinif10.Visible = true;
                    txtsnf10.Visible = true;
                    btnsnfac10.Visible = true;
                    lblSinif10.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf1.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac10.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif10.Visible = false;
                    txtsnf10.Visible = false;
                    btnsnfac10.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "11")
                {
                    lblSinif11.Visible = true;
                    txtsnf11.Visible = true;
                    btnsnfac11.Visible = true;
                    lblSinif11.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf11.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac11.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif11.Visible = false;
                    txtsnf11.Visible = false;
                    btnsnfac11.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "12")
                {
                    lblSinif12.Visible = true;
                    txtsnf12.Visible = true;
                    btnsnfac12.Visible = true;
                    lblSinif12.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf12.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac12.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif12.Visible = false;
                    txtsnf12.Visible = false;
                    btnsnfac12.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "13")
                {
                    lblSinif13.Visible = true;
                    txtsnf13.Visible = true;
                    btnsnfac13.Visible = true;
                    lblSinif13.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf13.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac13.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif13.Visible = false;
                    txtsnf13.Visible = false;
                    btnsnfac13.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "14")
                {
                    lblSinif14.Visible = true;
                    txtsnf14.Visible = true;
                    btnsnfac14.Visible = true;
                    lblSinif14.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf14.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac14.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif14.Visible = false;
                    txtsnf14.Visible = false;
                    btnsnfac14.Visible = false;
                }
                if (Sinif.Rows[i]["Sira"].ToString() == "15")
                {
                    lblSinif15.Visible = true;
                    txtsnf15.Visible = true;
                    btnsnfac15.Visible = true;
                    lblSinif15.Text = Sinif.Rows[i]["Adi"].ToString();
                    txtsnf15.Text = StkSinif.Rows[0][i].ToString();
                    btnsnfac15.Tag = Sinif.Rows[i]["Sira"].ToString();
                }
                else
                {
                    lblSinif15.Visible = false;
                    txtsnf15.Visible = false;
                    btnsnfac15.Visible = false;
                }
            }


            cmblookup.DisplayMember = "sAciklama";
            cmblookup.ValueMember = "sTemaKodu";

            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select m.sModel,m.sRenk,r.sRenkAdi,t.sTemaKodu from tbModelRenkTema m inner join tbTema t on t.sTemaKodu=m.sTemaKodu inner join tbRenk r on r.sRenk = m.sRenk where sModel = '" + sModel + "'";
            komut.Connection = baglanti2;
            komut.CommandType = CommandType.Text;
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            if (baglanti2.State == ConnectionState.Closed)
            {
                baglanti2.Open();
            }
            adap.Fill(dt);
            baglanti2.Close();
            gridTema.DataSource = dt;
            SqlCommand komut2 = new SqlCommand();
            komut2.CommandText = "select sTemaKodu,sAciklama from tbTema";
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
            cmblookup.DataSource = dt2;
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
            RenkBedenTablo();
            islem();
            txtislem1.Text = islemler.Rows[0][0].ToString();
            txtislem2.Text = islemler.Rows[0][1].ToString();
            txtislem3.Text = islemler.Rows[0][2].ToString();
            txtislem4.Text = islemler.Rows[0][3].ToString();
            //txtislem5.Text = Convert.ToString((int.Parse(islemler.Rows[0][0].ToString()) + int.Parse(islemler.Rows[0][3].ToString())) - (int.Parse(islemler.Rows[0][1].ToString()) + int.Parse(islemler.Rows[0][2].ToString())));
        }
        DataTable islemler = new DataTable();
        void islem()
        {
            string query = "select isnull(abs(sum(lGirisMiktar1* (nGirisCikis -2))),0) , ";
            query = query + " isnull(abs(sum(lGirisMiktar1 * (nGirisCikis - 1))), 0) , ";
            query = query + " isnull(abs(sum(lCikisMiktar1 * (nGirisCikis - 4))), 0) , ";
            query = query + " isnull(abs(sum(lCikisMiktar1 * (nGirisCikis - 3))), 0) ";
            query = query + " from tbStokFisiDetayi with (index(tbStokFisiDetayi_index8)) , tbStok";
            query = query + " where tbStokFisiDetayi.nStokID = tbStok.nStokID and sModel = '" + txtStokKodu.Text + "'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, connection);
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            ad.Fill(islemler);
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            } 
        
        }

        private void Frm_Stok_Load(object sender, EventArgs e)
        {

        }
        string renk = "";
        public static string sinifkodu1;
        public static string sinifkodu2;
        public static string sinifkodu3;
        public static string sinifkodu4;
        public static string sinifkodu5;
        public static string sinifkodu6;
        public static string sinifkodu7;
        public static string sinifkodu8;
        public static string sinifkodu9;
        public static string sinifkodu10;
        public static string sinifkodu11;
        public static string sinifkodu12;
        public static string sinifkodu13;
        public static string sinifkodu14;
        public static string sinifkodu15;

        public void RenkBedenTablo()
        {
            dataGridView1.DataSource = null;
            pnlRenkBedenOlan.Dock = DockStyle.Fill;
            pnlRenkBeden.Visible = false;
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
            var dt = cnn.DfQuery("FK_Select_Stok_Renk_Beden_Kavala_Sec", MM);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoResizeColumns();
        }
        private void simpleButton19_Click(object sender, EventArgs e)
        {
            if (renk != "")
            {
                Frm_Renk frm = new Frm_Renk(KavalaTipi, BedenTipi, renk);
                frm.ShowDialog();
            }
            else
            {
                Frm_Renk frm = new Frm_Renk(KavalaTipi, BedenTipi, "");
                frm.ShowDialog();
            }
            RenkBedenTablo();
        }

        private void ultraTabPageControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ultraButton1_Click(object sender, EventArgs e)
        {
            frm_StandartKartAc kartAc = new frm_StandartKartAc();
            kartAc.ShowDialog();
            txtStokKodu.Text = sModel;
        }

        private void btnStokBul_Click(object sender, EventArgs e)
        {
            frm_StokSec sec = new frm_StokSec();
            sec.ShowDialog();
            txtStokKodu.Text = sModel;

        }
        private void btnsnfac1_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac1.Tag.ToString(),"2");
            frmSinif.ShowDialog();
            txtsnf1.Text = sinifkodu1;
        }

        private void btnsnfac2_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac2.Tag.ToString(),"2");
            frmSinif.ShowDialog();
            txtsnf2.Text = sinifkodu2;
        }

        private void btnsnfac3_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac3.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf3.Text = sinifkodu3;
        }

        private void btnsnfac4_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac4.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf4.Text = sinifkodu4;
        }

        private void btnsnfac5_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac5.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf5.Text = sinifkodu5;
        }

        private void btnsnfac6_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac6.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf6.Text = sinifkodu6;
        }

        private void btnsnfac7_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac7.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf7.Text = sinifkodu7;
        }

        private void btnsnfac8_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac8.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf8.Text = sinifkodu8;
        }

        private void btnsnfac9_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac9.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf9.Text = sinifkodu9;
        }

        private void btnsnfac10_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac10.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf10.Text = sinifkodu10;
        }

        private void btnsnfac11_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac11.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf11.Text = sinifkodu11;
        }

        private void btnsnfac12_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac12.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf12.Text = sinifkodu12;
        }

        private void btnsnfac13_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac13.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf13.Text = sinifkodu13;
        }

        private void btnsnfac14_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac14.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf14.Text = sinifkodu14;
        }

        private void btnsnfac15_Click(object sender, EventArgs e)
        {
            frm_SinifKodu frmSinif = new frm_SinifKodu(btnsnfac15.Tag.ToString(), "2");
            frmSinif.ShowDialog();
            txtsnf15.Text = sinifkodu15;
        }

        private void btnCik_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydetYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnYeni_Click(object sender, EventArgs e)
        {

        }

        private void btnAciklama_Click(object sender, EventArgs e)
        {
            frm_StokAciklama aciklama = new frm_StokAciklama(sModel);
            aciklama.ShowDialog();
        }

        private void btnBarkod_Click(object sender, EventArgs e)
        {
            frm_Barkod barkod = new frm_Barkod(txtStokKodu.Text);
            barkod.ShowDialog();
        }

        private void btnFiyatGir_Click(object sender, EventArgs e)
        {

        }

        private void btnfiyatGor_Click(object sender, EventArgs e)
        {
            frm_FiyatGor gor = new frm_FiyatGor(txtStokKodu.Text);
            gor.ShowDialog();
        }

        private void btnUzunNot_Click(object sender, EventArgs e)
        {
            frm_UzunNot not = new frm_UzunNot(txtStokKodu.Text, txtsAciklama.Text);
            not.ShowDialog();
        }
    }
}
