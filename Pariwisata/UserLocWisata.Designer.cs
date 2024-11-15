namespace Pariwisata
{
    partial class UserLocWisata
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
            Add = new ReaLTaiizor.Controls.Button();
            TampilData = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(Add);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 42);
            panel1.TabIndex = 0;
            // 
            // Add
            // 
            Add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Add.BackColor = Color.Transparent;
            Add.BorderColor = Color.FromArgb(32, 34, 37);
            Add.EnteredBorderColor = Color.FromArgb(0, 117, 214);
            Add.EnteredColor = Color.FromArgb(32, 34, 37);
            Add.Font = new Font("Microsoft Sans Serif", 12F);
            Add.Image = null;
            Add.ImageAlign = ContentAlignment.MiddleLeft;
            Add.InactiveColor = Color.FromArgb(32, 34, 37);
            Add.Location = new Point(744, 3);
            Add.Name = "Add";
            Add.PressedBorderColor = Color.FromArgb(0, 117, 214);
            Add.PressedColor = Color.FromArgb(0, 117, 214);
            Add.Size = new Size(93, 36);
            Add.TabIndex = 0;
            Add.Text = "Add";
            Add.TextAlignment = StringAlignment.Center;
            Add.Click += Add_Click;
            // 
            // TampilData
            // 
            TampilData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TampilData.BackColor = SystemColors.Control;
            TampilData.Location = new Point(0, 42);
            TampilData.Name = "TampilData";
            TampilData.Size = new Size(840, 464);
            TampilData.TabIndex = 1;
            // 
            // UserLocWisata
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 506);
            Controls.Add(TampilData);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserLocWisata";
            Text = "UserLocWisata";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel TampilData;
        private ReaLTaiizor.Controls.Button Add;
    }
}