using ManajemenProperti.Model.Entity;
using ManajemenProperti.Model.Repository;
using ManajemenProperti.Model.Context;  // Mengimpor DbContext
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManajemenProperti.Controller
{
    public class TransaksiController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private TransaksiRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data transaksi berdasarkan keterangan
        /// </summary>
        /// <param name="keterangan"></param>
        /// <returns></returns>
        public List<Transaksi> readByPropertiID(int PropertiID)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadByPropertiID yang ada di dalam class repository
                list = _repository.readByPropertiID(PropertiID);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data transaksi
        /// </summary>
        /// <returns></returns>
        public List<Transaksi> readAllTransaksi()
        {
            List<Transaksi> list = new List<Transaksi>();

            using (DbContext context = new DbContext())
            {
                _repository = new TransaksiRepository(context);
                list = _repository.readAllTransaksi();
            }

            return list;
        }

        public int createTransaksi(Transaksi trx)
        {
            int result = 0;

            // Validasi input
            if (!ValidateTransaksi(trx))
                return 0;

            trx.TransaksiID = 0;  // Pastikan TransaksiID tidak diisi, jika perlu set 0

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.createTransaksi(trx);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data transaksi gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int updateTransaksi(Transaksi trx)
        {
            int result = 0;

            // Validasi input
            if (!ValidateTransaksi(trx))
                return 0;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.updateTransaksi(trx);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int deleteTransaksi(Transaksi trx)
        {
            int result = 0;

            // cek nilai transaksiID yang diinputkan tidak boleh kosong
            if (trx.TransaksiID <= 0)
            {
                MessageBox.Show("TransaksiID harus diisi dengan ID yang valid !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.deleteTransaksi(trx);
            }

            if (result > 0)
            {
                MessageBox.Show("Data transaksi berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data transaksi gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        // Helper function to validate Transaksi
        private bool ValidateTransaksi(Transaksi trx)
        {
            if (string.IsNullOrWhiteSpace(trx.Username))
            {
                MessageBox.Show("Username harus diisi dengan ID yang valid !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (trx.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
    }
}
