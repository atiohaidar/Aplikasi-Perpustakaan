using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class DaftarBuku : Form
    {
        public DaftarBuku()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditBuku_Click(object sender, EventArgs e)
        {
            UpdateBuku updateBuku = new UpdateBuku();
            updateBuku.ShowDialog();
        }

        private void btnDeleteBuku_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah anda akan mengapus buku ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        }
    }
}
