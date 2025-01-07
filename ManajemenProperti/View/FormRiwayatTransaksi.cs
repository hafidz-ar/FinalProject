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
        public FormRiwayatTransaksi()
        {
            InitializeComponent();
        }
        private void InisialisasiListView()
        {
            lvwRiwayatTransaksi.View = System.Windows.Forms.View.Details;
            lvwRiwayatTransaksi.FullRowSelect = true;
            lvwRiwayatTransaksi.GridLines = true;

            lvwRiwayatTransaksi.Columns.Add("No.", 30, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Nama Properti", 150, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Username Penyewa", 150, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("PropertiID", 70, HorizontalAlignment.Left);
            lvwRiwayatTransaksi.Columns.Add("Keterangan", 150, HorizontalAlignment.Left);
        }
        private void btnRiwayatTrx_Click(object sender, EventArgs e)
        {

        }
    }
}
