using ManajemenProperti.Model.Entity;
using ManajemenProperti.Model.Repository;
using ManajemenProperti.Model.Context;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ManajemenProperti.Controller
{
    public class PropertiController
    {
        private PropertiRepository _repository;

        public List<Properti> readByNama(string nama)
        {
            List<Properti> list = new List<Properti>();

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                list = _repository.readByNama(nama);
            }

            return list;
        }

        public List<Properti> readAllProperti()
        {
            List<Properti> list = new List<Properti>();

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                list = _repository.readAllProperti();
            }

            return list;
        }

        public int createProperti(Properti prp)
        {
            int result = 0;

            // Validasi data
            if (string.IsNullOrEmpty(prp.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.Harga_Sewa <= 0)
            {
                MessageBox.Show("Harga Sewa harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.Stok <= 0)
            {
                MessageBox.Show("Stok harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                result = _repository.createProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data properti gagal disimpan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int updateProperti(Properti prp)
        {
            int result = 0;

            // Validasi data
            if (string.IsNullOrEmpty(prp.Nama))
            {
                MessageBox.Show("Nama harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.Harga_Sewa <= 0)
            {
                MessageBox.Show("Harga Sewa harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.Stok < 0)
            {
                MessageBox.Show("Stok tidak boleh negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                result = _repository.updateProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data properti gagal diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int deleteProperti(Properti prp)
        {
            int result = 0;

            // Validasi PropertiID
            if (prp.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                result = _repository.deleteProperti(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Data properti berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data properti gagal dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public int updateStok(Properti prp)
        {
            int result = 0;

            // Validasi stok dan PropertiID
            if (prp.Stok < 0)
            {
                MessageBox.Show("Stok tidak boleh negatif!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (prp.PropertiID <= 0)
            {
                MessageBox.Show("PropertiID tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PropertiRepository(context);
                result = _repository.updateStok(prp);
            }

            if (result > 0)
            {
                MessageBox.Show("Stok berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Stok gagal diperbarui!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
    }
}
