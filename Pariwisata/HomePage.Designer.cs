namespace Pariwisata
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            Home = new Button();
            button2 = new Button();
            UserLocWisata = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 117, 214);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(969, 36);
            panel1.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.Cursor = Cursors.Hand;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(245, 244, 179);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(245, 244, 179);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(245, 244, 179);
            nightControlBox1.Location = new Point(830, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(245, 244, 179);
            label3.Location = new Point(738, 7);
            label3.Name = "label3";
            label3.Size = new Size(66, 18);
            label3.TabIndex = 1;
            label3.Text = "Log Out";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(245, 244, 179);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(117, 24);
            label2.TabIndex = 1;
            label2.Text = "Mika Travel";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(245, 244, 179);
            label1.Location = new Point(484, 3);
            label1.Name = "label1";
            label1.Size = new Size(98, 24);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(0, 117, 214);
            flowLayoutPanel1.Controls.Add(Home);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(UserLocWisata);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(120, 529);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // Home
            // 
            Home.Cursor = Cursors.Hand;
            Home.FlatAppearance.BorderSize = 0;
            Home.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 201, 254);
            Home.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 201, 254);
            Home.FlatStyle = FlatStyle.Flat;
            Home.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Home.ForeColor = Color.FromArgb(245, 244, 179);
            Home.Location = new Point(3, 3);
            Home.Name = "Home";
            Home.Size = new Size(126, 28);
            Home.TabIndex = 3;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(223, 242, 235);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 37);
            button2.Name = "button2";
            button2.Size = new Size(126, 28);
            button2.TabIndex = 7;
            button2.Text = "User Interface";
            button2.UseVisualStyleBackColor = false;
            // 
            // UserLocWisata
            // 
            UserLocWisata.Cursor = Cursors.Hand;
            UserLocWisata.FlatAppearance.BorderSize = 0;
            UserLocWisata.FlatAppearance.MouseDownBackColor = Color.FromArgb(76, 201, 254);
            UserLocWisata.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 201, 254);
            UserLocWisata.FlatStyle = FlatStyle.Flat;
            UserLocWisata.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserLocWisata.ForeColor = Color.FromArgb(245, 244, 179);
            UserLocWisata.Location = new Point(3, 71);
            UserLocWisata.Name = "UserLocWisata";
            UserLocWisata.Size = new Size(126, 28);
            UserLocWisata.TabIndex = 8;
            UserLocWisata.Text = " Lokasi Wisata";
            UserLocWisata.UseVisualStyleBackColor = true;
            UserLocWisata.Click += UserLocWisata_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoSize = true;
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(120, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 529);
            panel2.TabIndex = 1;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(969, 565);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button Home;
        private Label label3;
        private Button button2;
        private Button UserLocWisata;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
    }
}