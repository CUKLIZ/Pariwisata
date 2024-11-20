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
    public partial class UserLocWisata : Form
    {
        private string userRole;
        private int IdPelanggan;
        public UserLocWisata(string userRole, int IdPelanggan)
        {
            InitializeComponent();

            this.userRole = userRole;
            this.IdPelanggan = IdPelanggan;

            // Cek Yang Login
            if (userRole != "Admin" && userRole != "Pegawai")
            {
                Add.Visible = false;
            }
            
            TampilLokasi();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void ShowLocationDetail(int IdLokasi)
        {
            //MessageBox.Show("Lokasi ID: " + IdLokasi);
            //MessageBox.Show($"Current User Role: {userRole}");           

            LocDetail locDetail = new(IdLokasi, userRole, IdPelanggan);

            locDetail.OnLocationAdded += () =>
            {
                // Hapus semua data di TampilData dan tampilkan data baru
                TampilData.Controls.Clear();
                TampilLokasi();
            };

            locDetail.Show();
        }

        private void ShowImage(Image image)
        {
            // Untuk Menghindari Dispose
            Image copiedImage = (Image)image.Clone();

            // Untuk Menampilkan Gambar
            Form ImageForm = new Form
            {
                Width = 600,
                Height = 600,
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.Black
            };

            // Untuk Menambahkan PictureBox
            PictureBox LargePictureBox = new PictureBox
            {
                Image = image,
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            // Untuk Menutup Ketika Area Gambar Di Click
            ImageForm.Click += (s, e) => ImageForm.Close();
            LargePictureBox.Click += (s, e) => ImageForm.Close();
            ImageForm.FormClosed += (s, e) =>
            {
                // Hapus Salinan Gambar
                copiedImage.Dispose();
            };
            ImageForm.Controls.Add(LargePictureBox);
            ImageForm.ShowDialog();
        }

        private void TampilLokasi()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT IdLokasi, NamaLokasi, Gambar FROM Lokasi", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                // Hapus Semua Control Lama
                TampilData.Controls.Clear();

                while (reader.Read())
                {
                    int IdLokasi = reader.GetInt32(0);
                    string NamaLokasi = reader.GetString(1);
                    byte[] GambarData = reader["Gambar"] as byte[];

                    // Untuk Menampung Gambar Dan Label
                    Panel panel = new Panel
                    {
                        Width = 150,
                        Height = 200,
                        Margin = new Padding(10),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Buat PictureBox untuk gambar
                    PictureBox pictureBox = new PictureBox
                    {
                        Width = 150,
                        Height = 150,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top,
                        Cursor = Cursors.Hand
                    };

                    // Cek Apakah Ada Gambar, Kalau Ada AKan Tampil Di PictureBox    
                    if (GambarData != null)
                    {
                        using (MemoryStream ms = new MemoryStream(GambarData))
                        {
                            pictureBox.Image = Image.FromStream(ms);
                        }
                    }

                    // Label Untuk Nama Lokasi
                    Label label = new Label
                    {
                        Text = NamaLokasi,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Bottom,
                        Height = 50,
                        Cursor = Cursors.Hand
                    };

                    pictureBox.Click += (s, e) => ShowImage(pictureBox.Image);
                    label.Click += (s, e) => ShowLocationDetail(IdLokasi);

                    // Tambahkan PictureBox dan Label ke Panel
                    panel.Controls.Add(label);
                    panel.Controls.Add(pictureBox);

                    // Tambahkan panel ke FlowLayoutPanel
                    TampilData.Controls.Add(panel);
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

        private void TampilData_Scroll(object sender, ScrollEventArgs e)
        {
            // Mengelola data yang terlihat saat scroll
            foreach (Control control in TampilData.Controls)
            {
                if (TampilData.ClientRectangle.IntersectsWith(control.ClientRectangle))
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            MasterLocWisata masterLocWisata = new MasterLocWisata();
            masterLocWisata.OnLocationAdded += () =>
            {
                // Hapus semua data di TampilData dan tampilkan data baru
                TampilData.Controls.Clear();
                TampilLokasi();
            };
            masterLocWisata.Show();
        }
    }
}
