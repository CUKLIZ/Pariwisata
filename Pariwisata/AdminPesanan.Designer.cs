namespace Pariwisata
{
    partial class AdminPesanan
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
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            TerimaPesan = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(528, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(546, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 167);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TerimaPesan
            // 
            TerimaPesan.BackColor = Color.Transparent;
            TerimaPesan.BorderColor = Color.FromArgb(32, 34, 37);
            TerimaPesan.Cursor = Cursors.Hand;
            TerimaPesan.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            TerimaPesan.EnteredColor = Color.FromArgb(32, 34, 37);
            TerimaPesan.Font = new Font("Microsoft Sans Serif", 12F);
            TerimaPesan.Image = null;
            TerimaPesan.ImageAlign = ContentAlignment.MiddleLeft;
            TerimaPesan.InactiveColor = Color.FromArgb(0, 117, 214);
            TerimaPesan.Location = new Point(584, 208);
            TerimaPesan.Name = "TerimaPesan";
            TerimaPesan.PressedBorderColor = Color.FromArgb(165, 37, 37);
            TerimaPesan.PressedColor = Color.FromArgb(165, 37, 37);
            TerimaPesan.Size = new Size(166, 26);
            TerimaPesan.TabIndex = 64;
            TerimaPesan.Text = "Terima Pesan";
            TerimaPesan.TextAlignment = StringAlignment.Center;
            // 
            // AdminPesanan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TerimaPesan);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AdminPesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminPesanan";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.Button TerimaPesan;
    }
}