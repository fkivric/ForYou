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
    public partial class frm_BedenTipi : Form
    {
        public frm_BedenTipi()
        {
            InitializeComponent();
        }
        public static string sBedenTipi;
        SqlConnection Sql = new SqlConnection(Properties.Settings.Default.connectionstring);
        SqlConnectionObject cnn = new SqlConnectionObject();
        private void Frm_BedenTipi_Load(object sender, EventArgs e)
        {
            txt1.Properties.ReadOnly = true;
            txt2.Properties.ReadOnly = true;
            txt3.Properties.ReadOnly = true;
            txt4.Properties.ReadOnly = true;
            txt5.Properties.ReadOnly = true;
            txt6.Properties.ReadOnly = true;
            txt7.Properties.ReadOnly = true;
            txt8.Properties.ReadOnly = true;
            txt9.Properties.ReadOnly = true;
            txt10.Properties.ReadOnly = true;
            txt13.Properties.ReadOnly = true;
            txt12.Properties.ReadOnly = true;
            txt11.Properties.ReadOnly = true;
            txt14.Properties.ReadOnly = true;
            txt15.Properties.ReadOnly = true;
            textBox1.ReadOnly = true;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            txt1.Properties.ReadOnly = false;
            txt2.Properties.ReadOnly = false;
            txt3.Properties.ReadOnly = false;
            txt4.Properties.ReadOnly = false;
            txt5.Properties.ReadOnly = false;
            txt6.Properties.ReadOnly = false;
            txt7.Properties.ReadOnly = false;
            txt8.Properties.ReadOnly = false;
            txt9.Properties.ReadOnly = false;
            txt10.Properties.ReadOnly = false;
            txt13.Properties.ReadOnly = false;
            txt12.Properties.ReadOnly = false;
            txt11.Properties.ReadOnly = false;
            txt14.Properties.ReadOnly = false;
            txt15.Properties.ReadOnly = false;
            textBox1.ReadOnly = false;

            if (txtsBedenTipi.Text != "")
            {
                SqlConnection baglanti2 = new SqlConnection();
                baglanti2.ConnectionString = Properties.Settings.Default.connectionstring;
                SqlCommand komut2 = new SqlCommand();
                komut2.CommandText = "select  * from tbBedenTipi where sBedenTipi = '" + txtsBedenTipi.Text + "'";
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

                if (dt2.Rows.Count >= 1)
                {
                    textBox1.Text = dt2.Rows[0][1].ToString();
                    txt1.Text = dt2.Rows[0][2].ToString();
                    txt2.Text = dt2.Rows[0][3].ToString();
                    txt3.Text = dt2.Rows[0][4].ToString();
                    txt4.Text = dt2.Rows[0][5].ToString();
                    txt5.Text = dt2.Rows[0][6].ToString();
                    txt6.Text = dt2.Rows[0][7].ToString();
                    txt7.Text = dt2.Rows[0][8].ToString();
                    txt8.Text = dt2.Rows[0][9].ToString();
                    txt9.Text = dt2.Rows[0][10].ToString();
                    txt10.Text = dt2.Rows[0][11].ToString();
                    txt11.Text = dt2.Rows[0][12].ToString();
                    txt12.Text = dt2.Rows[0][13].ToString();
                    txt13.Text = dt2.Rows[0][14].ToString();
                    txt14.Text = dt2.Rows[0][15].ToString();
                    txt15.Text = dt2.Rows[0][16].ToString();
                }               
            }
            else
            {

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Ac_BedenTipiAktif aktif = new frm_Ac_BedenTipiAktif();
            aktif.ShowDialog();
            txtsBedenTipi.Text = sBedenTipi;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtsBedenTipi.Text != "")
            {
                if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
                {
                    DialogResult dialogResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف", "الانتباه", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand query = new SqlCommand("delete from tbBedenTipi where sBedenTipi = '@bedentipi'");
                        query.Parameters.AddWithValue("@bedentipi", txtsBedenTipi.Text);
                        query.ExecuteNonQuery();
                        Yeni();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Silmek istediğinize eminmisiniz", "Dikkat", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlCommand query = new SqlCommand("delete from tbBedenTipi where sBedenTipi = '@bedentipi'");
                        query.Parameters.AddWithValue("@bedentipi", txtsBedenTipi.Text);
                        query.ExecuteNonQuery();
                        Yeni();
                    }
                }
            }
        }
        void Yeni()
        {
            txt1.Properties.ReadOnly = true;
            txt2.Properties.ReadOnly = true;
            txt3.Properties.ReadOnly = true;
            txt4.Properties.ReadOnly = true;
            txt5.Properties.ReadOnly = true;
            txt6.Properties.ReadOnly = true;
            txt7.Properties.ReadOnly = true;
            txt8.Properties.ReadOnly = true;
            txt9.Properties.ReadOnly = true;
            txt10.Properties.ReadOnly = true;
            txt13.Properties.ReadOnly = true;
            txt12.Properties.ReadOnly = true;
            txt11.Properties.ReadOnly = true;
            txt14.Properties.ReadOnly = true;
            txt15.Properties.ReadOnly = true;
            textBox1.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = "";
            txt12.Text = "";
            txt13.Text = "";
            txt14.Text = "";
            txt15.Text = "";
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            txt1.Properties.ReadOnly = true;
            txt2.Properties.ReadOnly = true;
            txt3.Properties.ReadOnly = true;
            txt4.Properties.ReadOnly = true;
            txt5.Properties.ReadOnly = true;
            txt6.Properties.ReadOnly = true;
            txt7.Properties.ReadOnly = true;
            txt8.Properties.ReadOnly = true;
            txt9.Properties.ReadOnly = true;
            txt10.Properties.ReadOnly = true;
            txt13.Properties.ReadOnly = true;
            txt12.Properties.ReadOnly = true;
            txt11.Properties.ReadOnly = true;
            txt14.Properties.ReadOnly = true;
            txt15.Properties.ReadOnly = true;
            textBox1.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txt7.Text = "";
            txt8.Text = "";
            txt9.Text = "";
            txt10.Text = "";
            txt11.Text = ""; 
            txt12.Text = "";
            txt13.Text = "";
            txt14.Text = "";
            txt15.Text = "";
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> beden = new Dictionary<string, string>();
            beden.Add("@sBedenTipi", txtsBedenTipi.Text);
            beden.Add("@sAciklama", textBox1.Text);
            beden.Add("@sBeden1", txt1.Text);
            beden.Add("@sBeden2", txt2.Text);
            beden.Add("@sBeden3", txt3.Text);
            beden.Add("@sBeden4", txt4.Text);
            beden.Add("@sBeden5", txt5.Text);
            beden.Add("@sBeden6", txt6.Text);
            beden.Add("@sBeden7", txt7.Text);
            beden.Add("@sBeden8", txt8.Text);
            beden.Add("@sBeden9", txt9.Text);
            beden.Add("@sBeden10", txt10.Text);
            beden.Add("@sBeden11", txt11.Text);
            beden.Add("@sBeden12", txt12.Text);
            beden.Add("@sBeden13", txt13.Text);
            beden.Add("@sBeden14", txt14.Text);
            beden.Add("@sBeden15", txt15.Text);
            cnn.DfInsert("FK_insert_BedenTipi", beden);
            Yeni();
        }
    }
}
