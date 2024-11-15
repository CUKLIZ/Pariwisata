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
    public partial class MasterLocWisata : Form
    {
        public MasterLocWisata()
        {
            InitializeComponent();
            LocWisataTampil();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void PilihGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                GambarPilih.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Convert Gambar Ke Binary
        private byte[] ConvertImageToByner(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        // Untuk Menampilkan Ke Data Gridviue
        public void LocWisataTampil()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Lokasi", conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
        }

        private void Tambah_Click(object sender, EventArgs e)
        {
            // Ambil data dari yang sudah di input
            string NamaLokasi = NamaLoc.Text;
            string AlamatLokasi = AlamatLoc.Text;
            string Deskripsis = Deskripsi.Text;
            decimal HargaTiket = Convert.ToDecimal(HargaTic.Text);

            // Convert Gambar
            byte[] GambarData = ConvertImageToByner(GambarPilih.Image);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Lokasi (NamaLokasi, AlamatLokasi, Deskripsi, HargaTiket, Gambar) " +
                    "VALUES (@NamaLokasi, @AlamatLokasi, @Deskripsi, @HargaTiker, @Gambar) ", conn);

                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi);
                cmd.Parameters.AddWithValue("@AlamatLokasi", AlamatLokasi);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsis);
                cmd.Parameters.AddWithValue("@HargaTiker", HargaTiket);
                cmd.Parameters.AddWithValue("@Gambar", GambarData);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lokasi Berhasil Di Tambah Cuy");

                NamaLoc.Clear();
                AlamatLoc.Clear();
                Deskripsi.Clear();
                HargaTic.Clear();

                LocWisataTampil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void MasterLocWisata_Load(object sender, EventArgs e)
        {

        }
    }
}
