using System.Data;
using System.Data.SqlClient;

namespace Pariwisata
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string role = "";
            string userName = "";

            try
            {
                conn.Open();

                // Cek Role Admin
                SqlCommand cmd = new SqlCommand("SELECT Role, Nama FROM Admin WHERE Username = @Username AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    role = reader["Role"].ToString();  // Ambil Role Admin
                    userName = reader["Nama"].ToString(); // Ambil Nama Admin
                }
                reader.Close();

                // Cek Role User
                if (string.IsNullOrEmpty(role))
                {
                    SqlCommand cmdd = new SqlCommand("SELECT 'User' AS Role, Nama FROM Pelangan WHERE Username = @Username AND Password = @Password", conn);
                    //cmdd.Parameters.AddWithValue("@Nama", textBox1.Text);
                    cmdd.Parameters.AddWithValue("@Username", textBox1.Text);
                    cmdd.Parameters.AddWithValue("@Password", textBox2.Text);

                    SqlDataReader readers = cmdd.ExecuteReader();

                    if (readers.Read())
                    {
                        role = readers["Role"].ToString();
                        userName = readers["Nama"].ToString();
                    }
                    readers.Close();
                }

                // Masuk ke HomePage
                if (!string.IsNullOrEmpty(role))
                {
                    HomePage HomePage = new HomePage(role, userName);
                    HomePage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username Atau Password Salah");
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

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void GuestLogin_Click(object sender, EventArgs e)
        {
            string role = "guest";
            string userName = "guest";
            HomePage homePage = new HomePage(role, userName);
            homePage.Show();
            this.Hide();
        }
    }
}
