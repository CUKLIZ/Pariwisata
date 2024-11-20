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
using System.Drawing.Imaging;
using System.Text.Json.Serialization;

namespace Pariwisata
{
    public partial class LocDetail : Form
    {
        private int idLokasi;
        private string userRole;
        private int IdPelanggan;

        private HomePage homePages;

        public LocDetail(int idLokasi, string userRole, int idPelanggan)
        {
            InitializeComponent();

            this.idLokasi = idLokasi;
            this.userRole = userRole;
            this.IdPelanggan = idPelanggan;

            homePages = HomePage.homePage;

            LokasiDetail();
            SetBUtton();

            //MessageBox.Show($"CurrentUserId: {homePages.CurrentUserId}");
            //MessageBox.Show($"SQL Query: SELECT COUNT(*) FROM Pelangan WHERE = {homePages.CurrentUserId}");
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
        private void SetBUtton()
        {
            if (userRole == "Admin")
            {
                Pesan.Visible = false;
                NamaLoc.ReadOnly = false;
                AlamatLoc.ReadOnly = false;
                Des.ReadOnly = false;
                Kategori.ReadOnly = false;
                HargaTic.ReadOnly = false;
                BerapaPesan.Visible = false;
            }
            else if (userRole == "User")
            {
                Edit.Visible = false;
                Delete.Visible = false;
                UbahGambar.Visible = false;
            }
            else if (userRole == "guest")
            {
                Edit.Visible = false;
                Delete.Visible = false;
                UbahGambar.Visible = false;
            } else if (userRole == "Pegawai")
            {
                Pesan.Visible = false;
                NamaLoc.ReadOnly = false;
                AlamatLoc.ReadOnly = false;
                Des.ReadOnly = false;
                Kategori.ReadOnly = false;
                HargaTic.ReadOnly = false;
                BerapaPesan.Visible = false;
            }
        }

        private byte[] ConvertImageToByner(Image image)
        {
            Image compressedImage = CompressImage(image, 200, 200);

            using (MemoryStream ms = new MemoryStream())
            {
                compressedImage.Save(ms, ImageFormat.Jpeg); 

                return ms.ToArray();
            }
        }

        private Image CompressImage(Image image, int maxWidth, int maxHeight)
        {
            int width = maxWidth;
            int height = maxHeight;

            float ratioX = (float)image.Width / width;
            float ratioY = (float)image.Height / height;

            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(width * ratio);
            int newHeight = (int)(height * ratio);

            return new Bitmap(image, newHeight, newWidth);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UbahGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Gambar.Image = Image.FromFile(ofd.FileName);
            }
        }

        public event Action OnLocationAdded;
        private void Edit_Click(object sender, EventArgs e)
        {
            string NamaLokasi = NamaLoc.Text;
            string AlamatLokasi = AlamatLoc.Text;
            string Deskripsi = Des.Text;
            string Kategoris = Kategori.Text;

            // Menghapus simbol 'Rp' dan mengganti tanda koma dengan titik jika ada
            string hargaText = HargaTic.Text.Replace("Rp", "").Replace(".", "").Trim();

            // Mengonversi ke decimal
            decimal HargaTiket = Convert.ToDecimal(hargaText, new CultureInfo("id-ID"));

            byte[] GambarData = ConvertImageToByner(Gambar.Image);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("UPDATE Lokasi SET NamaLokasi = @NamaLokasi, AlamatLokasi = @AlamatLokasi, " +
                    "Deskripsi = @Deskripsi, Kategori = @Kategori, Gambar = @Gambar WHERE IdLokasi = @IdLokasi", conn);

                cmd.Parameters.AddWithValue("@NamaLokasi", NamaLokasi);
                cmd.Parameters.AddWithValue("@AlamatLokasi", AlamatLokasi);
                cmd.Parameters.AddWithValue("@Deskripsi", Deskripsi);
                cmd.Parameters.AddWithValue("@Kategori", Kategoris);
                cmd.Parameters.AddWithValue("@Gambar", GambarData);
                cmd.Parameters.AddWithValue("@IdLokasi", idLokasi);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Lokasi Berhasil Di Perbarui");

                NamaLoc.Text = "";
                AlamatLoc.Text = "";
                Des.Text = "";
                Kategori.Text = "";
                HargaTic.Text = "";
                Gambar.Image = null;

                // Panggil event OnLocationAdded untuk memberitahu form UserLocWisata
                OnLocationAdded?.Invoke();
            } catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            } finally
            {
                conn.Close();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Hapus?", "Iya", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Lokasi WHERE IdLokasi = @IdLokasi", conn);
                    cmd.Parameters.AddWithValue("@IdLokasi", idLokasi);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data Berhasil Di Hapus");

