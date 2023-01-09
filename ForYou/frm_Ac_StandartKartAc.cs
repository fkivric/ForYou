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

namespace ForYou
{
    public partial class frm_Ac_StandartKartAc : DevExpress.XtraEditors.XtraForm
    {
        public frm_Ac_StandartKartAc()
        {
            InitializeComponent();
        }
        SqlConnectionObject conn = new SqlConnectionObject();
        public static string sinifkodu1;
        public static string sinifkodu2;
        public static string sinifkodu3;
        public static string sinifkodu4;
        string KontrolKod = "";
        string NewStokKodu = "";
        private void frm_StandartKartAc_Load(object sender, EventArgs e)
        {
            var dt = conn.DfQuerySpOnly("FK_Select_Standart_Stok");

            textEdit1.Text = dt.Rows[0][1].ToString();
            textEdit1.Tag = dt.Rows[0][2].ToString();
            textEdit3.Text = dt.Rows[1][1].ToString();
            textEdit3.Tag = dt.Rows[1][2].ToString();
            textEdit5.Text = dt.Rows[2][1].ToString();
            textEdit5.Tag = dt.Rows[2][2].ToString();
            textEdit7.Text = dt.Rows[3][1].ToString();
            textEdit7.Tag = dt.Rows[3][2].ToString();

            //------------sira not----------------//
            textEdit2.Tag = dt.Rows[0][0].ToString();
            textEdit4.Tag = dt.Rows[1][0].ToString();
            textEdit6.Tag = dt.Rows[2][0].ToString();
            textEdit8.Tag = dt.Rows[3][0].ToString();
        }

        private void btnac1_Click(object sender, EventArgs e)
        {
            frm_Ac_SinifKodu frmSinif = new frm_Ac_SinifKodu(textEdit2.Tag.ToString(),"1");
            frmSinif.ShowDialog();
            textEdit2.Text = sinifkodu1;
        }

        private void btnac2_Click(object sender, EventArgs e)
        {
            frm_Ac_SinifKodu frmSinif = new frm_Ac_SinifKodu(textEdit4.Tag.ToString(), "1");
            frmSinif.ShowDialog();
            textEdit4.Text = sinifkodu2;
        }

        private void btnac3_Click(object sender, EventArgs e)
        {
            frm_Ac_SinifKodu frmSinif = new frm_Ac_SinifKodu(textEdit6.Tag.ToString(), "1");
            frmSinif.ShowDialog();
            textEdit6.Text = sinifkodu3;
        }

