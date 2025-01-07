using ManajemenProperti.Model.Entity;
using ManajemenProperti.Controller;
using ManajemenProperti.Model.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;


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
            InisialisasiListView();
            LoadDataProperti();
        }
        private void InisialisasiListView()
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
            // kosongkan listview
            lvwFormPenyewa.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfProperti = controller.readAllProperti();
            // ekstrak objek mhs dari collection
            foreach (var prp in listOfProperti)
            {
                var noUrut = lvwFormPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prp.Nama);
                item.SubItems.Add(prp.Harga_Sewa.ToString());
                item.SubItems.Add(prp.Stok.ToString());
                item.SubItems.Add(prp.PropertiID.ToString());
                // tampilkan data mhs ke listview
                lvwFormPenyewa.Items.Add(item);
            }
        }

        private void lvwFormPenyewa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFormPenyewa.SelectedItems.Count > 0)
            {
                var selectedIndex = lvwFormPenyewa.SelectedItems[0].Index;
                var selectedProperti = listOfProperti[selectedIndex];

                MessageBox.Show($"Nama: {selectedProperti.Nama}\n" +
                                $"Harga Sewa: {selectedProperti.Harga_Sewa}\n" +
                                $"Stok: {selectedProperti.Stok}\n" +
                                $"ID Properti: {selectedProperti.PropertiID}",
                                "Properti Detail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormPenyewa_Load(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            // kosongkan listview
            lvwFormPenyewa.Items.Clear();
            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfProperti = controller.readByNama(searchField.Text);
            // ekstrak objek mhs dari collection
            foreach (var prp in listOfProperti)
            {
                var noUrut = lvwFormPenyewa.Items.Count + 1;
                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prp.Nama);
                item.SubItems.Add(prp.Harga_Sewa.ToString());
                item.SubItems.Add(prp.Stok.ToString());
                item.SubItems.Add(prp.PropertiID.ToString());
                // tampilkan data mhs ke listview
                lvwFormPenyewa.Items.Add(item);
            }
        }
    }
}
