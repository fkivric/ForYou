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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-AR");
            InitializeComponent();
        }
        SqlConnectionObject cnn = new SqlConnectionObject();
        SqlConnection conn = new SqlConnection();
        string sunuc = "185.184.26.243";
        string databas = "ForYou";
        public static string user = "";
        public static string password = "";
        
        private void FRm_Login_Load(object sender, EventArgs e)
        {
        }


        private void dropDownButton1_Click(object sender, EventArgs e)
        {
            switch (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag)
            {
                case "tr-TR": Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar-AR"); break;
                case "tr_TR": dropDownButton1.Text = "Türkçe"; break;
                case "ar-AR": Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("tr-TR"); break;
            }
            this.Controls.Clear();
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            user = txtUserName.Text;
            password = txtPassword.Text;
            string BaglantiAdresi = "Server="+sunuc+";Database="+databas+";User Id="+user.ToLower()+";Password="+password+"; connection timeout=30;";
            SqlConnection Baglanti = new SqlConnection();
            Baglanti.ConnectionString = BaglantiAdresi;
            Baglanti.Open();
            if (Baglanti.State == ConnectionState.Open)
            {
                this.Hide();
                Frm_Main main = new Frm_Main();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bilgileri kontrol ediniz");
            }
            this.Close();
            this.Dispose();
        }

        private void frm_Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                this.Close();
                this.Dispose();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                this.Close();
                this.Dispose();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }

            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
                this.Close();
                this.Dispose();
            }
        }
    }
}
