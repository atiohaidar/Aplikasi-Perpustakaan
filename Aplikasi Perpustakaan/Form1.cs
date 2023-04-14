using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class AplikasiPerpustakaan : Form
    {
        public AplikasiPerpustakaan()
        {
            InitializeComponent();
        }

        private void AplikasiPerpustakaan_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLihatDaftarBuku_Click(object sender, EventArgs e)
        {
            DaftarBuku lihatDaftarBuku = new DaftarBuku();
            lihatDaftarBuku.Show();
        }

        private void btnRiwayatPeminjaman_Click(object sender, EventArgs e)
        {
            RiwayatPeminjaman riwayatPeminjaman = new RiwayatPeminjaman();
            riwayatPeminjaman.Show();
        }

        private void btnTambahBuku_Click(object sender, EventArgs e)
        {
            TambahBuku tambahBuku = new TambahBuku();
            tambahBuku.Show();
        }

        private void btnPinjamBuku_Click(object sender, EventArgs e)
        {
            PinjamBuku pinjamBuku = new PinjamBuku();
            pinjamBuku.Show();

        }
    }
}
