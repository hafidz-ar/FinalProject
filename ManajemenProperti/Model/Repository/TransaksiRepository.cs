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
        private readonly DbContext dbContext;

        public TransaksiRepository()
        {
            dbContext = new DbContext();
        }

        public List<Transaksi> GetAll()
        {
            var transaksiList = new List<Transaksi>();
            using (var connection = dbContext.Conn)
            {
                connection.Open();
                string query = "SELECT * FROM Transaksi";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    transaksiList.Add(new Transaksi
                    {
                        TransaksiID = reader.GetInt32("TransaksiID"),
                        PenyewaID = reader.GetInt32("PenyewaID"),
                        NIP = reader.GetInt32("NIP"),
                        PropertiID = reader.GetInt32("PropertiID"),
                        Tgl_Sewa = reader.GetDateTime("Tgl_Sewa"),
                        Lama_Sewa = reader.GetInt32("Lama_Sewa"),
                        Keterangan = reader.GetString("Keterangan")
                    });
                }
            }
            return transaksiList;
        }

        public Transaksi GetById(int transaksiId)
        {
            Transaksi transaksi = null;
            using (var connection = dbContext.Conn)
            {
                connection.Open();
                string query = "SELECT * FROM Transaksi WHERE TransaksiID = @TransaksiID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksiId);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    transaksi = new Transaksi
                    {
                        TransaksiID = reader.GetInt32("TransaksiID"),
                        PenyewaID = reader.GetInt32("PenyewaID"),
                        NIP = reader.GetInt32("NIP"),
                        PropertiID = reader.GetInt32("PropertiID"),
                        Tgl_Sewa = reader.GetDateTime("Tgl_Sewa"),
                        Lama_Sewa = reader.GetInt32("Lama_Sewa"),
                        Keterangan = reader.GetString("Keterangan")
                    };
                }
            }
            return transaksi;
        }

        public void Add(Transaksi transaksi)
        {
            using (var connection = dbContext.Conn)
            {
                connection.Open();
                string query = "INSERT INTO Transaksi (TransaksiID, PenyewaID, NIP, PropertiID, Tgl_Sewa, Lama_Sewa, Keterangan) " +
                               "VALUES (@TransaksiID, @PenyewaID, @NIP, @PropertiID, @Tgl_Sewa, @Lama_Sewa, @Keterangan)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksi.TransaksiID);
                cmd.Parameters.AddWithValue("@PenyewaID", transaksi.PenyewaID);
                cmd.Parameters.AddWithValue("@NIP", transaksi.NIP);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Tgl_Transaksi", transaksi.Tgl_Sewa);
                cmd.Parameters.AddWithValue("@Lama_transaksi", transaksi.Lama_Sewa);
                cmd.Parameters.AddWithValue("@Keterangan", transaksi.Keterangan);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Transaksi transaksi)
        {
            using (var connection = dbContext.Conn)
            {
                connection.Open();
                string query = "UPDATE Transaksi SET PenyewaID = @PenyewaID, NIP = @NIP, PropertiID = @PropertiID, Tgl_Sewa = @Tgl_Sewa, " +
                               "Lama_Sewa = @Lama_Sewa, Keterangan = @Keterangan WHERE TransaksiID = @TransaksiID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@PenyewaID", transaksi.PenyewaID);
                cmd.Parameters.AddWithValue("@NIP", transaksi.NIP);
                cmd.Parameters.AddWithValue("@PropertiID", transaksi.PropertiID);
                cmd.Parameters.AddWithValue("@Tgl_Transaksi", transaksi.Tgl_Sewa);
                cmd.Parameters.AddWithValue("@Lama_Transaksi", transaksi.Lama_Sewa);
                cmd.Parameters.AddWithValue("@Keterangan", transaksi.Keterangan);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksi.TransaksiID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int transaksiId)
        {
            using (var connection = dbContext.Conn)
            {
                connection.Open();
                string query = "DELETE FROM Transaksi WHERE TransaksiID = @TransaksiID";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@TransaksiID", transaksiId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
