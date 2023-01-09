using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class frm_Ac_StokSinifi : Form
    {
        public frm_Ac_StokSinifi()
        {
            InitializeComponent();
        }
        SqlConnectionObject cnn = new SqlConnectionObject();
        private void frm_StokSinifi_Load(object sender, EventArgs e)
        {
            cmbSinif.DisplayMember = "Adi";
            cmbSinif.ValueMember = "Sira";

            var Sinif = cnn.DfQuerySpOnly("FK_Select_SinifKodu");
            cmbSinif.DataSource = Sinif;
        }
        public static string Secili;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Ac_SinifKodu frm = new frm_Ac_SinifKodu(cmbSinif.SelectedValue.ToString(), "3");
            frm.ShowDialog();
            textEdit1.Text = Secili;
        }
        void Yeni()
        {
            cmbSinif.Enabled = true;
            textEdit1.ReadOnly = false;
            textEdit2.ReadOnly = true;
            textEdit1.Text = "";
            textEdit2.Text = "";
            simpleButton1.Enabled = true;
            simpleButton2.Enabled = true;
        }
        void Sil()
        {
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "delete from tbSSinif" + cmbSinif.SelectedValue + " where sSinifKodu = '" + textEdit1.Text + "'";
            komut.Connection = baglanti2;
            komut.CommandType = CommandType.Text;
            baglanti2.Open();
            komut.ExecuteNonQuery();
            baglanti2.Close();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textEdit2.ReadOnly = false;
            SqlConnection baglanti2 = new SqlConnection();
            baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "select replace(sAciklama,' ','') from tbSsinif" + cmbSinif.SelectedValue.ToString() + " where sSinifKodu = '" + textEdit1.Text + "'";
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
            if (dt.Rows.Count>0)
            {
                textEdit2.Text = dt.Rows[0][0].ToString();
            }
            cmbSinif.Enabled = false;
            textEdit1.ReadOnly = true;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> kaydet = new Dictionary<string, string>();
            kaydet.Add("@sira", cmbSinif.SelectedValue.ToString());
            kaydet.Add("@sinifkodu", textEdit1.Text);
            kaydet.Add("@aciklama", textEdit2.Text);
            var snc = cnn.DfQuery("FK_insert_StokSinif", kaydet);

            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
            {
                MessageBox.Show(snc.Rows[1][0].ToString(), snc.Rows[1][1].ToString(), MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show(snc.Rows[0][0].ToString(), snc.Rows[0][1].ToString(), MessageBoxButtons.OK);
            }
            Yeni();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
            {
                DialogResult dialogResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف؟", "الانتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Sil();
                    Yeni();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğine emin misin?", "Dikket", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Sil();
                    Yeni();
                }
            }
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }
    }
}
