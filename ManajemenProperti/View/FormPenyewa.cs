using ManajemenProperti.Model.Entity;
using ManajemenProperti.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ManajemenProperti.View
{
    public partial class FormPenyewa : Form
    {
        private List<Properti> listOfProperti = new List<Properti>();
        private PropertiController controller;

        public FormPenyewa()
        {
            InitializeComponent();
            controller = new PropertiController();
            InitializeListView();
            LoadDataProperti();
        }

        private void InitializeListView()
        {
            lvwFormPenyewa.View = System.Windows.Forms.View.Details;
            lvwFormPenyewa.FullRowSelect = true;
            lvwFormPenyewa.GridLines = true;

            lvwFormPenyewa.Columns.Add("No.", 30, HorizontalAlignment.Left);
            lvwFormPenyewa.Columns.Add("Nama", 120, HorizontalAlignment.Left);
            lvwFormPenyewa.Columns.Add("Harga Sewa", 100, HorizontalAlignment.Left);
            lvwFormPenyewa.Columns.Add("Stok", 70, HorizontalAlignment.Left);
            lvwFormPenyewa.Columns.Add("ID Properti", 70, HorizontalAlignment.Left);
        }

        private void LoadDataProperti()
        {
            lvwFormPenyewa.Items.Clear();
            listOfProperti = controller.readAllProperti();

            foreach (var prp in listOfProperti)
            {
                var noUrut = lvwFormPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prp.Nama);
                item.SubItems.Add(prp.Harga_Sewa.ToString("C", new System.Globalization.CultureInfo("id-ID"))); // Format sebagai mata uang
                item.SubItems.Add(prp.Stok.ToString());
                item.SubItems.Add(prp.PropertiID.ToString());
                lvwFormPenyewa.Items.Add(item);
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchField.Text))
            {
                MessageBox.Show("Masukkan nama properti untuk mencari.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lvwFormPenyewa.Items.Clear();
            listOfProperti = controller.readByNama(searchField.Text);

            if (listOfProperti == null || !listOfProperti.Any())
            {
                MessageBox.Show("Properti tidak ditemukan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var prp in listOfProperti)
            {
                var noUrut = lvwFormPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prp.Nama);
                item.SubItems.Add(prp.Harga_Sewa.ToString("C", new System.Globalization.CultureInfo("id-ID"))); // Format sebagai mata uang
                item.SubItems.Add(prp.Stok.ToString());
                item.SubItems.Add(prp.PropertiID.ToString());
                lvwFormPenyewa.Items.Add(item);
            }
        }

        private void btnSewaPrp_Click(object sender, EventArgs e)
        {
            if (lvwFormPenyewa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Pilih properti yang ingin disewa.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedIndex = lvwFormPenyewa.SelectedItems[0].Index;
            var selectedProperti = listOfProperti[selectedIndex];

            if (selectedProperti.Stok <= 0)
            {
                MessageBox.Show("Properti ini sudah habis stoknya.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan form untuk mengisi data transaksi
            using (var formTransaksi = new FormTransaksi())
            {
                var dialogResult = formTransaksi.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    // Ambil data dari form Transaksi
                    var tglSewa = formTransaksi.TglSewa;
                    var lamaSewa = formTransaksi.LamaSewa;
                    var username = UserSession.Username; // Ambil username dari session

                    // Tambahkan transaksi
                    Transaksi transaksi = new Transaksi
                    {
                        PropertiID = selectedProperti.PropertiID,
                        Username = username, // Gunakan username dari session
                        Tgl_Sewa = tglSewa,
                        Lama_Sewa = lamaSewa,
                        Keterangan = "Succesfull"
                    };

                    // Simpan transaksi
                    var transaksiController = new TransaksiController();
                    var createResult = transaksiController.createTransaksi(transaksi);

                    if (createResult > 0)
                    {
                        // Update stok properti setelah transaksi sukses
                        selectedProperti.Stok -= 1;
                        var updateResult = controller.updateProperti(selectedProperti);

                        if (updateResult > 0)
                        {
                            MessageBox.Show("Properti berhasil disewa.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDataProperti();
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui stok properti.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Gagal mencatat transaksi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnTambahPrp_Click(object sender, EventArgs e)
        {
            using (var formTambahProperti = new FormTambahProperti())
            {
                if (formTambahProperti.ShowDialog() == DialogResult.OK)
                {
                    LoadDataProperti();
                }
            }
        }

        private void lvwFormPenyewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFormPenyewa.SelectedItems.Count > 0)
            {
                var selectedIndex = lvwFormPenyewa.SelectedItems[0].Index;
                var selectedProperti = listOfProperti[selectedIndex];

                MessageBox.Show($"Nama: {selectedProperti.Nama}\n" +
                                $"Harga Sewa: {selectedProperti.Harga_Sewa:N0}\n" +
                                $"Stok: {selectedProperti.Stok}\n" +
                                $"ID Properti: {selectedProperti.PropertiID}",
                                "Detail Properti", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRiwayatTrx_Click(object sender, EventArgs e)
        {
            FormRiwayatTransaksi formRiwayatTransaksi = new FormRiwayatTransaksi();
            formRiwayatTransaksi.Show();
            this.Hide();
        }
        private void FormPenyewa_Load(object sender, EventArgs e)
        {
        }
    }
}
