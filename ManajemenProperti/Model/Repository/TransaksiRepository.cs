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
    public class TransaksiRepository
    {
        private MySqlConnection _conn;

        public TransaksiRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int createTransaksi(Transaksi transaksi)
        {
            int result = 0;

            string sql = @"INSERT INTO Transaksi (Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID) 
                   VALUES (@username, @PropertiID, @Tgl_Sewa, @Lama_Sewa, @Keterangan, @TransaksiID)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", transaksi.Username);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Tgl_Sewa", transaksi.Tgl_Sewa);
                cmd.Parameters.AddWithValue("@Lama_Sewa", transaksi.Lama_Sewa);
                cmd.Parameters.AddWithValue("@Keterangan", transaksi.Keterangan);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksi.TransaksiID);

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

        public int updateTransaksi(Transaksi transaksi)
        {
            int result = 0;

            string sql = @"UPDATE Transaksi SET Username = @Username, PropertiID = @PropertiID, Tgl_Sewa = @Tgl_Sewa, Lama_Sewa = @Lama_Sewa, Keterangan = @Keterangan 
                           WHERE TransaksiID = @TransaksiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Username", transaksi.Username);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Tgl_Sewa", transaksi.Tgl_Sewa);
                cmd.Parameters.AddWithValue("@Lama_Sewa", transaksi.Lama_Sewa);
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

        public int deleteTransaksi(Transaksi transaksi)
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

        public List<Transaksi> readAllTransaksi()
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"select Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID 
                               from Transaksi 
                               order by TransaksiID";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trx = new Transaksi();
                            trx.Username = dtr["Username"] != DBNull.Value ? Convert.ToInt32(dtr["Username"]) : 0;
                            trx.PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0;
                            trx.Tgl_Sewa = dtr["Tgl_Sewa"] != DBNull.Value ? Convert.ToDateTime(dtr["Tgl_Sewa"]) : DateTime.MinValue;
                            trx.Lama_Sewa = dtr["Lama_Sewa"] != DBNull.Value ? Convert.ToInt32(dtr["Lama_Sewa"]) : 0;
                            trx.Keterangan = dtr["Keterangan"] != DBNull.Value ? dtr["Keterangan"].ToString() : string.Empty;
                            trx.TransaksiID = dtr["TransaksiID"] != DBNull.Value ? Convert.ToInt32(dtr["TransaksiID"]) : 0;

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

        public List<Transaksi> readByPropertiID(int PropertiID)
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"SELECT Username, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID
                               FROM Transaksi
                               WHERE Keterangan LIKE @PropertiID
                               ORDER BY Tgl_Sewa";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@PropertiID", string.Format("%{0}%", PropertiID));

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trx = new Transaksi();
                            trx.Username = dtr["Username"] != DBNull.Value ? Convert.ToInt32(dtr["Username"]) : 0;
                            trx.PropertiID = dtr["PropertiID"] != DBNull.Value ? Convert.ToInt32(dtr["PropertiID"]) : 0;
                            trx.Tgl_Sewa = dtr["Tgl_Sewa"] != DBNull.Value ? Convert.ToDateTime(dtr["Tgl_Sewa"]) : DateTime.MinValue;
                            trx.Lama_Sewa = dtr["Lama_Sewa"] != DBNull.Value ? Convert.ToInt32(dtr["Lama_Sewa"]) : 0;
                            trx.Keterangan = dtr["Keterangan"] != DBNull.Value ? dtr["Keterangan"].ToString() : string.Empty;
                            trx.TransaksiID = dtr["TransaksiID"] != DBNull.Value ? Convert.ToInt32(dtr["TransaksiID"]) : 0;

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
