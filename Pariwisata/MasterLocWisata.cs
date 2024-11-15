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
            //LocWisataTampil();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void PilihGambar_Click_1(object sender, EventArgs e)
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
        //public void LocWisataTampil()
        //{
        //    SqlCommand cmd = new SqlCommand("SELECT * FROM Lokasi", conn);
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    sda.Fill(dt);
        //}

        public event Action OnLocationAdded;
        private void Tambah_Click_1(object sender, EventArgs e)
        {
            // Ambil data dari yang sudah di input
            string NamaLokasi = NamaLoc.Text;
            string AlamatLokasi = AlamatLoc.Text;
            string Deskripsis = Des.Text;
            string Kategori = Kategoris.Text;
            //decimal HargaTiket = Convert.ToDecimal(HargaTic.Text);
            decimal HargaTiket = Convert.ToDecimal(HargaTic.Text);

            // Convert Gambar
            byte[] GambarData = ConvertImageToByner(GambarPilih.Image);

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Lokasi (NamaLokasi, AlamatLokasi, Deskripsi, HargaTiket, Kategori ,Gambar) " +
                    "VALUES (@NamaLokasi, @AlamatLokasi, @Deskripsi, @HargaTiket, @Kategori ,@Gambar) ", conn);

                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi);
                cmd.Parameters.AddWithValue("@AlamatLokasi", AlamatLokasi);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsis);
                cmd.Parameters.AddWithValue("@HargaTiket", HargaTiket);
                cmd.Parameters.AddWithValue("@Kategori", Kategori);
                cmd.Parameters.AddWithValue("@Gambar", GambarData);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Lokasi Berhasil Di Tambah Cuy");

                NamaLoc.Text = "";
                AlamatLoc.Text = "";
                Des.Text = "";
                Kategoris.Text = "";
                HargaTic.Text = "";
                GambarPilih.Image = null;

                // Panggil event OnLocationAdded untuk memberitahu form UserLocWisata
                OnLocationAdded?.Invoke();
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
