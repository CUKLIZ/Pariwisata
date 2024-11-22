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

namespace Pariwisata
{
    public partial class AdminPesanan : Form
    {
        public AdminPesanan()
        {
            InitializeComponent();

            DataTampil();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataTampil()
        {
            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("SELECT P.IdPelanggan, PL.Nama, P.IdPesanan, P.IdLokasi, P.JumlahTiket, P.TotalHarga, P.Status " +
                                                    "FROM Pesanan P " +
                                                    "INNER JOIN Pelangan PL ON P.IdPelanggan = PL.IdPelanggan", conn);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dataGridView1.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally
            {
                conn.Close();
            }            
        }
    }
}
