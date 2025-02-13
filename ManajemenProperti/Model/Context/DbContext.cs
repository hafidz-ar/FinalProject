﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ManajemenProperti.Model.Context
{
    public class DbContext : IDisposable
    {
        // Deklarasi private field untuk menyimpan koneksi
        private MySqlConnection _conn;

        // Properti untuk mendapatkan koneksi
        public MySqlConnection Conn
        {
            get
            {
                // Jika koneksi belum dibuat atau sudah tertutup, buka koneksi baru
                if (_conn == null || _conn.State == ConnectionState.Closed)
                {
                    _conn = GetOpenConnection();
                }
                return _conn;
            }
        }

        // Method untuk membuka koneksi ke database
        private MySqlConnection GetOpenConnection()
        {
            MySqlConnection conn = null;
            try
            {
                // Connection string ke database MySQL
                string connectionString = "server=cbhtg.h.filess.io;user=manajemenproperti_paincapare;database=manajemenproperti_paincapare;port=3307;password=e4a0d2406606c5d53670de8b14130969420a4bc0";

                conn = new MySqlConnection(connectionString);
                conn.Open(); // Membuka koneksi
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika koneksi gagal
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
                throw new Exception("Error connecting to the database. See inner exception for details.", ex);
            }
            return conn;
        }

        // Method untuk membuang resource koneksi setelah digunakan
        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }

            GC.SuppressFinalize(this);
        }
    }
}
