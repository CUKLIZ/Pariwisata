namespace Pariwisata
{
    partial class MasterLocWisata
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
            openFileDialog1 = new OpenFileDialog();
            GambarPilih = new PictureBox();
            label3 = new Label();
            textbox = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            NamaLoc = new ReaLTaiizor.Controls.AloneTextBox();
            AlamatLoc = new ReaLTaiizor.Controls.AloneTextBox();
            Des = new ReaLTaiizor.Controls.AloneTextBox();
            Kategoris = new ReaLTaiizor.Controls.AloneTextBox();
            label6 = new Label();
            HargaTic = new ReaLTaiizor.Controls.AloneTextBox();
            Tambah = new Button();
            panel7 = new Panel();
            panel8 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            PilihGambar = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)GambarPilih).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GambarPilih
            // 
            GambarPilih.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            GambarPilih.Location = new Point(442, 117);
            GambarPilih.Name = "GambarPilih";
            GambarPilih.Size = new Size(295, 254);
            GambarPilih.SizeMode = PictureBoxSizeMode.Zoom;
            GambarPilih.TabIndex = 0;
            GambarPilih.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni Bd BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(260, 9);
            label3.Name = "label3";
            label3.Size = new Size(279, 32);
            label3.TabIndex = 17;
            label3.Text = "Tambah Lokasi Wisata";
            // 
            // textbox
            // 
            textbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textbox.AutoSize = true;
            textbox.Cursor = Cursors.Hand;
            textbox.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textbox.ForeColor = Color.FromArgb(0, 117, 214);
            textbox.Location = new Point(9, 82);
            textbox.Name = "textbox";
            textbox.Size = new Size(106, 16);
            textbox.TabIndex = 29;
            textbox.Text = "Nama Lokasi :";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(11, 132);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 32;
            label1.Text = "Alamat Lokasi :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(11, 193);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 35;
            label2.Text = "Deskripsi :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(9, 342);
            label4.Name = "label4";
            label4.Size = new Size(97, 16);
            label4.TabIndex = 38;
            label4.Text = "Harga Tiket :";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(442, 81);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 41;
            label5.Text = "Gambar :";
            // 
            // NamaLoc
            // 
            NamaLoc.BackColor = Color.Transparent;
            NamaLoc.EnabledCalc = true;
            NamaLoc.Font = new Font("Segoe UI", 9F);
            NamaLoc.ForeColor = Color.FromArgb(124, 133, 142);
            NamaLoc.Location = new Point(121, 74);
            NamaLoc.MaxLength = 32767;
            NamaLoc.MultiLine = false;
            NamaLoc.Name = "NamaLoc";
            NamaLoc.ReadOnly = false;
            NamaLoc.Size = new Size(313, 29);
            NamaLoc.TabIndex = 53;
            NamaLoc.Text = "Nama Lokasi";
            NamaLoc.TextAlign = HorizontalAlignment.Left;
            NamaLoc.UseSystemPasswordChar = false;
            // 
            // AlamatLoc
            // 
            AlamatLoc.BackColor = Color.Transparent;
            AlamatLoc.EnabledCalc = true;
            AlamatLoc.Font = new Font("Segoe UI", 9F);
            AlamatLoc.ForeColor = Color.FromArgb(124, 133, 142);
            AlamatLoc.Location = new Point(130, 117);
            AlamatLoc.MaxLength = 32767;
            AlamatLoc.MultiLine = true;
            AlamatLoc.Name = "AlamatLoc";
            AlamatLoc.ReadOnly = false;
            AlamatLoc.Size = new Size(306, 56);
            AlamatLoc.TabIndex = 54;
            AlamatLoc.Text = "Alamat Lokasi";
            AlamatLoc.TextAlign = HorizontalAlignment.Left;
            AlamatLoc.UseSystemPasswordChar = false;
            // 
            // Des
            // 
            Des.BackColor = Color.Transparent;
            Des.EnabledCalc = true;
            Des.Font = new Font("Segoe UI", 9F);
            Des.ForeColor = Color.FromArgb(124, 133, 142);
            Des.Location = new Point(98, 187);
            Des.MaxLength = 32767;
            Des.MultiLine = true;
            Des.Name = "Des";
            Des.ReadOnly = false;
            Des.Size = new Size(338, 86);
            Des.TabIndex = 55;
            Des.Text = "Deskripsi";
            Des.TextAlign = HorizontalAlignment.Left;
            Des.UseSystemPasswordChar = false;
            // 
            // Kategoris
            // 
            Kategoris.BackColor = Color.Transparent;
            Kategoris.EnabledCalc = true;
            Kategoris.Font = new Font("Segoe UI", 9F);
            Kategoris.ForeColor = Color.FromArgb(124, 133, 142);
            Kategoris.Location = new Point(96, 287);
            Kategoris.MaxLength = 32767;
            Kategoris.MultiLine = false;
            Kategoris.Name = "Kategoris";
            Kategoris.ReadOnly = false;
            Kategoris.Size = new Size(338, 29);
            Kategoris.TabIndex = 60;
            Kategoris.Text = "Kategori";
            Kategoris.TextAlign = HorizontalAlignment.Left;
            Kategoris.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 117, 214);
            label6.Location = new Point(9, 294);
            label6.Name = "label6";
            label6.Size = new Size(73, 16);
            label6.TabIndex = 61;
            label6.Text = "Kategori :";
            // 
            // HargaTic
            // 
            HargaTic.BackColor = Color.Transparent;
            HargaTic.EnabledCalc = true;
            HargaTic.Font = new Font("Segoe UI", 9F);
            HargaTic.ForeColor = Color.FromArgb(124, 133, 142);
            HargaTic.Location = new Point(112, 334);
            HargaTic.MaxLength = 32767;
            HargaTic.MultiLine = false;
            HargaTic.Name = "HargaTic";
            HargaTic.ReadOnly = false;
            HargaTic.Size = new Size(322, 29);
            HargaTic.TabIndex = 62;
            HargaTic.Text = "Harga Tiket";
            HargaTic.TextAlign = HorizontalAlignment.Left;
            HargaTic.UseSystemPasswordChar = false;
            // 
            // Tambah
            // 
            Tambah.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Tambah.BackColor = Color.FromArgb(0, 117, 214);
            Tambah.Cursor = Cursors.Hand;
            Tambah.FlatAppearance.BorderSize = 0;
            Tambah.FlatStyle = FlatStyle.Flat;
            Tambah.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tambah.ForeColor = Color.White;
            Tambah.Location = new Point(192, 381);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(393, 33);
            Tambah.TabIndex = 65;
            Tambah.Text = "Tambah Lokasi";
            Tambah.UseVisualStyleBackColor = false;
            Tambah.Click += Tambah_Click_1;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(0, 117, 124);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(9, 369);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 2);
            panel7.TabIndex = 64;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 117, 214);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(305, 2);
            panel8.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 117, 124);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 322);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 2);
            panel1.TabIndex = 65;
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
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 117, 124);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(14, 279);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 2);
            panel3.TabIndex = 66;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 2);
            panel4.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(0, 117, 124);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(14, 179);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 2);
            panel5.TabIndex = 67;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 2);
            panel6.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(0, 117, 124);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(12, 109);
            panel9.Name = "panel9";
            panel9.Size = new Size(425, 2);
            panel9.TabIndex = 68;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 117, 214);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 2);
            panel10.TabIndex = 10;
            // 
            // PilihGambar
            // 
            PilihGambar.BackColor = Color.Transparent;
            PilihGambar.BorderColor = Color.FromArgb(32, 34, 37);
            PilihGambar.Cursor = Cursors.Hand;
            PilihGambar.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            PilihGambar.EnteredColor = Color.FromArgb(32, 34, 37);
            PilihGambar.Font = new Font("Microsoft Sans Serif", 12F);
            PilihGambar.Image = null;
            PilihGambar.ImageAlign = ContentAlignment.MiddleLeft;
            PilihGambar.InactiveColor = Color.FromArgb(0, 117, 214);
            PilihGambar.Location = new Point(518, 77);
            PilihGambar.Name = "PilihGambar";
            PilihGambar.PressedBorderColor = Color.FromArgb(165, 37, 37);
            PilihGambar.PressedColor = Color.FromArgb(165, 37, 37);
            PilihGambar.Size = new Size(219, 26);
            PilihGambar.TabIndex = 69;
            PilihGambar.Text = "Pilih Gambar";
            PilihGambar.TextAlignment = StringAlignment.Center;
            PilihGambar.Click += PilihGambar_Click_1;
            // 
            // MasterLocWisata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(749, 426);
            Controls.Add(PilihGambar);
            Controls.Add(panel9);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(Tambah);
            Controls.Add(panel7);
            Controls.Add(HargaTic);
            Controls.Add(label6);
            Controls.Add(Kategoris);
            Controls.Add(Des);
            Controls.Add(AlamatLoc);
            Controls.Add(NamaLoc);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textbox);
            Controls.Add(label3);
            Controls.Add(GambarPilih);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MasterLocWisata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterLocWisata";
            Load += MasterLocWisata_Load;
            ((System.ComponentModel.ISupportInitialize)GambarPilih).EndInit();
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox GambarPilih;
        private Label label3;
        private Label textbox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ReaLTaiizor.Controls.AloneTextBox NamaLoc;
        private ReaLTaiizor.Controls.AloneTextBox AlamatLoc;
        private ReaLTaiizor.Controls.AloneTextBox Des;
        private ReaLTaiizor.Controls.AloneTextBox Kategoris;
        private Label label6;
        private ReaLTaiizor.Controls.AloneTextBox HargaTic;
        private Button Tambah;
        private Panel panel7;
        private Panel panel8;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel9;
        private Panel panel10;
        private ReaLTaiizor.Controls.Button PilihGambar;
    }
}