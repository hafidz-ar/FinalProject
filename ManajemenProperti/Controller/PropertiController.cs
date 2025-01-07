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
    public class PropertiController
    {
        // deklarasi objek Repository untuk menjalankan operasi CRUD
        private PropertiRepository _repository;

        /// <summary>
        /// Method untuk menampilkan data mahasiwa berdasarkan nama
        /// </summary>
        /// <param name="nama"></param>
        /// <returns></returns>
        public List<Properti> readByNama(string nama)
        {
            // membuat objek collection
            List<Properti> list = new List<Properti>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PropertiRepository(context);

                // panggil method ReadByNama yang ada di dalam class repository
                list = _repository.readByNama(nama);
            }

            return list;
        }

        /// <summary>
        /// Method untuk menampilkan semua data mahasiswa
        /// </summary>
        /// <returns></returns>
        public List<Properti> readAllProperti()
        {
            // membuat objek collection
            List<Properti> list = new List<Properti>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PropertiRepository(context);

                // panggil method ReadAll yang ada di dalam class repository
                list = _repository.readAllProperti();
            }

            return list;
        }

        public int createProperti(Properti prp)
        {
            int result = 0;

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(prp.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek harga sewa yang diinputkan tidak boleh kosong atau kurang dari atau sama dengan 0
            if (prp.Harga_Sewa <= 0)
            {
                MessageBox.Show("Harga Sewa harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek stok yang diinputkan tidak boleh kosong atau kurang dari atau sama dengan 0
            if (prp.Stok <= 0)
            {
                MessageBox.Show("Stok harus diisi dan lebih besar dari 0 !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // PropertiID tidak perlu diisi karena akan otomatis di-generate oleh database
            prp.PropertiID = 0;  // Pastikan PropertiID tidak diisi, jika perlu set 0

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PropertiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.createProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil disimpan !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data properti gagal disimpan !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int updateProperti(Properti prp)
        {
            int result = 0;

            // cek npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(prp.Nama))
            {
                MessageBox.Show("Nama harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek nama yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(prp.Harga_Sewa.ToString()))
            {
                MessageBox.Show("Harga Sewa harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // cek angkatan yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(prp.Stok.ToString()))
            {
                MessageBox.Show("Stok harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(prp.PropertiID.ToString()))
            {
                MessageBox.Show("PropertiID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new PropertiRepository(context);

                // panggil method Create class repository untuk menambahkan data
                result = _repository.createProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil diupdate !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data properti gagal diupdate !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }

        public int deleteProperti(Properti prp)
        {
            int result = 0;

            // cek nilai npm yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(prp.PropertiID.ToString()))
            {
                MessageBox.Show("PropertiID harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new PropertiRepository(context);

                // panggil method Delete class repository untuk menghapus data
                result = _repository.deleteProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil dihapus !", "Informasi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Data properti gagal dihapus !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return result;
        }
    }
}
