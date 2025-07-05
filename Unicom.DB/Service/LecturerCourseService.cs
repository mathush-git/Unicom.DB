using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class LecturerCourseService
    {
        public void AssignLecturerToCourse(int courseId, int LecturerId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT OR IGNORE INTO LecturerCourse (CourseId, LecturerId)
                    VALUES (@courseId, @lecturerId)";
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@lecturerId", LecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveLecturerFromCourse(int courseId, int LecturerId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    DELETE FROM LecturerCourse 
                    WHERE CourseId = @courseId AND LecturerId = @lecturerId";
                cmd.Parameters.AddWithValue("@courseId", courseId);
                cmd.Parameters.AddWithValue("@lecturerId", LecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Lecturer> GetLecturerForCourse(int courseId)
        {
            var lecturer = new List<Lecturer>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT L.Id, L.Name, L.Phone, L.Address
                    FROM Lecturer L
                    INNER JOIN LecturerCourse CL ON L.Id = CL.LecturerId
                    WHERE SL.CourseId = @courseId";
                cmd.Parameters.AddWithValue("@courseId", courseId);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lecturer.Add(new Lecturer
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Address = reader.GetString(3)
                        });
                    }
                }
            }
            return lecturer;
        }
    }
}
