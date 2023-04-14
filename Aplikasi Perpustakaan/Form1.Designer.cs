namespace Aplikasi_Perpustakaan
{
    partial class AplikasiPerpustakaan
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnLihatDaftarBuku = new System.Windows.Forms.Button();
            this.btnRiwayatPeminjaman = new System.Windows.Forms.Button();
            this.btnTambahBuku = new System.Windows.Forms.Button();
            this.btnPinjamBuku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Pepustakaan";
            // 
            // btnLihatDaftarBuku
            // 
            this.btnLihatDaftarBuku.Location = new System.Drawing.Point(209, 96);
            this.btnLihatDaftarBuku.Name = "btnLihatDaftarBuku";
            this.btnLihatDaftarBuku.Size = new System.Drawing.Size(135, 37);
            this.btnLihatDaftarBuku.TabIndex = 1;
            this.btnLihatDaftarBuku.Text = "Lihat Daftar Buku";
            this.btnLihatDaftarBuku.UseVisualStyleBackColor = true;
            this.btnLihatDaftarBuku.Click += new System.EventHandler(this.btnLihatDaftarBuku_Click);
            // 
            // btnRiwayatPeminjaman
            // 
            this.btnRiwayatPeminjaman.Location = new System.Drawing.Point(464, 96);
            this.btnRiwayatPeminjaman.Name = "btnRiwayatPeminjaman";
            this.btnRiwayatPeminjaman.Size = new System.Drawing.Size(135, 37);
            this.btnRiwayatPeminjaman.TabIndex = 2;
            this.btnRiwayatPeminjaman.Text = "Riwayat Peminjaman";
            this.btnRiwayatPeminjaman.UseVisualStyleBackColor = true;
            this.btnRiwayatPeminjaman.Click += new System.EventHandler(this.btnRiwayatPeminjaman_Click);
            // 
            // btnTambahBuku
            // 
            this.btnTambahBuku.Location = new System.Drawing.Point(209, 196);
            this.btnTambahBuku.Name = "btnTambahBuku";
            this.btnTambahBuku.Size = new System.Drawing.Size(135, 37);
            this.btnTambahBuku.TabIndex = 3;
            this.btnTambahBuku.Text = "Tambah Buku";
            this.btnTambahBuku.UseVisualStyleBackColor = true;
            this.btnTambahBuku.Click += new System.EventHandler(this.btnTambahBuku_Click);
            // 
            // btnPinjamBuku
            // 
            this.btnPinjamBuku.Location = new System.Drawing.Point(464, 196);
            this.btnPinjamBuku.Name = "btnPinjamBuku";
            this.btnPinjamBuku.Size = new System.Drawing.Size(135, 37);
            this.btnPinjamBuku.TabIndex = 4;
            this.btnPinjamBuku.Text = "Pinjam Buku";
            this.btnPinjamBuku.UseVisualStyleBackColor = true;
            this.btnPinjamBuku.Click += new System.EventHandler(this.btnPinjamBuku_Click);
            // 
            // AplikasiPerpustakaan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPinjamBuku);
            this.Controls.Add(this.btnTambahBuku);
            this.Controls.Add(this.btnRiwayatPeminjaman);
            this.Controls.Add(this.btnLihatDaftarBuku);
            this.Controls.Add(this.label1);
            this.Name = "AplikasiPerpustakaan";
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.AplikasiPerpustakaan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLihatDaftarBuku;
        private System.Windows.Forms.Button btnRiwayatPeminjaman;
        private System.Windows.Forms.Button btnTambahBuku;
        private System.Windows.Forms.Button btnPinjamBuku;
    }
}