                    this.Close();

                    // Panggil Event OnLocationAdded Untuk Memberitahu Form UserLocWisata
                    OnLocationAdded?.Invoke();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Errror", ex.Message);
            } finally
            {
                conn.Close();
            }
        }

        private void Pesan_Click(object sender, EventArgs e)
        {
            if (userRole == "guest")
            {
                DialogResult result = MessageBox.Show("Login Dulu", "Login ngak?", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Close();
                    homePages.Close();
                }                
            } else if (userRole == "User")
            {
                if (int.TryParse(BerapaPesan.Text, out int jumlahTiket) && jumlahTiket > 0)
                {
                    decimal hargaPerTiket = Convert.ToDecimal(HargaTic.Text.Replace("Rp", "").Replace(".", "").Trim(), new CultureInfo("id-ID"));
                    decimal TotalHarga = jumlahTiket * hargaPerTiket;

                    try
                    {
                        conn.Open();

                        // Verifikasi CurrentUserId di database
                        SqlCommand verifyCmd = new SqlCommand("SELECT COUNT(*) FROM Pelangan WHERE IdPelanggan = @IdPelanggan", conn);
                        verifyCmd.Parameters.AddWithValue("@IdPelanggan", IdPelanggan);

                        int count = (int)verifyCmd.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("IdPelanggan tidak ditemukan di tabel Pelangan.");
                            return;
                        }

                        // Ke Pembelian
                        SqlCommand cmd = new SqlCommand("INSERT INTO Pembelian (IdPelanggan, TanggalPembelian, TotalHarga) OUTPUT " +
                            "INSERTED.IdPembelian VALUES (@IdPelanggan, GETDATE(), @TotalHarga)", conn);

                        cmd.Parameters.AddWithValue("@IdPelanggan", IdPelanggan); // Pastikan tipe int
                        cmd.Parameters.AddWithValue("@TotalHarga", Convert.ToDecimal(TotalHarga)); // Pastikan tipe decimal

                        int IdPembelian = (int)cmd.ExecuteScalar();

                        // Ke Detail Pembelian
                        SqlCommand cmdd = new SqlCommand("INSERT INTO DetailPembelian (IdPembelian, IdLokasi, JumlahTiket, HargaPerTiket, TotalHarga)" +
                            "VALUES (@IdPembelian, @IdLokasi, @JumlahTiket, @HargaPerTiket, @TotalHarga)", conn);

                        cmdd.Parameters.AddWithValue("@IdPembelian", IdPembelian); // Penamaan parameter diperbaiki
                        cmdd.Parameters.AddWithValue("@IdLokasi", idLokasi);
                        cmdd.Parameters.AddWithValue("@JumlahTiket", jumlahTiket);
                        cmdd.Parameters.AddWithValue("@HargaPerTiket", hargaPerTiket);
                        cmdd.Parameters.AddWithValue("@TotalHarga", TotalHarga);

                        cmdd.ExecuteNonQuery();
                        MessageBox.Show("Berhasil Memesan");

                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    } finally
                    {
                        conn.Close();
                    }
                } else
                {
                    MessageBox.Show("Tiket Tidak Tersedia");
                }
            }
        }
    }
}
