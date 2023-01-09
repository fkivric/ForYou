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
    public partial class frm_Barkod : Form
    {
        string smodel;
        public frm_Barkod(string _smodel)
        {
            InitializeComponent();
            smodel = _smodel;
        }
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring);
        SqlConnectionObject cnn = new SqlConnectionObject();
        public static string nfirmaId;
        DataTable Barkod = new DataTable();
        DataTable nStokID = new DataTable();
        private void frm_Barkod_Load(object sender, EventArgs e)
        {
            Stok();
        }
        void Stok()
        {
            cmbsKodu.DisplayMember = "sAciklama";
            cmbsKodu.ValueMember = "nStokID";
            Dictionary<string, string> stoklar = new Dictionary<string, string>();
            stoklar.Add("@sModel", smodel);
            nStokID = cnn.DfQuery("FK_Select_Barkod", stoklar);
            
            //string query = "select s.nStokID, sAciklama = rtrim(ltrim(s.sKodu)) + ' - ' + s.sAciklama + ' / ' + r.sRenk + ' ' +r.sRenkAdi ";
            //query = query + " from tbStokBarkodu b inner join .dbo.tbStok s on s.nStokID = b.nStokID ";
            //query = query + " inner join .dbo.tbRenk r on r.sRenk = s.sRenk where s.sModel = '" + smodel + "'";
            //System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, connection);
            //connection.Open();
            //System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            //ad.Fill(nStokID);
            //connection.Close();
            cmbsKodu.DataSource = nStokID;
        }
        private void barkod()
        {
            Barkod.Clear();
            string query = "select b.nStokID,sBarkod,(select sKodu from tbfirma f where f.nFirmaID = b.nFirmaID) as sFirmaKodu,sKarsiStokKodu,sKarsiStokAciklama from tbStokBarkodu b ";
            query = query + " inner join .dbo.tbStok s on s.nStokID = b.nStokID";
            query = query + " where s.nStokID = '" + cmbsKodu.SelectedValue+"'";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, connection);
            connection.Open();
            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            ad.Fill(Barkod);
            connection.Close();
            gridBarkod.DataSource = Barkod;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_FirmaBul bul = new frm_FirmaBul();
            bul.ShowDialog();
            txtFirma.Text = nfirmaId;
        }

        private void btnBarkodIslem_Click(object sender, EventArgs e)
        {
            Barkod.Rows.Add(new object[] { cmbsKodu.SelectedValue, txtBarkod.Text, txtFirma.Text, txtFirmaStokKod.Text, txtFirmaStokAd.Text });
            gridBarkod.DataSource = null;
            gridBarkod.DataSource = Barkod;
            cmbsKodu.Enabled = false;
            if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
            {
                DialogResult dialogResult = MessageBox.Show("حفظ الرمز الشريطي الذي تم إدخاله؟ خلاف ذلك يمكن حذفه", "الانتباه", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < ViewBarkod.RowCount; i++)
                    {
                        Dictionary<string, string> brk = new Dictionary<string, string>();
                        brk.Add("@nStokID", ViewBarkod.GetRowCellValue(i, "nStokID").ToString().Replace(" ", ""));
                        brk.Add("@sbarkod", ViewBarkod.GetRowCellValue(i, "sBarkod").ToString().Replace(" ", ""));
                        brk.Add("@nFirmaID", ViewBarkod.GetRowCellValue(i, "sFirmaKodu").ToString().Replace(" ", ""));
                        brk.Add("@sKarsiStokKodu", ViewBarkod.GetRowCellValue(i, "sKarsiStokKodu").ToString().Replace(" ", ""));
                        brk.Add("@sKarsiStokAciklama", ViewBarkod.GetRowCellValue(i, "sKarsiStokAciklama").ToString().Replace(" ", ""));
                        cnn.DfQuery("FK_insert_Barkod", brk);
                        cmbsKodu.Enabled = true;
                    }
                }
                else
                {
                    DialogResult dialogResult2 = MessageBox.Show("احتفظ بالباركود الذي تم إدخاله؟", "الانتباه", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.No)
                    {
                        DataRow[] result = Barkod.Select("sBarkod = '" + txtBarkod.Text + "'");
                        foreach (DataRow row in result)
                        {
                            if (row["sBarkod"].ToString().Trim().ToUpper().Contains(txtBarkod.Text))
                                Barkod.Rows.Remove(row);
                        }
                        cmbsKodu.Enabled = true;
                    }
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Girilen barkod kaydedilsin mi? Aksi takdirde silinebilir", "Dikkat", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    for (int i = 0; i < ViewBarkod.RowCount; i++)
                    {
                        Dictionary<string, string> brk = new Dictionary<string, string>();
                        brk.Add("@nStokID", ViewBarkod.GetRowCellValue(i, "nStokID").ToString().Replace(" ",""));
                        brk.Add("@sbarkod", ViewBarkod.GetRowCellValue(i, "sBarkod").ToString().Replace(" ", ""));
                        brk.Add("@nFirmaID", ViewBarkod.GetRowCellValue(i, "sFirmaKodu").ToString().Replace(" ", ""));
                        brk.Add("@sKarsiStokKodu", ViewBarkod.GetRowCellValue(i, "sKarsiStokKodu").ToString().Replace(" ", ""));
                        brk.Add("@sKarsiStokAciklama", ViewBarkod.GetRowCellValue(i, "sKarsiStokAciklama").ToString().Replace(" ", ""));
                        cnn.DfQuery("FK_insert_Barkod", brk);
                        cmbsKodu.Enabled = true;
                    }
                }
                else
                {
                    DialogResult dialogResult2 = MessageBox.Show("Girilen barkod kalsın mi?", "Dikkat", MessageBoxButtons.YesNo);
                    if (dialogResult2 == DialogResult.No)
                    {
                        DataRow[] result = Barkod.Select("sBarkod = '" + txtBarkod.Text + "'");
                        foreach (DataRow row in result)
                        {
                            if (row["sBarkod"].ToString().Trim().ToUpper().Contains(txtBarkod.Text))
                                Barkod.Rows.Remove(row);
                        }
                        cmbsKodu.Enabled = true;
                    }
                }
            }
            txtBarkod.Text = "";
            txtFirma.Text = "";
            txtFirmaStokKod.Text = "";
            txtFirmaStokAd.Text = "";
        }
        private void btnBarkodSil_Click(object sender, EventArgs e)
        {
            if (secili != "")
            {
                DataRow[] result = Barkod.Select("sBarkod = '" + secili + "'");
                foreach (DataRow row in result)
                {
                    if (row["sBarkod"].ToString().Trim().ToUpper().Contains(secili))
                        Barkod.Rows.Remove(row);
                }
            }
            else
            {
                if (Thread.CurrentThread.CurrentUICulture.IetfLanguageTag == "ar-AR")
                {
                    MessageBox.Show("حدد الرمز الشريطي المراد حذفه", "Dikkat");
                }
                else
                {
                    MessageBox.Show("Silinecek barkodu seçin", "Dikkat");
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void cmbsKodu_SelectedIndexChanged(object sender, EventArgs e)
        {
            barkod();
        }
        void Yeni()
        {
            txtBarkod.Text = "";
            txtFirma.Text = "";
            txtFirmaStokKod.Text = "";
            txtFirmaStokAd.Text = "";
            btnBarkodIslem.Text = "Ekle";
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Yeni();
        }
        string secili = "";
        private void ViewBarkod_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            secili = ViewBarkod.GetRowCellValue(e.RowHandle, "sBarkod").ToString();
        }
    }
}
