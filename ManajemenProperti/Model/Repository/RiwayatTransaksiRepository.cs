using ManajemenProperti.Model.Context;
using ManajemenProperti.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace ManajemenProperti.Model.Repository
{
    public class RiwayatTransaksiRepository
    {
        private MySqlConnection _conn;

        // Constructor untuk menginisialisasi koneksi dengan DbContext
        public RiwayatTransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        // Menambahkan transaksi baru
        public int createTransaksi(RiwayatTransaksi transaksi)
        {
            int result = 0;

            string sql = @"INSERT INTO Transaksi (Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan) 
                           VALUES (@Username, @PropertiID, @Tgl_Sewa, @Lama_Sewa, @Keterangan)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", transaksi.Username);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Keterangan", transaksi.Keterangan);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        // Memperbarui transaksi
        public int updateTransaksi(RiwayatTransaksi transaksi)
        {
            int result = 0;

            string sql = @"UPDATE Transaksi SET Username = @Username, PropertiID = @PropertiID, Tgl_Sewa = @Tgl_Sewa, Lama_Sewa = @Lama_Sewa, Keterangan = @Keterangan 
                           WHERE TransaksiID = @TransaksiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", transaksi.Username);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Keterangan", transaksi.Keterangan);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksi.TransaksiID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        // Menghapus transaksi
        public int deleteTransaksi(RiwayatTransaksi transaksi)
        {
            int result = 0;

            string sql = @"DELETE FROM Transaksi WHERE TransaksiID = @TransaksiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@TransaksiID", transaksi.TransaksiID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        // Membaca semua transaksi
        public List<RiwayatTransaksi> readAllTransaksi()
        {
            List<RiwayatTransaksi> list = new List<RiwayatTransaksi>();

            try
            {
                string sql = @"SELECT Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID 
                               FROM Transaksi 
                               ORDER BY TransaksiID";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            RiwayatTransaksi trx = new RiwayatTransaksi
                            {
                                Username = dtr["Username"].ToString(),
                                PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0,
                                Keterangan = dtr["Keterangan"] != DBNull.Value ? dtr["Keterangan"].ToString() : string.Empty,
                                TransaksiID = dtr["TransaksiID"] != DBNull.Value ? Convert.ToInt32(dtr["TransaksiID"]) : 0
                            };

                            list.Add(trx);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;
        }

        // Membaca transaksi berdasarkan PropertiID
        public List<RiwayatTransaksi> readByPropertiID(int PropertiID)
        {
            List<RiwayatTransaksi> list = new List<RiwayatTransaksi>();

            try
            {
                string sql = @"SELECT Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID
                               FROM Transaksi
                               WHERE PropertiID = @PropertiID
                               ORDER BY Tgl_Sewa";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@PropertiID", PropertiID);

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            RiwayatTransaksi trx = new RiwayatTransaksi
                            {
                                Username = dtr["Username"].ToString(),
                                PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0,
                                Keterangan = dtr["Keterangan"] != DBNull.Value ? dtr["Keterangan"].ToString() : string.Empty,
                                TransaksiID = dtr["TransaksiID"] != DBNull.Value ? Convert.ToInt32(dtr["TransaksiID"]) : 0
                            };

                            list.Add(trx);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("readByPropertiID error: {0}", ex.Message);
            }

            return list;
        }
    }
}
