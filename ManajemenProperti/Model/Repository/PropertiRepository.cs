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
        private MySqlConnection _conn;

        public PropertiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

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

        public int updateProperti(Properti prp)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"UPDATE Properti SET Nama = @Nama, Harga_sewa = @Harga_sewa, Stok = @Stok WHERE PropertiID = @PropertiID";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", prp.Nama);
                cmd.Parameters.AddWithValue("@Harga_sewa", prp.Harga_Sewa);
                cmd.Parameters.AddWithValue("@Stok", prp.Stok);
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

                try
                {
                    // jalankan perintah UPDATE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int deleteProperti(Properti prp)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"DELETE FROM Properti WHERE PropertiID = @PropertiID";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@PropertiID", prp.PropertiID);

                try
                {
                    // jalankan perintah DELETE dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Properti> readAllProperti()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Properti> list = new List<Properti>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select nama, harga_sewa, stok, propertiid 
                               from properti 
                               order by nama";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Properti prp = new Properti();
                            prp.Nama = dtr["nama"].ToString();
                            prp.Harga_Sewa = dtr["harga_sewa"] != DBNull.Value ? Convert.ToInt32(dtr["harga_sewa"]) : 0;
                            prp.Stok = dtr["stok"] != DBNull.Value ? Convert.ToInt32(dtr["stok"]) : 0;
                            prp.PropertiID = dtr["propertiiD"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0;

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(prp);
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

        // Method untuk menampilkan data mahasiwa berdasarkan pencarian nama
        public List<Properti> readByNama(string nama)
        {
            // Membuat objek collection untuk menampung objek Properti
            List<Properti> list = new List<Properti>();

            try
            {
                // Deklarasi perintah SQL
                string sql = @"SELECT Nama, Harga_sewa, Stok, PropertiID
                       FROM Properti
                       WHERE Nama LIKE @nama
                       ORDER BY Nama";

                // Membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // Mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));

                    // Membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // Panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // Proses konversi dari row result set ke object Properti
                            Properti prp = new Properti();
                            prp.Nama = dtr["Nama"].ToString();
                            prp.Harga_Sewa = dtr["Harga_sewa"] != DBNull.Value ? Convert.ToInt32(dtr["Harga_sewa"]) : 0;
                            prp.Stok = dtr["Stok"] != DBNull.Value ? Convert.ToInt32(dtr["Stok"]) : 0;
                            prp.PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0;

                            // Tambahkan objek Properti ke dalam collection
                            list.Add(prp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
