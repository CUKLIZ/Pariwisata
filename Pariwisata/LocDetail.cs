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
    public partial class LocDetail : Form
    {
        private int idLokasi;
        public LocDetail(int idLokasi)
        {
            InitializeComponent();
            this.idLokasi = idLokasi;
            
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void LokasiDetal()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT NamaLokasi, AlamatLokasi, Deskripsi, HargaTiket, Gambar FROM Lokasi WHERE IdLokasi = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", idLokasi);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    NamaLoc.Text = reader.GetString(0);
                    AlamatLoc.Text = reader.GetString(1);
                    Des.Text = reader.GetString(2);
                    HargaTic.Text = reader.GetDecimal(3).ToString("C");

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
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            } finally
            {
                conn.Close();
            }
        }

    }
}