        private void btnac4_Click(object sender, EventArgs e)
        {
            frm_Ac_SinifKodu frmSinif = new frm_Ac_SinifKodu(textEdit8.Tag.ToString(), "1");
            frmSinif.ShowDialog();
            textEdit8.Text = sinifkodu4;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            groupControl2.Enabled = true;
            var dt = conn.DfQuerySpOnly("FK_Select_Standart_Stok_KodAc");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i][0].ToString() == textEdit2.Tag.ToString())
                {
                    KontrolKod = KontrolKod + textEdit2.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString()) - 1, 1);
                }
                else if (dt.Rows[i][0].ToString() == textEdit4.Tag.ToString())
                {
                    KontrolKod = KontrolKod + textEdit4.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString()) - 1, 1);
                }
                else if (dt.Rows[i][0].ToString() == textEdit6.Tag.ToString())
                {
                    KontrolKod = KontrolKod + textEdit6.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString()) - 1, 1);
                }
                else if (dt.Rows[i][0].ToString() == textEdit8.Tag.ToString())
                {
                    KontrolKod = KontrolKod + textEdit8.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString()) - 1, 1);
                }
            }
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", KontrolKod);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            textEdit10.Text = ilk.Rows[0][0].ToString();
        }
        string kod1 = "";
        string kod2 = "";
        string kod3 = "";
        string kod4 = "";
        string kod5 = "";
        private void textEdit10_EditValueChanged(object sender, EventArgs e)
        {
            kod1 = KontrolKod + textEdit10.Text;
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", kod1);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            textEdit12.Text = ilk.Rows[0][1].ToString();
        }
        private void textEdit12_EditValueChanged(object sender, EventArgs e)
        {
            kod2 = kod1 + textEdit12.Text;
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", kod2);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            textEdit14.Text = ilk.Rows[0][2].ToString();
        }

        private void textEdit14_EditValueChanged(object sender, EventArgs e)
        {
            kod3 = kod2 + textEdit14.Text;
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", kod3);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            textEdit16.Text = ilk.Rows[0][3].ToString();
        }

        private void textEdit16_EditValueChanged(object sender, EventArgs e)
        {
            kod4 = kod3 + textEdit16.Text;
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", kod4);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            int son = int.Parse(ilk.Rows[0][4].ToString());
            son++;
            textEdit18.Text = son.ToString();
        }

        private void textEdit18_EditValueChanged(object sender, EventArgs e)
        {
            kod5 = kod4 + textEdit18.Text;
            Dictionary<string, string> kontrol = new Dictionary<string, string>();
            kontrol.Add("@sModel", kod5);
            var ilk = conn.DfQuery("FK_Select_Stok_Kontrol", kontrol);
            textEdit20.Text = ilk.Rows[0][5].ToString();
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (textEdit2.Text == "")
            {
                XtraMessageBox.Show("Sınıf kodu 1 Boş olamaz");
            }
            else if (textEdit4.Text == "")
            {
                XtraMessageBox.Show("Sınıf kodu 2 Boş olamaz");
            }
            else if (textEdit6.Text == "")
            {
                XtraMessageBox.Show("Sınıf kodu 3 Boş olamaz");
            }
            else if (textEdit8.Text == "")
            {
                XtraMessageBox.Show("Sınıf kodu 4 Boş olamaz");
            }
            else if (textEdit10.Text == "")
            {
                XtraMessageBox.Show("7. Karekter Boş olamaz");
            }
            else if (textEdit12.Text == "")
            {
                XtraMessageBox.Show("8. Karekter Boş olamaz");
            }
            else if (textEdit14.Text == "")
            {
                XtraMessageBox.Show("9. Karekter Boş olamaz");
            }
            else if (textEdit16.Text == "")
            {
                XtraMessageBox.Show("10. Karekter Boş olamaz");
            }
            else if (textEdit18.Text == "")
            {
                XtraMessageBox.Show("11. Karekter Boş olamaz");
            }
            else if (textEdit20.Text == "")
            {
                XtraMessageBox.Show("12. Karekter Boş olamaz");
            }
            else
            {
                var dt = conn.DfQuerySpOnly("FK_Select_Standart_Stok_KodAc");

                int a1 = 0;
                int a2 = 0;
                int a3 = 0;
                int a4 = 0;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0].ToString() == textEdit2.Tag.ToString())
                    {
                        NewStokKodu = NewStokKodu + textEdit2.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString())-1,1);
                        a1++;
                    }
                    else if (dt.Rows[i][0].ToString() == textEdit4.Tag.ToString())
                    {
                        NewStokKodu = NewStokKodu + textEdit4.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString())-1,1);
                        a2++;
                    }
                    else if (dt.Rows[i][0].ToString() == textEdit6.Tag.ToString())
                    {
                        NewStokKodu = NewStokKodu + textEdit6.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString())-1,1);
                        a3++;
                    }
                    else if (dt.Rows[i][0].ToString() == textEdit8.Tag.ToString())
                    {
                        NewStokKodu = NewStokKodu + textEdit8.Text.ToString().Substring(int.Parse(dt.Rows[i][2].ToString())-1,1);
                        a4++;
                    }
                }
                NewStokKodu = NewStokKodu + textEdit10.Text + textEdit12.Text + textEdit14.Text + textEdit16.Text + textEdit18.Text + textEdit20.Text;
                frm_Stok.sModel = NewStokKodu;
                this.Close();
            }

        }

    }
}