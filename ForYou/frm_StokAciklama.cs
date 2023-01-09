using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForYou
{
    public partial class frm_StokAciklama : Form
    {
        SqlConnectionObject conn = new SqlConnectionObject();
        string smodel;
        public frm_StokAciklama(string _smodel)
        {
            InitializeComponent();
            smodel = _smodel; 
        }

        private void frm_StokAciklama_Load(object sender, EventArgs e)
        {
            Sec();
        }
        void Yeni()
        {
            txtAciklama1.Text = "";
            txtAciklama2.Text = "";
            txtAciklama3.Text = "";
            txtAciklama4.Text = "";
            txtAciklama5.Text = "";
            txtAciklama6.Text = "";
            txtAciklama7.Text = "";
            txtAciklama8.Text = "";
            txtAciklama9.Text = "";
            txtAciklama10.Text = "";
        }
        void Sec()
        {
            Dictionary<string, string> key = new Dictionary<string, string>();
            key.Add("@smodel", smodel);
            var dt = conn.DfQuery("FK_Select_Stok_Aciklama", key);
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                if (i == 1)
                {
                    txtAciklama1.Text = dt.Rows[0][i].ToString();
                }
                if (i == 2)
                {
                    txtAciklama2.Text = dt.Rows[0][i].ToString();

                }
                if (i == 3)
                {
                    txtAciklama3.Text = dt.Rows[0][i].ToString();
                }
                if (i == 4)
                {
                    txtAciklama4.Text = dt.Rows[0][i].ToString();
                }
                if (i == 5)
                {
                    txtAciklama5.Text = dt.Rows[0][i].ToString();
                }
                if (i == 6)
                {
                    txtAciklama6.Text = dt.Rows[0][i].ToString();
                }
                if (i == 7)
                {
                    txtAciklama7.Text = dt.Rows[0][i].ToString();
                }
                if (i == 8)
                {
                    txtAciklama8.Text = dt.Rows[0][i].ToString();
                }
                if (i == 9)
                {
                    txtAciklama9.Text = dt.Rows[0][i].ToString();
                }
                if (i == 10)
                {
                    txtAciklama10.Text = dt.Rows[0][i].ToString();
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> value = new Dictionary<string, string>();
            value.Add("@smodel", smodel);
            value.Add("@sAciklama1 ", txtAciklama1.Text);
            value.Add("@sAciklama2 ", txtAciklama2.Text);
            value.Add("@sAciklama3 ", txtAciklama3.Text);
            value.Add("@sAciklama4 ", txtAciklama4.Text);
            value.Add("@sAciklama5 ", txtAciklama5.Text);
            value.Add("@sAciklama6 ", txtAciklama6.Text);
            value.Add("@sAciklama7 ", txtAciklama7.Text);
            value.Add("@sAciklama8 ", txtAciklama8.Text);
            value.Add("@sAciklama9 ", txtAciklama9.Text);
            value.Add("@sAciklama10", txtAciklama10.Text);
            conn.DfInsert("FK_insert_Stok_Aciklama", value);
            Yeni();
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
            {
                DialogResult dialogResult = MessageBox.Show("سيتم حذف جميع التعليقات هل أنت متأكد", "الانتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Dictionary<string, string> sil = new Dictionary<string, string>();
                    sil.Add("@smodel", smodel);
                    conn.DfQuery("FK_delete_Stok_Aciklama", sil);

                }
            }
            else
            {
                DialogResult dialogResult2 = MessageBox.Show("Tüm Açıklamalar silinecek Eminmisiniz", "Dikkat", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    Dictionary<string, string> sil = new Dictionary<string, string>();
                    sil.Add("@smodel", smodel);
                    conn.DfQuery("FK_delete_Stok_Aciklama", sil);
                }
            }
            Yeni();
        }
    }
}
