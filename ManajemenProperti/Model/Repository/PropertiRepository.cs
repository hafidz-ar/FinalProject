using ManajemenProperti.Model.Context;
using ManajemenProperti.Model.Entity;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Model.Repository
{
    public class PropertiRepository
    {
        private readonly MySqlConnection _conn;

        public PropertiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        // Method untuk menambahkan data Properti
        public int createProperti(Properti prp)
        {
            int result = 0;
            string sql = @"INSERT INTO Properti (Nama, Harga_sewa, Stok, PropertiID) 
                           VALUES (@Nama, @Harga_sewa, @Stok, @PropertiID)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", prp.Nama);
                cmd.Parameters.AddWithValue("@Harga_sewa", prp.Harga_Sewa);
                cmd.Parameters.AddWithValue("@Stok", prp.Stok);
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

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

        // Method untuk mengupdate data Properti
        public int updateProperti(Properti prp)
        {
            int result = 0;
            string sql = @"UPDATE Properti 
                           SET Nama = @Nama, Harga_sewa = @Harga_sewa, Stok = @Stok 
                           WHERE PropertiID = @PropertiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", prp.Nama);
                cmd.Parameters.AddWithValue("@Harga_sewa", prp.Harga_Sewa);
                cmd.Parameters.AddWithValue("@Stok", prp.Stok);
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

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

        // Method untuk menghapus data Properti
        public int deleteProperti(Properti prp)
        {
            int result = 0;
            string sql = @"DELETE FROM Properti WHERE PropertiID = @PropertiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

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

        // Method untuk membaca semua data Properti
        public List<Properti> readAllProperti()
        {
            List<Properti> list = new List<Properti>();
            string sql = @"SELECT Nama, Harga_sewa, Stok, PropertiID FROM Properti ORDER BY Nama";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                try
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Properti prp = new Properti
                            {
                                Nama = dtr["Nama"].ToString(),
                                Harga_Sewa = dtr["Harga_sewa"] != DBNull.Value ? Convert.ToDecimal(dtr["Harga_sewa"]) : 0,
                                Stok = dtr["Stok"] != DBNull.Value ? Convert.ToInt32(dtr["Stok"]) : 0,
                                PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0
                            };
                            list.Add(prp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
                }
            }

            return list;
        }

        // Method untuk mencari Properti berdasarkan nama
        public List<Properti> readByNama(string nama)
        {
            List<Properti> list = new List<Properti>();
            string sql = @"SELECT Nama, Harga_sewa, Stok, PropertiID 
                           FROM Properti 
                           WHERE Nama LIKE @Nama 
                           ORDER BY Nama";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Nama", $"%{nama}%");

                try
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Properti prp = new Properti
                            {
                                Nama = dtr["Nama"].ToString(),
                                Harga_Sewa = dtr["Harga_sewa"] != DBNull.Value ? Convert.ToDecimal(dtr["Harga_sewa"]) : 0,
                                Stok = dtr["Stok"] != DBNull.Value ? Convert.ToInt32(dtr["Stok"]) : 0,
                                PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0
                            };
                            list.Add(prp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
                }
            }

            return list;
        }

        // Method untuk mengupdate stok Properti
        public int updateStok(Properti prp)
        {
            int result = 0;
            string sql = @"UPDATE Properti SET Stok = @Stok WHERE PropertiID = @PropertiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Stok", prp.Stok);
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("UpdateStok error: {0}", ex.Message);
                }
            }

            return result;
        }
    }
}

