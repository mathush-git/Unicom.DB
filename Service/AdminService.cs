using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class AdminService
    {
        public void SeedDefaultAdmin()
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM Admin WHERE Id = 0";
                var count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count == 0)
                {
                    cmd.CommandText = "INSERT INTO Admin (Id, Name, Phone, Address, Password, Role) VALUES (0, @name, @phone, @address, @password, @role)";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@name", "Default Admin");
                    cmd.Parameters.AddWithValue("@phone", "0000000000");
                    cmd.Parameters.AddWithValue("@address", "Head Office");
                    cmd.Parameters.AddWithValue("@password", "Admin_000");
                    cmd.Parameters.AddWithValue("@role", "Admin");
                    cmd.ExecuteNonQuery();

                    var userLoginService = new UserLoginService();
                    userLoginService.Add(new UserLogin
                    {
                        UserId = 0,
                        Password = "Admin_000",
                        Role = "Admin"
                    });
                }
            }
        }

        public void Add(Admin admin)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Admin (Name, Phone, Address, Password, Role) VALUES (@name, @phone, @address, @password, @role)";
                cmd.Parameters.AddWithValue("@name", admin.Name);
                cmd.Parameters.AddWithValue("@phone", admin.Phone);
                cmd.Parameters.AddWithValue("@address", admin.Address);
                cmd.Parameters.AddWithValue("@password", admin.Password);
                cmd.Parameters.AddWithValue("@role", admin.Role);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT last_insert_rowid()";
                var adminId = Convert.ToInt32(cmd.ExecuteScalar());

                
                var userLoginService = new UserLoginService();
                userLoginService.Add(new UserLogin
                {
                    UserId = adminId,
                    Password = admin.Password,
                    Role = admin.Role
                });
            }
        }

        public List<Admin> GetAll()
        {
            var admin = new List<Admin>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Admin";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        admin.Add(new Admin
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"]?.ToString(),
                            Phone = reader["Phone"]?.ToString(),
                            Address = reader["Address"]?.ToString(),
                            Password = reader["Password"]?.ToString(),
                            Role = reader["Role"]?.ToString()
                        });

                    }
                }
            }
            return admin;
        }

        public void Update(Admin admin)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Admin SET Name = @name, Phone = @phone, Address = @address, Password = @password, Role = @role WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", admin.Name);
                cmd.Parameters.AddWithValue("@phone", admin.Phone);
                cmd.Parameters.AddWithValue("@address", admin.Address);
                cmd.Parameters.AddWithValue("@password", admin.Password);
                cmd.Parameters.AddWithValue("@role", admin.Role);
                cmd.Parameters.AddWithValue("@id", admin.Id);
                cmd.ExecuteNonQuery();
            }
        }


        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Admin WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
