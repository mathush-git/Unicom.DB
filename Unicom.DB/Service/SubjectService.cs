using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class SubjectService
    {
        public void Add(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Subject (Subject_Name, Course_Id, Course_Name) VALUES  (@subject_name, @course_id, @course_name)";
                // cmd.Parameters.AddWithValue("@id", courses.Id);
                cmd.Parameters.AddWithValue("@subject_name", subject.Subject_Name);
                cmd.Parameters.AddWithValue("@course_id", subject.Course_Id);
                cmd.Parameters.AddWithValue("@course_name", subject.Course_Name);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Subject> GetAll()
        {
            var subject = new List<Subject>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Subject";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        subject.Add(new Subject
                        {
                            Subject_Id = reader.GetInt32(0),
                            Subject_Name = reader.GetString(1),
                            Course_Name = reader.GetString(2),
                            Course_Id = reader.GetInt32(3)
                        });
                    }
                }
            }
            return subject;
        }

        public void Update(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE Subject 
                            SET Subject_Name = @subject_name, 
                                Course_Id = @course_id,
                                Course_Name = @course_name 
                            WHERE Subject_Id = @id";

                cmd.Parameters.AddWithValue("@subject_name", subject.Subject_Name);
                cmd.Parameters.AddWithValue("@course_id", subject.Course_Id);
                cmd.Parameters.AddWithValue("@course_name", subject.Course_Name);
                cmd.Parameters.AddWithValue("@id", subject.Subject_Id);

                cmd.ExecuteNonQuery();
            }
        }



        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Subject WHERE Subject_Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
