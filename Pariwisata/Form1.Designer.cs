namespace Pariwisata
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Clear = new Label();
            Exit = new Label();
            textBox2 = new TextBox();
            Login = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox4 = new PictureBox();
            signup = new Label();
            GuestLogin = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 117, 214);
            textBox1.Location = new Point(50, 215);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(267, 17);
            textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MikasaKecil;
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 124);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 243);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 2);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 2);
            panel2.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 117, 214);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 329);
            panel3.Name = "panel3";
            panel3.Size = new Size(305, 2);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 2);
            panel4.TabIndex = 10;
            // 
            // Clear
            // 
            Clear.AutoSize = true;
            Clear.Cursor = Cursors.Hand;
            Clear.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Clear.ForeColor = Color.FromArgb(0, 117, 214);
            Clear.Location = new Point(273, 367);
            Clear.Name = "Clear";
            Clear.Size = new Size(44, 16);
            Clear.TabIndex = 11;
            Clear.Text = "Clear";
            Clear.Click += Clear_Click;
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Exit.ForeColor = Color.FromArgb(0, 117, 214);
            Exit.Location = new Point(141, 444);
            Exit.Name = "Exit";
            Exit.Size = new Size(32, 16);
            Exit.TabIndex = 12;
            Exit.Text = "Exit";
            Exit.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.FromArgb(0, 117, 214);
            textBox2.Location = new Point(50, 299);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(267, 17);
            textBox2.TabIndex = 13;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(0, 117, 214);
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(12, 396);
            Login.Name = "Login";
            Login.Size = new Size(305, 33);
            Login.TabIndex = 14;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni Bd BT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(33, 18);
            label2.Name = "label2";
            label2.Size = new Size(266, 38);
            label2.TabIndex = 15;
            label2.Text = "Welcome to Mika";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni Bd BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(124, 56);
            label3.Name = "label3";
            label3.Size = new Size(90, 32);
            label3.TabIndex = 16;
            label3.Text = "Travel";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(239, 101);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(87, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // signup
            // 
            signup.AutoSize = true;
            signup.Cursor = Cursors.Hand;
            signup.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup.ForeColor = Color.FromArgb(0, 117, 214);
            signup.Location = new Point(12, 367);
            signup.Name = "signup";
            signup.Size = new Size(62, 16);
            signup.TabIndex = 18;
            signup.Text = "Sign Up";
            signup.Click += signup_Click;
            // 
            // GuestLogin
            // 
            GuestLogin.AutoSize = true;
            GuestLogin.Cursor = Cursors.Hand;
            GuestLogin.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GuestLogin.ForeColor = Color.FromArgb(0, 117, 214);
            GuestLogin.Location = new Point(228, 444);
            GuestLogin.Name = "GuestLogin";
            GuestLogin.Size = new Size(89, 16);
            GuestLogin.TabIndex = 31;
            GuestLogin.Text = "Login Guest";
            GuestLogin.Click += GuestLogin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Username;
            pictureBox2.Location = new Point(12, 213);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 299);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 33;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(329, 486);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(GuestLogin);
            Controls.Add(signup);
            Controls.Add(pictureBox4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Login);
            Controls.Add(textBox2);
            Controls.Add(Exit);
            Controls.Add(Clear);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label Clear;
        private Label Exit;
        private TextBox textBox2;
        private Button Login;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox4;
        private Label signup;
        private Label GuestLogin;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
