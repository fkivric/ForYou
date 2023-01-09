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
    public partial class Frm_RenkTipi : Form
    {
        public Frm_RenkTipi()
        {
            InitializeComponent();
        }
        public static string sRenk;
        SqlConnectionObject cnn = new SqlConnectionObject();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_RenkSec sec = new frm_RenkSec();
            sec.ShowDialog();
            txtRenkKodu.Text = sRenk; 
        }
        void Yeni()
        {
            txtAciklama.ReadOnly = true;
            txtAciklama.Text = "";
            txtRenkKodu.Text = "";
            colorPickEdit1.ReadOnly = true;
            colorPickEdit1.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String hexColor2 = System.Drawing.ColorTranslator.ToHtml(Color.FromArgb(colorPickEdit1.Color.A, colorPickEdit1.Color.R, colorPickEdit1.Color.G, colorPickEdit1.Color.B));  //returns the hex value


            var color2 = int.Parse(hexColor2.Replace("#", ""), System.Globalization.NumberStyles.HexNumber);

            Dictionary<string, string> renk = new Dictionary<string, string>();
            renk.Add("@sDil", Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
            renk.Add("@sRenk", txtRenkKodu.Text);
            renk.Add("@sRenkAdi", txtAciklama.Text);
            renk.Add("@lRenkNo", color2.ToString());
            renk.Add("@ReturnDesc", "");
            var dt = cnn.DfQuery("FK_insert_Renk", renk);
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
            {
                DialogResult dialogResult = MessageBox.Show(dt.Rows[0][0].ToString(), "الانتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Yeni();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(dt.Rows[0][0].ToString(), "Dikkat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Yeni();
                }
            }
        }

        private string hexValue;
        private int decValue;
        private void btnGoster_Click(object sender, EventArgs e)
        {
            txtAciklama.ReadOnly = false;
            colorPickEdit1.ReadOnly = false;
            Dictionary<string, string> renk = new Dictionary<string, string>();
            renk.Add("@sRenk", txtRenkKodu.Text);
            var dt = cnn.DfQuery("FK_Select_Renk", renk);
            txtAciklama.Text = dt.Rows[0]["sRenkAdi"].ToString();
            var dd = dt.Rows[0]["lRenkNo"].ToString();
            decValue = int.Parse(dt.Rows[0]["lRenkNo"].ToString(), System.Globalization.NumberStyles.Integer);
            hexValue = decValue.ToString("X");

            Color rgb = System.Drawing.ColorTranslator.FromHtml("#" + hexValue);
            colorPickEdit1.Color = rgb;
        }


        private void btnYeniRenkAc_Click(object sender, EventArgs e)
        {
            var yeni = cnn.DfQuerySpOnly("FK_select_New_Renk_Kodu");
            txtRenkKodu.Text = yeni.Rows[0][0].ToString();
            txtAciklama.ReadOnly = false;
            colorPickEdit1.ReadOnly = false;
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void Frm_RenkTipi_Load(object sender, EventArgs e)
        {

        }
    }
}
