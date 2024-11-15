namespace Pariwisata
{
    partial class LocDetail
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
            panel2 = new Panel();
            panel1 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            Gambar = new PictureBox();
            NamaLoc = new ReaLTaiizor.Controls.AloneTextBox();
            AlamatLoc = new ReaLTaiizor.Controls.AloneTextBox();
            Des = new ReaLTaiizor.Controls.AloneTextBox();
            HargaTic = new ReaLTaiizor.Controls.AloneTextBox();
            Back = new ReaLTaiizor.Controls.Button();
            panel10 = new Panel();
            panel9 = new Panel();
            Kategori = new ReaLTaiizor.Controls.AloneTextBox();
            Edit = new ReaLTaiizor.Controls.Button();
            Delete = new ReaLTaiizor.Controls.Button();
            UbahGambar = new ReaLTaiizor.Controls.Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Gambar).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 117, 214);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 2);
            panel2.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 117, 124);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(137, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(425, 2);
            panel1.TabIndex = 40;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 117, 214);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(305, 2);
            panel4.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(0, 117, 124);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(137, 117);
            panel3.Name = "panel3";
            panel3.Size = new Size(425, 2);
            panel3.TabIndex = 43;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 117, 214);
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(305, 2);
            panel6.TabIndex = 10;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(0, 117, 124);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(137, 224);
            panel5.Name = "panel5";
            panel5.Size = new Size(425, 2);
            panel5.TabIndex = 46;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(0, 117, 214);
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(305, 2);
            panel8.TabIndex = 10;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel7.BackColor = Color.FromArgb(0, 117, 124);
            panel7.Controls.Add(panel8);
            panel7.Location = new Point(137, 314);
            panel7.Name = "panel7";
            panel7.Size = new Size(425, 2);
            panel7.TabIndex = 49;
            // 
            // Gambar
            // 
            Gambar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            Gambar.Location = new Point(137, 327);
            Gambar.Name = "Gambar";
            Gambar.Size = new Size(425, 114);
            Gambar.SizeMode = PictureBoxSizeMode.Zoom;
            Gambar.TabIndex = 51;
            Gambar.TabStop = false;
            // 
            // NamaLoc
            // 
            NamaLoc.BackColor = Color.Transparent;
            NamaLoc.EnabledCalc = true;
            NamaLoc.Font = new Font("Segoe UI", 9F);
            NamaLoc.ForeColor = Color.FromArgb(124, 133, 142);
            NamaLoc.Location = new Point(137, 12);
            NamaLoc.MaxLength = 32767;
            NamaLoc.MultiLine = false;
            NamaLoc.Name = "NamaLoc";
            NamaLoc.ReadOnly = true;
            NamaLoc.Size = new Size(425, 29);
            NamaLoc.TabIndex = 52;
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
            AlamatLoc.Location = new Point(137, 55);
            AlamatLoc.MaxLength = 32767;
            AlamatLoc.MultiLine = true;
            AlamatLoc.Name = "AlamatLoc";
            AlamatLoc.ReadOnly = true;
            AlamatLoc.Size = new Size(425, 56);
            AlamatLoc.TabIndex = 53;
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
            Des.Location = new Point(137, 132);
            Des.MaxLength = 32767;
            Des.MultiLine = true;
            Des.Name = "Des";
            Des.ReadOnly = true;
            Des.Size = new Size(425, 86);
            Des.TabIndex = 54;
            Des.Text = "Deskripsi";
            Des.TextAlign = HorizontalAlignment.Left;
            Des.UseSystemPasswordChar = false;
            // 
            // HargaTic
            // 
            HargaTic.BackColor = Color.Transparent;
            HargaTic.EnabledCalc = true;
            HargaTic.Font = new Font("Segoe UI", 9F);
            HargaTic.ForeColor = Color.FromArgb(124, 133, 142);
            HargaTic.Location = new Point(137, 279);
            HargaTic.MaxLength = 32767;
            HargaTic.MultiLine = false;
            HargaTic.Name = "HargaTic";
            HargaTic.ReadOnly = true;
            HargaTic.Size = new Size(425, 29);
            HargaTic.TabIndex = 55;
            HargaTic.Text = "Harga Tiket";
            HargaTic.TextAlign = HorizontalAlignment.Left;
            HargaTic.UseSystemPasswordChar = false;
            // 
            // Back
            // 
            Back.BackColor = Color.Transparent;
            Back.BorderColor = Color.FromArgb(32, 34, 37);
            Back.Cursor = Cursors.Hand;
            Back.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            Back.EnteredColor = Color.FromArgb(32, 34, 37);
            Back.Font = new Font("Microsoft Sans Serif", 12F);
            Back.Image = null;
            Back.ImageAlign = ContentAlignment.MiddleLeft;
            Back.InactiveColor = Color.FromArgb(32, 34, 37);
            Back.Location = new Point(12, 398);
            Back.Name = "Back";
            Back.PressedBorderColor = Color.FromArgb(165, 37, 37);
            Back.PressedColor = Color.FromArgb(165, 37, 37);
            Back.Size = new Size(120, 40);
            Back.TabIndex = 56;
            Back.Text = "Back";
            Back.TextAlignment = StringAlignment.Center;
            Back.Click += Back_Click;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(0, 117, 214);
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(305, 2);
            panel10.TabIndex = 10;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel9.BackColor = Color.FromArgb(0, 117, 124);
            panel9.Controls.Add(panel10);
            panel9.Location = new Point(137, 267);
            panel9.Name = "panel9";
            panel9.Size = new Size(425, 2);
            panel9.TabIndex = 57;
            // 
            // Kategori
            // 
            Kategori.BackColor = Color.Transparent;
            Kategori.EnabledCalc = true;
            Kategori.Font = new Font("Segoe UI", 9F);
            Kategori.ForeColor = Color.FromArgb(124, 133, 142);
            Kategori.Location = new Point(137, 232);
            Kategori.MaxLength = 32767;
            Kategori.MultiLine = false;
            Kategori.Name = "Kategori";
            Kategori.ReadOnly = true;
            Kategori.Size = new Size(425, 29);
            Kategori.TabIndex = 58;
            Kategori.Text = "Kategori";
            Kategori.TextAlign = HorizontalAlignment.Left;
            Kategori.UseSystemPasswordChar = false;
            // 
            // Edit
            // 
            Edit.BackColor = Color.Transparent;
            Edit.BorderColor = Color.FromArgb(32, 34, 37);
            Edit.Cursor = Cursors.Hand;
            Edit.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            Edit.EnteredColor = Color.FromArgb(32, 34, 37);
            Edit.Font = new Font("Microsoft Sans Serif", 12F);
            Edit.Image = null;
            Edit.ImageAlign = ContentAlignment.MiddleLeft;
            Edit.InactiveColor = Color.FromArgb(0, 117, 214);
            Edit.Location = new Point(578, 415);
            Edit.Name = "Edit";
            Edit.PressedBorderColor = Color.FromArgb(165, 37, 37);
            Edit.PressedColor = Color.FromArgb(165, 37, 37);
            Edit.Size = new Size(89, 26);
            Edit.TabIndex = 59;
            Edit.Text = "Edit";
            Edit.TextAlignment = StringAlignment.Center;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Transparent;
            Delete.BorderColor = Color.FromArgb(32, 34, 37);
            Delete.Cursor = Cursors.Hand;
            Delete.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            Delete.EnteredColor = Color.FromArgb(32, 34, 37);
            Delete.Font = new Font("Microsoft Sans Serif", 12F);
            Delete.Image = null;
            Delete.ImageAlign = ContentAlignment.MiddleLeft;
            Delete.InactiveColor = Color.FromArgb(165, 37, 37);
            Delete.Location = new Point(684, 415);
            Delete.Name = "Delete";
            Delete.PressedBorderColor = Color.FromArgb(0, 117, 214);
            Delete.PressedColor = Color.FromArgb(0, 117, 214);
            Delete.Size = new Size(89, 26);
            Delete.TabIndex = 60;
            Delete.Text = "Delete";
            Delete.TextAlignment = StringAlignment.Center;
            // 
            // UbahGambar
            // 
            UbahGambar.BackColor = Color.Transparent;
            UbahGambar.BorderColor = Color.FromArgb(32, 34, 37);
            UbahGambar.Cursor = Cursors.Hand;
            UbahGambar.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            UbahGambar.EnteredColor = Color.Black;
            UbahGambar.Font = new Font("Microsoft Sans Serif", 12F);
            UbahGambar.Image = null;
            UbahGambar.ImageAlign = ContentAlignment.MiddleLeft;
            UbahGambar.InactiveColor = Color.FromArgb(32, 34, 37);
            UbahGambar.Location = new Point(578, 383);
            UbahGambar.Name = "UbahGambar";
            UbahGambar.PressedBorderColor = Color.FromArgb(0, 117, 214);
            UbahGambar.PressedColor = Color.FromArgb(0, 117, 214);
            UbahGambar.Size = new Size(195, 26);
            UbahGambar.TabIndex = 61;
            UbahGambar.Text = "Ubah Gambar";
            UbahGambar.TextAlignment = StringAlignment.Center;
            // 
            // LocDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UbahGambar);
            Controls.Add(Delete);
            Controls.Add(Edit);
            Controls.Add(Kategori);
            Controls.Add(panel9);
            Controls.Add(Back);
            Controls.Add(HargaTic);
            Controls.Add(Des);
            Controls.Add(AlamatLoc);
            Controls.Add(NamaLoc);
            Controls.Add(Gambar);
            Controls.Add(panel7);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "LocDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LocDetail";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Gambar).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel5;
        private Panel panel8;
        private Panel panel7;
        private PictureBox Gambar;
        private ReaLTaiizor.Controls.AloneTextBox NamaLoc;
        private ReaLTaiizor.Controls.AloneTextBox AlamatLoc;
        private ReaLTaiizor.Controls.AloneTextBox Des;
        private ReaLTaiizor.Controls.AloneTextBox HargaTic;
        private ReaLTaiizor.Controls.Button Back;
        private Panel panel10;
        private Panel panel9;
        private ReaLTaiizor.Controls.AloneTextBox Kategori;
        private ReaLTaiizor.Controls.Button Edit;
        private ReaLTaiizor.Controls.Button Delete;
        private ReaLTaiizor.Controls.Button UbahGambar;
    }
}