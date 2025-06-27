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
        public void AddExam_mark(Exam_mark exam_mark)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Exam_marks (Exam, Marks, Subject_Name, Student_Id, Subject_Id) VALUES (@Exam, @Marks, @Subject_Name, @Student_Id, @Subject_Id)";
                cmd.Parameters.AddWithValue("@Exam", exam_mark.Exam);
                cmd.Parameters.AddWithValue("@Marks", exam_mark.Marks);
                cmd.Parameters.AddWithValue("@Subject_Name", exam_mark.Subject_Name);
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
                            Id = Convert.ToInt32(reader["Id"]),
                            Exam = reader["Exam"]?.ToString(),
                            Marks = Convert.ToInt32(reader["Marks"]),
                            Subject_Name = reader["Subject_Name"]?.ToString(),
                            Student_Id = Convert.ToInt32(reader["Student_Id"]),
                            Subject_Id = Convert.ToInt32(reader["Subject_Id"])
                            
                        });

                    }
                }
            }
            return exam_mark;
        }


        public void Update(Exam_mark exam_mark)
        {
            if (string.IsNullOrWhiteSpace(exam_mark.Subject_Name))
                throw new ArgumentException("Subject_Name cannot be null or empty.");

            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Exam_marks SET Exam = @Exam, Marks = @Marks, Subject_Name = @Subject_Name, Student_Id = @Student_Id, Subject_Id = @Subject_Id WHERE Id = @id";
                cmd.Parameters.AddWithValue("@Exam", exam_mark.Exam);
                cmd.Parameters.AddWithValue("@Marks", exam_mark.Marks);
                cmd.Parameters.AddWithValue("@Subject_Name", exam_mark.Subject_Name);
                cmd.Parameters.AddWithValue("@Student_Id", exam_mark.Student_Id);
                cmd.Parameters.AddWithValue("@Subject_Id", exam_mark.Subject_Id);
                cmd.Parameters.AddWithValue("@id", exam_mark.Id);

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

        public List<Exam_mark> GetByStudentId(int studentId)
        {
            var examMarks = new List<Exam_mark>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Exam_marks WHERE Student_Id = @studentId";
                cmd.Parameters.AddWithValue("@studentId", studentId);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        examMarks.Add(new Exam_mark
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Exam = reader["Exam"]?.ToString(),
                            Marks = Convert.ToInt32(reader["Marks"]),
                            Subject_Name = reader["Subject_Name"]?.ToString(),
                            Student_Id = Convert.ToInt32(reader["Student_Id"]),
                            Subject_Id = Convert.ToInt32(reader["Subject_Id"])
                        });
                    }
                }
            }
            return examMarks;
        }

    }
}
