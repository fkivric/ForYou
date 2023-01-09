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
    public partial class frm_UzunNot : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring);
        DataTable not = new DataTable();
        string smodel;
        string sadi;
        public frm_UzunNot(string _smodel, string _sadi)
        {
            InitializeComponent();
            smodel = _smodel;
            sadi = _sadi;
        }

        private void frm_UzunNot_Load(object sender, EventArgs e)
        {
            ultraLabel1.Text = smodel;
            ultraLabel2.Text = sadi;
            string query = "select sUzunNot  as [not] from tbStokUzunNot where sModel = '" + smodel + "' union select '' as [not] order by 1 desc";
            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, connection);
            connection.Open();
            System.Data.SqlClient.SqlDataAdapter ad = new System.Data.SqlClient.SqlDataAdapter(cmd);
            ad.Fill(not);
            connection.Close();
            if (not.Rows.Count>0)
            {
                richTextBox1.Text = not.Rows[0][0].ToString();
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connectionstring))
            {
                String query = "insert into tbStokUzunNot values ('@smodel','@sNot','@User',GETDATE())";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@smodel", smodel);
                    command.Parameters.AddWithValue("@sNot", richTextBox1.Text);
                    command.Parameters.AddWithValue("@User", frm_Login.user);
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check Error
                    if (result < 0)
                        Console.WriteLine("Error inserting data into Database!");
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                using(var cmd = connection.CreateCommand())
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    cmd.CommandText = "delete tbStokUzunNot where sModel = '@smodel'";
                    cmd.Parameters.AddWithValue("@smodel", smodel);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
