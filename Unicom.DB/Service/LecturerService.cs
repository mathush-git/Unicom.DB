using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class LecturerService
    {
        public void Add(Lecturer lecturer)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Lecturer (Name, Phone, Address, Password, Role) VALUES (@name, @phone, @address, @password, @role)";
                cmd.Parameters.AddWithValue("@name", lecturer.Name);
                cmd.Parameters.AddWithValue("@phone", lecturer.Phone);
                cmd.Parameters.AddWithValue("@address", lecturer.Address);
                cmd.Parameters.AddWithValue("@password", lecturer.Password);
                cmd.Parameters.AddWithValue("@role", lecturer.Password);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT last_insert_rowid()";
                var lecturerId = Convert.ToInt32(cmd.ExecuteScalar());

                var userLoginService = new UserLoginService();
                userLoginService.Add(new UserLogin
                {
                    UserId = lecturerId,
                    Password = lecturer.Password,
                    Role = lecturer.Role
                });
            }
        }

        public List<Lecturer> GetAll()
        {
            var lecturer = new List<Lecturer>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Lecturer";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturer.Add(new Lecturer
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
            return lecturer;
        }

        public void Update(Lecturer lecturer)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Lecturer SET Name = @name, Phone = @phone, Address = @address, Password = @password, Role = @role WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", lecturer.Name);
                cmd.Parameters.AddWithValue("@phone", lecturer.Phone);
                cmd.Parameters.AddWithValue("@address", lecturer.Address);
                cmd.Parameters.AddWithValue("@password", lecturer.Password);
                cmd.Parameters.AddWithValue("@role", lecturer.Role);
                cmd.Parameters.AddWithValue("@id", lecturer.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Lecturer WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
