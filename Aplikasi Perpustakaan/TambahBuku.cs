﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class TambahBuku : Form
    {
        public TambahBuku()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
