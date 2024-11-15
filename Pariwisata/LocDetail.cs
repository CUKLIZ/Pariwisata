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
using System.Globalization; 

namespace Pariwisata
{
    public partial class LocDetail : Form
    {
        private int idLokasi;
        public LocDetail(int idLokasi)
        {
            InitializeComponent();
            this.idLokasi = idLokasi;
            LokasiDetail();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void LokasiDetail()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NamaLokasi, AlamatLokasi, Deskripsi, HargaTiket, Kategori, Gambar FROM Lokasi WHERE IdLokasi = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idLokasi);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    NamaLoc.Text = reader.GetString(0);
                    AlamatLoc.Text = reader.GetString(1);
                    Des.Text = reader.GetString(2);

                    // Merubah Nilai Ke Mata Uang Indonesia.
                    int hargaTiket = reader.GetInt32(3);
                    HargaTic.Text = hargaTiket.ToString("C0", new CultureInfo("id-ID"));

                    Kategori.Text = reader.GetString(4);

                    if (reader["Gambar"] != DBNull.Value)
                    {
                        byte[] gambarData = (byte[])reader["Gambar"];
                        using (MemoryStream ms = new MemoryStream(gambarData))
                        {
                            Gambar.Image = Image.FromStream(ms);
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
