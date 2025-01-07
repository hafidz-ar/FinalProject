using ManajemenProperti.Model.Entity;
using ManajemenProperti.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Controller
{
    public class TransaksiController
    {
        private readonly TransaksiRepository _transaksiRepository;

        public TransaksiController()
        {
            _transaksiRepository = new TransaksiRepository();
        }

        // Mendapatkan semua transaksi
        public List<Transaksi> GetAllTransaksi()
        {
            try
            {
                return _transaksiRepository.GetAll();
            }
            catch (Exception ex)
            {
                // Menangani kesalahan dan mengembalikan pesan error
                Console.WriteLine($"Error: {ex.Message}");
                return new List<Transaksi>(); // Mengembalikan list kosong jika terjadi error
            }
        }

        // Mendapatkan transaksi berdasarkan TransaksiID
        public Transaksi GetTransaksiById(int transaksiId)
        {
            try
            {
                return _transaksiRepository.GetById(transaksiId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null; // Mengembalikan null jika terjadi error
            }
        }

        // Menambahkan transaksi baru
        public void AddTransaksi(Transaksi transaksi)
        {
            try
            {
                _transaksiRepository.Add(transaksi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Memperbarui informasi transaksi
        public void UpdateTransaksi(Transaksi transaksi)
        {
            try
            {
                _transaksiRepository.Update(transaksi);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        // Menghapus transaksi berdasarkan TransaksiID
        public void DeleteTransaksi(int transaksiId)
        {
            try
            {
                _transaksiRepository.Delete(transaksiId);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
