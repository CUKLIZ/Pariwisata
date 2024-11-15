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
    public partial class HomePage : Form
    {
        private string userRole;
        private string userName;
        public HomePage(string role, string Name)
        {
            InitializeComponent();
            userRole = role;
            userName = Name;
            Login();

            this.Load += new System.EventHandler(this.HomePage_Load);
        }

        SqlConnection conn = new SqlConnection("Data Source=Tamara-Desktop\\SQLEXPRESS;Initial Catalog=Pariwisata;Integrated Security=True;");

        // Untuk Cek Siapa Yang Login
        private void Login()
        {
            if (userRole == "Admin")
            {
                label1.Text = $"Welcome {userName}";
            }
            else if (userRole == "User")
            {
                label1.Text = $"Welcome {userName}";
            }
            else if (userRole == "guest")
            {
                label1.Text = "Welcome Guest";
            }
            else if (userRole == "Pegawai")
            {
                label1.Text = $"Welcome {userName}";
            }
        }

        // Untuk Mengload Home
        private void ShowHomePage()
        {
            Home homeControl = new Home();
            panel2.Controls.Clear();
            homeControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(homeControl);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            ShowHomePage();
        }


        // Untuk Pindah Halamn
        public void loadForm(object Form)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(f);
            this.panel2.Tag = f;
            f.Show();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home homeControl = new Home();
            panel2.Controls.Clear();
            panel2.Controls.Add(homeControl);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void UserLocWisata_Click(object sender, EventArgs e)
        {
            UserLocWisata userLocWisata = new UserLocWisata(userRole);
            loadForm(userLocWisata);
        }        
    }
}
