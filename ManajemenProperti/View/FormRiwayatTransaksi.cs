using ManajemenProperti.Controller;
using ManajemenProperti.Model.Entity;
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
    public partial class FormRiwayatTransaksi : Form
    {
        private List<Transaksi> listOfTransaksi = new List<Transaksi>();
        private TransaksiController controller;
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
            controller = new TransaksiController();
            InisialisasiListView();
            LoadDataTransaksi();
        }
        private void InisialisasiListView()
        {
            lvwRiwayatTransaksi.View = System.Windows.Forms.View.Details;
            lvwRiwayatTransaksi.FullRowSelect = true;
            lvwRiwayatTransaksi.GridLines = true;

            lvwRiwayatTransaksi.Columns.Add("No.", 30, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Transaksi ID", 70, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Penyewa", 70, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Properti ID", 70, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Tanggal Sewa", 120, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Lama Sewa", 70, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Keterangan", 70, HorizontalAlignment.Left);
        }
        private void LoadDataTransaksi()
        {
            // Check if ListView is properly initialized
            if (lvwRiwayatTransaksi == null)
            {
                MessageBox.Show("ListView is not initialized.");
                return;
            }

            lvwRiwayatTransaksi.Items.Clear();

            // Ensure listOfTransaksi is initialized and contains data
            listOfTransaksi = controller.readAllTransaksi();

            if (listOfTransaksi == null || listOfTransaksi.Count == 0)
            {
                MessageBox.Show("No transactions found.");
                return;
            }

            foreach (var trx in listOfTransaksi)
            {
                var noUrut = lvwRiwayatTransaksi.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(trx.TransaksiID.ToString());
                item.SubItems.Add(trx.Username);
                item.SubItems.Add(trx.PropertiID.ToString());
                item.SubItems.Add(trx.Tgl_Sewa.ToString());
                item.SubItems.Add(trx.Lama_Sewa.ToString());
                item.SubItems.Add(trx.Keterangan.ToString());
                lvwRiwayatTransaksi.Items.Add(item);
            }
        }


        private void btnKembali_Click(object sender, EventArgs e)
        {
            FormPenyewa formPenyewa = new FormPenyewa();
            formPenyewa.Show();
            this.Hide();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected an item
            if (lvwRiwayatTransaksi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Silakan pilih transaksi yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected transaction's details
            var selectedItem = lvwRiwayatTransaksi.SelectedItems[0];
            int transaksiID = int.Parse(selectedItem.SubItems[1].Text); // Assuming the TransaksiID is in the second column

            // Create the Transaksi object to pass to the controller
            var transaksiToDelete = new Transaksi
            {
                TransaksiID = transaksiID
            };

            // Confirm deletion
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                // Call the controller to delete the transaction
                int result = controller.deleteTransaksi(transaksiToDelete);

                if (result > 0)
                {
                    MessageBox.Show("Transaksi berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Reload the data to reflect the deletion
                    LoadDataTransaksi();
                }
                else
                {
                    MessageBox.Show("Gagal menghapus transaksi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
