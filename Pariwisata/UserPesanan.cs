using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing.Imaging;

namespace Pariwisata
{
    public partial class UserPesanan : Form
    {
        private string userRole;
        private int IdPelanggan;
        public UserPesanan(string userRole, int IdPelanggan)
        {
            InitializeComponent();

            this.userRole = userRole;
            this.IdPelanggan = IdPelanggan;

            if (userRole != "User")
            {
                KirimBukti.Visible = false;
                pictureBox1.Visible = false;
                BatalPesan.Visible = false;
                panel1.Visible = false;
            }
            else if (userRole != "Admin")
            {
                Proses.Visible = false;
            }

            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
            dataGridView1.CellClick += dataGridView1_CellClick;

            DataTampil();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                NamaLoc.Text = row.Cells["NamaLokasi"].Value.ToString();
                AlamatLoc.Text = row.Cells["AlamatLokasi"].Value.ToString();
                BerapaTic.Text = row.Cells["JumlahTiket"].Value.ToString();
                TotalHarga.Text = row.Cells["TotalHarga"].Value.ToString();
            }
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "TotalHarga" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal totalHarga))
                {
                    e.Value = totalHarga.ToString("C", new CultureInfo("id-ID"));
                    e.FormattingApplied = true;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;

                byte[] imageBytes = dataGridView1.Rows[e.RowIndex].Cells["Bukti"].Value as byte[];

                if (imageBytes != null && imageBytes.Length > 0)
                {
                    // Jika Ada Gambar, Tampilkan Di PictureBox
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }

                    KirimBukti.Visible = false;
                }
                else
                {
                    pictureBox1.Image = null;

                    KirimBukti.Visible = true;
                }
            }
        }

        private void DataTampil()
        {
            try
            {
                conn.Open();

                if (userRole == "User")
                {
                    SqlCommand cmd = new SqlCommand("SELECT L.NamaLokasi, L.AlamatLokasi, P.JumlahTiket, P.TotalHarga, P.Status, P.IdPesanan, P.Bukti " +
                                            "FROM Pesanan P " +
                                            "INNER JOIN Lokasi L ON P.IdLokasi = L.IdLokasi " +
                                            "WHERE P.IdPelanggan = @IdPelanggan", conn);
                    cmd.Parameters.AddWithValue("@IdPelanggan", IdPelanggan);

                    // Jalan Kan Quer
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                else if (userRole == "Admin")
                {
                    SqlCommand cmd = new SqlCommand("SELECT L.NamaLokasi, L.AlamatLokasi, P.JumlahTiket, P.TotalHarga, P.Status " +
                                                    "FROM Pesanan P " +
                                                    "INNER JOIN Lokasi L ON P.IdLokasi = L.IdLokasi", conn);

                    // Jalan Kan Query
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Role Tidak Ada, HACKING YA :v");
                    return;
                }
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

        private void Proses_Click(object sender, EventArgs e)
        {
            AdminPesanan adminPesanan = new AdminPesanan();
            adminPesanan.Show();
        }

        // Convert Image To Byner
        private byte[] ConvertImageToBinary(Image image)
        {
            // Kompres Gambar
            Image compressedImage = CompressImage(image, 200, 200);

            using (MemoryStream ms = new MemoryStream())
            {
                compressedImage.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

        private Image CompressImage(Image image, int maxWidth, int maxHeight)
        {
            int width = image.Width;
            int height = image.Height;

            float ratioX = (float)maxWidth / width;
            float ratioY = (float)maxHeight / height;

            float ratio = Math.Min(ratioX, ratioY);

            int newWidth = (int)(width * ratio);
            int newHeight = (int)(height * ratio);

            return new Bitmap(image, newWidth, newHeight);
        }

        private void KirimBukti_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Ambil IdPesanan
                int idPesan = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["IdPesanan"].Value);

                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image imageSelected = Image.FromFile(ofd.FileName);
                    byte[] imageByte = ConvertImageToBinary(imageSelected);

                    try
                    {
                        using (SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;"))
                        {
                            conn.Open();
                            SqlCommand cmd = new SqlCommand("UPDATE Pesanan SET Bukti = @Bukti, Status = 'Menunggu Konfirmasi' WHERE IdPesanan = @IdPesanan", conn);
                            cmd.Parameters.AddWithValue("@Bukti", imageByte);
                            cmd.Parameters.AddWithValue("@IdPesanan", idPesan);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Bukti Transfer Sudah Dikirim. Silahkan Menunggu Konfirmasi Admin.");
                        }

                        DataTampil();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Tidak Ada Gambar Yang Dipilih!");
                }
            }
            else
            {
                MessageBox.Show("Silahkan Pilih Pesanan Yang Ingin Dikirim Bukti.");
            }
        }

        private void BatalPesan_Click(object sender, EventArgs e)
        {

        }
    }
}
