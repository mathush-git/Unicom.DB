using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    public class StudentService
    {
        public void Add(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Student (Name, Address, Password, Role, CourseId, Course) VALUES (@name, @address,@password, @role, @courseId, @course)";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@password", student.Password);
                cmd.Parameters.AddWithValue("@role", student.Role);
                cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                cmd.Parameters.AddWithValue("@course", student.Course);
                cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT last_insert_rowid()";
                var studentId = Convert.ToInt32(cmd.ExecuteScalar());

                var userLoginService = new UserLoginService();
                userLoginService.Add(new UserLogin
                {
                    UserId = studentId,
                    Password = student.Password,
                    Role = student.Role
                });
            }
        }

        public List<Student> GetAll()
        {
            var students = new List<Student>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Student";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Address = reader.GetString(2),
                            Password = reader.GetString(3),
                            Role = reader.GetString(4),
                            Course = reader.GetString(5),
                            CourseId = reader.GetInt32(6),
                        });
                    }
                }
            }
            return students;
        }

        public void Update(Student student)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Student SET Name = @name, Address = @address, Password = @password, Role = @role, Course = @course, CourseId = @courseId WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@name", student.Name);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@password", student.Password);
                cmd.Parameters.AddWithValue("@role", student.Role);
                cmd.Parameters.AddWithValue("@course", student.Course);
                cmd.Parameters.AddWithValue("@courseId", student.CourseId);
                cmd.Parameters.AddWithValue("@Id", student.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int Id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Student WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
