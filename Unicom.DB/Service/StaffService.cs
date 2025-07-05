using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class StaffService
    {
        public void Add(Staff staff)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Staff (Name, Phone, Address, Password, Role) VALUES (@name, @phone, @address, @password, @role)";
                cmd.Parameters.AddWithValue("@name", staff.Name);
                cmd.Parameters.AddWithValue("@phone", staff.Phone);
                cmd.Parameters.AddWithValue("@address", staff.Address);
                cmd.Parameters.AddWithValue("@password", staff.Password);
                cmd.Parameters.AddWithValue("@role", staff.Role);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT last_insert_rowid()";
                var staffId = Convert.ToInt32(cmd.ExecuteScalar());

                var userLoginService = new UserLoginService();
                userLoginService.Add(new UserLogin
                {
                    UserId = staffId,
                    Password = staff.Password,
                    Role = staff.Role
                });
            }
        }

        public List<Staff> GetAll()
        {
            var staff = new List<Staff>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Staff";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staff.Add(new Staff
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Address = reader.GetString(3),
                            Password = reader.GetString(4),
                            Role = reader.GetString(5)
                        });
                    }
                }
            }
            return staff;
        }

        public void Update(Staff staff)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Staff SET Name = @name, Phone = @phone, Address = @address, Password = @password, Role = @role WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", staff.Name);
                cmd.Parameters.AddWithValue("@phone", staff.Phone);
                cmd.Parameters.AddWithValue("@address", staff.Address);
                cmd.Parameters.AddWithValue("@password", staff.Password);
                cmd.Parameters.AddWithValue("@role", staff.Role);
                cmd.Parameters.AddWithValue("@id", staff.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Staff WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
