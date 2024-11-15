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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Nama.Clear();
            Username.Clear();
            Password.Clear();
            NomorHp.Clear();
            Gmail.Clear();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BikinAkun_Click(object sender, EventArgs e)
        {
            // Jika Tidak Di Isi
            if (string.IsNullOrWhiteSpace(Nama.Text) || string.IsNullOrWhiteSpace(Username.Text) || 
                string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Nama, Username Dan Password Harus Di Isi. ");
                return;
            }

            try
            {
                conn.Open();

                // Cek Username
                SqlCommand CheckUsername = new SqlCommand("SELECT COUNT(*) FROM Pelangan WHERE Username = @Username", conn);
                CheckUsername.Parameters.AddWithValue("@Username", Username.Text);
                int UserAda = (int)CheckUsername.ExecuteScalar();

                if (UserAda > 0)
                {
                    MessageBox.Show("Username Telah Di Gunakan Orang Lain");
                    return;
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO Pelangan (Nama, Username, Password, NoTelp, Email) " +
                    "VALUES (@Nama, @Username, @Password, @NoTelp, @Email) ", conn);

                cmd.Parameters.AddWithValue("@Nama", Nama.Text);
                cmd.Parameters.AddWithValue("@Username", Username.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.Parameters.AddWithValue("@NoTelp", NomorHp.Text);
                cmd.Parameters.AddWithValue("@Email", Gmail.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Akun Telah Terbuat");
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Error Cuy");
                }
            } catch (Exception ex) 
            {
                MessageBox.Show("Error Cuy", ex.Message);
            } finally
            {
                conn.Close();
            }
        }
    }
}
