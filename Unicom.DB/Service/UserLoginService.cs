using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class UserLoginService
    {

        public void Add(UserLogin userLogin)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO User (UserId, Password, Role) VALUES (@userId, @password, @role)";
                cmd.Parameters.AddWithValue("@userId", userLogin.UserId);
                cmd.Parameters.AddWithValue("@password", userLogin.Password);
                cmd.Parameters.AddWithValue("@role", userLogin.Role);
                cmd.ExecuteNonQuery();
            }
        }

        public void CreateLogin(UserLogin login)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO User (UserId, Password, Role) VALUES (@userId, @password, @role)";
                cmd.Parameters.AddWithValue("@userId", login.UserId);
                cmd.Parameters.AddWithValue("@password", login.Password);
                cmd.Parameters.AddWithValue("@role", login.Role);
                cmd.ExecuteNonQuery();
            }
        }

        public UserLogin GetLoginByUserIdAndRole(int userId, string role)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM User WHERE UserId = @userId AND Role = @role";
                cmd.Parameters.AddWithValue("@userId", userId);
                cmd.Parameters.AddWithValue("@role", role);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new UserLogin
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };
                    }
                }
            }

            return null;

        }
    }
}
