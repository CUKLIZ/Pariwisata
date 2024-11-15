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
            PilihGambar = new Button();
            label3 = new Label();
            textbox = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            NamaLoc = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            AlamatLoc = new TextBox();
            label2 = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            Deskripsi = new TextBox();
            label4 = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            HargaTic = new TextBox();
            label5 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            Tambah = new Button();
            ((System.ComponentModel.ISupportInitialize)GambarPilih).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
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
            GambarPilih.Location = new Point(12, 370);
            GambarPilih.Name = "GambarPilih";
            GambarPilih.Size = new Size(425, 114);
            GambarPilih.SizeMode = PictureBoxSizeMode.Zoom;
            GambarPilih.TabIndex = 0;
            GambarPilih.TabStop = false;
            // 
            // PilihGambar
            // 
            PilihGambar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            PilihGambar.FlatStyle = FlatStyle.Flat;
            PilihGambar.ForeColor = Color.FromArgb(0, 117, 214);
            PilihGambar.Location = new Point(99, 294);
            PilihGambar.Name = "PilihGambar";
            PilihGambar.Size = new Size(338, 23);
            PilihGambar.TabIndex = 1;
            PilihGambar.Text = "Pilihh Gambar";
            PilihGambar.UseVisualStyleBackColor = true;
            PilihGambar.Click += PilihGambar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Bodoni Bd BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 117, 214);
            label3.Location = new Point(298, 9);
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
            textbox.Location = new Point(12, 54);
            textbox.Name = "textbox";
            textbox.Size = new Size(106, 16);
            textbox.TabIndex = 29;
            textbox.Text = "Nama Lokasi :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 117, 124);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 2);
            panel1.TabIndex = 28;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 2);
            panel2.TabIndex = 10;
            // 
            // NamaLoc
            // 
            NamaLoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            NamaLoc.BackColor = Color.White;
            NamaLoc.BorderStyle = BorderStyle.None;
            NamaLoc.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NamaLoc.ForeColor = Color.FromArgb(0, 117, 214);
            NamaLoc.Location = new Point(124, 53);
            NamaLoc.Name = "NamaLoc";
            NamaLoc.PlaceholderText = "Nama Lokasi";
            NamaLoc.Size = new Size(313, 17);
            NamaLoc.TabIndex = 27;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 117, 214);
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(113, 16);
            label1.TabIndex = 32;
            label1.Text = "Alamat Lokasi :";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 117, 124);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(12, 155);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 2);
            panel3.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 2);
            panel4.TabIndex = 10;
            // 
            // AlamatLoc
            // 
            AlamatLoc.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AlamatLoc.BackColor = Color.White;
            AlamatLoc.BorderStyle = BorderStyle.None;
            AlamatLoc.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AlamatLoc.ForeColor = Color.FromArgb(0, 117, 214);
            AlamatLoc.Location = new Point(131, 127);
            AlamatLoc.Name = "AlamatLoc";
            AlamatLoc.PlaceholderText = "Alamat Lokasi";
            AlamatLoc.Size = new Size(306, 17);
            AlamatLoc.TabIndex = 30;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 117, 214);
            label2.Location = new Point(12, 187);
            label2.Name = "label2";
            label2.Size = new Size(81, 16);
            label2.TabIndex = 35;
            label2.Text = "Deskripsi :";
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(0, 117, 124);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(12, 214);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 2);
            panel5.TabIndex = 34;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 2);
            panel6.TabIndex = 10;
            // 
            // Deskripsi
            // 
            Deskripsi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Deskripsi.BackColor = Color.White;
            Deskripsi.BorderStyle = BorderStyle.None;
            Deskripsi.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deskripsi.ForeColor = Color.FromArgb(0, 117, 214);
            Deskripsi.Location = new Point(99, 186);
            Deskripsi.Name = "Deskripsi";
            Deskripsi.PlaceholderText = "Deskripsi";
            Deskripsi.Size = new Size(338, 17);
            Deskripsi.TabIndex = 33;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 117, 214);
            label4.Location = new Point(12, 244);
            label4.Name = "label4";
            label4.Size = new Size(89, 16);
            label4.TabIndex = 38;
            label4.Text = "Harga Tiket";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(0, 117, 124);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(12, 271);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 2);
            panel7.TabIndex = 37;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 117, 214);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(305, 2);
            panel8.TabIndex = 10;
            // 
            // HargaTic
            // 
            HargaTic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            HargaTic.BackColor = Color.White;
            HargaTic.BorderStyle = BorderStyle.None;
            HargaTic.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HargaTic.ForeColor = Color.FromArgb(0, 117, 214);
            HargaTic.Location = new Point(107, 243);
            HargaTic.Name = "HargaTic";
            HargaTic.PlaceholderText = "Harga Tiket";
            HargaTic.Size = new Size(330, 17);
            HargaTic.TabIndex = 36;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 117, 214);
            label5.Location = new Point(12, 296);
            label5.Name = "label5";
            label5.Size = new Size(70, 16);
            label5.TabIndex = 41;
            label5.Text = "Gambar :";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(0, 117, 124);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(12, 323);
            panel9.Name = "panel9";
            panel9.Size = new Size(425, 2);
            panel9.TabIndex = 40;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 117, 214);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 2);
            panel10.TabIndex = 10;
            // 
            // Tambah
            // 
            Tambah.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Tambah.BackColor = Color.FromArgb(0, 117, 214);
            Tambah.FlatAppearance.BorderSize = 0;
            Tambah.FlatStyle = FlatStyle.Flat;
            Tambah.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Tambah.ForeColor = Color.White;
            Tambah.Location = new Point(12, 331);
            Tambah.Name = "Tambah";
            Tambah.Size = new Size(425, 33);
            Tambah.TabIndex = 42;
            Tambah.Text = "Tambah Lokasi";
            Tambah.UseVisualStyleBackColor = false;
            Tambah.Click += Tambah_Click;
            // 
            // MasterLocWisata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(849, 529);
            Controls.Add(Tambah);
            Controls.Add(label5);
            Controls.Add(panel9);
            Controls.Add(label4);
            Controls.Add(panel7);
            Controls.Add(HargaTic);
            Controls.Add(label2);
            Controls.Add(panel5);
            Controls.Add(Deskripsi);
            Controls.Add(label1);
            Controls.Add(panel3);
            Controls.Add(AlamatLoc);
            Controls.Add(textbox);
            Controls.Add(panel1);
            Controls.Add(NamaLoc);
            Controls.Add(label3);
            Controls.Add(PilihGambar);
            Controls.Add(GambarPilih);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MasterLocWisata";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MasterLocWisata";
            Load += MasterLocWisata_Load;
            ((System.ComponentModel.ISupportInitialize)GambarPilih).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox GambarPilih;
        private Button PilihGambar;
        private Label label3;
        private Label textbox;
        private Panel panel1;
        private Panel panel2;
        private TextBox NamaLoc;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private TextBox AlamatLoc;
        private Label label2;
        private Panel panel5;
        private Panel panel6;
        private TextBox Deskripsi;
        private Label label4;
        private Panel panel7;
        private Panel panel8;
        private TextBox HargaTic;
        private Label label5;
        private Panel panel9;
        private Panel panel10;
        private Button Tambah;
    }
}