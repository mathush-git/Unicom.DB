using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class Exam_MarkService
    {
        public void Add(Exam_mark exam_mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Exam_marks (Exam, Marks, Subject_Name, Student_Id, Subject_Id)  VALUES (@Exam, @Marks, @Subject_Name, @Student_Id, @Subject_Id)";
                cmd.Parameters.AddWithValue("@Exam", exam_mark.Exam);
                cmd.Parameters.AddWithValue("@Marks", exam_mark.Marks);
                cmd.Parameters.AddWithValue("@Subject_name", exam_mark.Subject_Name);
                cmd.Parameters.AddWithValue("@Student_Id", exam_mark.Student_Id);
                cmd.Parameters.AddWithValue("@Subject_Id", exam_mark.Subject_Id);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Exam_mark> GetAll()
        {
            var exam_mark = new List<Exam_mark>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Exam_marks";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        exam_mark.Add(new Exam_mark
                        {
                            Id = reader.GetInt32(0),
                            Exam = reader.GetString(1),
                            Subject_Name = reader.GetString(2),
                            Marks = reader.GetInt32(3),
                            Student_Id = reader.GetInt32(4),
                            Subject_Id = reader.GetInt32(5),
                        });
                    }
                }
            }
            return exam_mark;
        }

        public void Update(Exam_mark exam_mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Exam_marks SET Exam = @Exam WHERE Id = @id";
                cmd.Parameters.AddWithValue("@Exam", exam_mark.Exam);
                cmd.Parameters.AddWithValue("@Subject_Name", exam_mark.Subject_Name);
                cmd.Parameters.AddWithValue("@Marks", exam_mark.Marks);
                cmd.Parameters.AddWithValue("@id", exam_mark.Id);
                cmd.Parameters.AddWithValue("@Student_Id", exam_mark.Student_Id);
                cmd.Parameters.AddWithValue("@Subject_Id", exam_mark.Subject_Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Exam_marks WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
