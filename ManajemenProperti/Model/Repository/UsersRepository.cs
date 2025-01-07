using ManajemenProperti.Model.Entity;
using ManajemenProperti.Model.Context;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManajemenProperti.Model.Repositori
{
    public class UsersRepository
    {
        private readonly DbContext _dbContext;

        // Constructor menerima DbContext
        public UsersRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Login(User user)
        {
            string query = "SELECT username FROM users WHERE username = @username AND password = @password LIMIT 1";

            using (MySqlCommand cmd = new MySqlCommand(query, _dbContext.Conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                using (var dr = cmd.ExecuteReader())
                {
                    return dr.HasRows;
                }
            }
        }

        public bool Register(User user)
        {
            string query = "INSERT INTO users (username, password) VALUES (@username, @password)";

            using (MySqlCommand cmd = new MySqlCommand(query, _dbContext.Conn))
            {
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
