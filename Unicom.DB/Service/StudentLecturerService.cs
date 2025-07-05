using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class StudentLecturerService
    {
        public void AssignLecturerToStudent(int studentId, int lecturerId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    INSERT OR IGNORE INTO StudentLecturer (StudentId, lecturerId)
                    VALUES (@studentId, @lecturerId)";
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@teacherId", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public void RemoveLecturerFromStudent(int studentId, int lecturerId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    DELETE FROM StudentLecturer 
                    WHERE StudentId = @studentId AND LecturerId = @lecturerId";
                cmd.Parameters.AddWithValue("@studentId", studentId);
                cmd.Parameters.AddWithValue("@lecturerId", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Lecturer> GetLecturerForStudent(int studentId)
        {
            var lecturer = new List<Lecturer>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"
                    SELECT L.Id, L.Name, L.Phone, L.Address
                    FROM Lecturer L
                    INNER JOIN StudentLecturer SL ON L.Id = SL.LecturerId
                    WHERE SL.StudentId = @studentId";
                cmd.Parameters.AddWithValue("@studentId", studentId);
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
