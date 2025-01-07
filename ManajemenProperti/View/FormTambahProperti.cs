using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using ManajemenProperti.Controller;
using ManajemenProperti.Model.Entity;

namespace ManajemenProperti.View
{
    public partial class FormTambahProperti : Form
    {
        private PropertiController controller;

        public FormTambahProperti()
        {
            InitializeComponent();
            controller = new PropertiController();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // Ambil data dari form input
            string namaProperti = txtNama.Text.Trim();

            // Parsing harga sewa dan stok
            decimal hargaSewa;
            int stok;

            // Cek apakah harga sewa valid
            if (!decimal.TryParse(txtHargaSewa.Text, out hargaSewa))
            {
                MessageBox.Show("Harga sewa tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cek apakah stok valid
            if (!int.TryParse(txtStok.Text, out stok))
            {
                MessageBox.Show("Stok tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input
            if (string.IsNullOrEmpty(namaProperti))
            {
                MessageBox.Show("Nama properti tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hargaSewa <= 0)
            {
                MessageBox.Show("Harga sewa harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stok <= 0)
            {
                MessageBox.Show("Stok harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Membuat objek properti untuk disimpan
            Properti properti = new Properti
            {
                Nama = namaProperti,
                Harga_Sewa = hargaSewa,
                Stok = stok
            };

            // Menggunakan controller untuk menyimpan data
            int result = controller.createProperti(properti);

            // Jika berhasil, tutup form ini
            if (result > 0)
            {
                MessageBox.Show("Properti berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan properti!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
