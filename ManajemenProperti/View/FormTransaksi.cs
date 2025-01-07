using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManajemenProperti.View
{
    public partial class FormTransaksi : Form
    {
        public DateTime TglSewa { get; set; }
        public int LamaSewa { get; set; }

        public FormTransaksi()
        {
            InitializeComponent();
        }

        private void FormTransaksi_Load(object sender, EventArgs e)
        {
            dtpTglSewa.Value = DateTime.Today; // Set default to today
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            // Validasi input
            if (dtpTglSewa.Value == DateTime.MinValue)
            {
                MessageBox.Show("Tanggal sewa tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudLamaSewa.Value <= 0)
            {
                MessageBox.Show("Lama sewa harus lebih dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Menyimpan data input
            TglSewa = dtpTglSewa.Value;
            LamaSewa = (int)nudLamaSewa.Value;

            DialogResult = DialogResult.OK; // Menandakan data valid dan siap disimpan
            this.Close();
        }
    }
}
