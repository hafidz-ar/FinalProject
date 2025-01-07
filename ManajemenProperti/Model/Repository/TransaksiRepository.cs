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

        public int Create(Transaksi transaksi)
        {
            int result = 0;

            string sql = @"INSERT INTO Transaksi (Users, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID) 
                   VALUES (@Users, @PropertiID, @Tgl_Sewa, @Lama_Sewa, @Keterangan, @TransaksiID)";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Users", transaksi.Users);
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

        public int Update(Transaksi transaksi)
        {
            int result = 0;

            string sql = @"UPDATE Transaksi SET Users = @Users, PropertiID = @PropertiID, Tgl_Sewa = @Tgl_Sewa, Lama_Sewa = @Lama_Sewa, Keterangan = @Keterangan 
                           WHERE TransaksiID = @TransaksiID";

            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@Users", transaksi.Users);
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

        public int Delete(Transaksi transaksi)
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

        public List<Transaksi> ReadAll()
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"select Users, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID 
                               from Transaksi 
                               order by TransaksiID";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trx = new Transaksi();
                            trx.Users = dtr["Users"] != DBNull.Value ? Convert.ToInt32(dtr["Users"]) : 0;
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

        public List<Transaksi> ReadByNama(string nama)
        {
            List<Transaksi> list = new List<Transaksi>();

            try
            {
                string sql = @"SELECT Users, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan, TransaksiID
                               FROM Transaksi
                               WHERE Keterangan LIKE @nama
                               ORDER BY Tgl_Sewa";

                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));

                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            Transaksi trx = new Transaksi();
                            trx.Users = dtr["Users"] != DBNull.Value ? Convert.ToInt32(dtr["Users"]) : 0;
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
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }
    }
}
