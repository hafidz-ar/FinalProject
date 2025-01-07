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
        public List<Transaksi> ReadByKeterangan(string keterangan)
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadByKeterangan yang ada di dalam class repository
                list = _repository.ReadByNama(keterangan);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data transaksi
        /// </summary>
        /// <returns></returns>
        public List<Transaksi> ReadAll()
        {
            // membuat objek collection
            List<Transaksi> list = new List<Transaksi>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new TransaksiRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }

        public int Create(Transaksi trx)
        {
            int result = 0;

            // cek pengguna yang diinputkan tidak boleh kosong
            if (trx.Username <= 0)
            {
                MessageBox.Show("Users harus diisi dengan ID yang valid !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek properti ID yang diinputkan tidak boleh kosong atau kurang dari atau sama dengan 0
            if (trx.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek tanggal sewa yang diinputkan tidak boleh kosong
            if (trx.Tgl_Sewa == DateTime.MinValue)
            {
                MessageBox.Show("Tanggal Sewa harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek lama sewa yang diinputkan tidak boleh kurang dari atau sama dengan 0
            if (trx.Lama_Sewa <= 0)
            {
                MessageBox.Show("Lama Sewa harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // PropertiID tidak perlu diisi karena akan otomatis di-generate oleh database
            trx.TransaksiID = 0;  // Pastikan TransaksiID tidak diisi, jika perlu set 0

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.Create(trx);
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

        public int Update(Transaksi trx)
        {
            int result = 0;

            // cek pengguna yang diinputkan tidak boleh kosong
            if (trx.Username <= 0)
            {
                MessageBox.Show("Users harus diisi dengan ID yang valid !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek properti ID yang diinputkan tidak boleh kosong atau kurang dari atau sama dengan 0
            if (trx.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek tanggal sewa yang diinputkan tidak boleh kosong
            if (trx.Tgl_Sewa == DateTime.MinValue)
            {
                MessageBox.Show("Tanggal Sewa harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek lama sewa yang diinputkan tidak boleh kurang dari atau sama dengan 0
            if (trx.Lama_Sewa <= 0)
            {
                MessageBox.Show("Lama Sewa harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new TransaksiRepository(context);

                // panggil method Update class repository untuk mengupdate data
                result = _repository.Update(trx);
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

        public int Delete(Transaksi trx)
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
                result = _repository.Delete(trx);
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
    }
}
