using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class Time_TableService
    {
        public void Add(TimeTable time_table)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Time_Table (Room_Id), (Room_Name), (Subject_Id), (Subject), (TimeSlot) VALUES (@Room_Id), (@Room_Name), (@Subject_Id), (@Subject), (@TimeSlot)";
                cmd.Parameters.AddWithValue("@Room_Id", time_table.Room_Id);
                cmd.Parameters.AddWithValue("@Room_Name", time_table.Room_Id);
                cmd.Parameters.AddWithValue("@Subject_Id", time_table.Subject_Id);
                cmd.Parameters.AddWithValue("@Subject", time_table.Subject);
                cmd.Parameters.AddWithValue("@TimeSlot", time_table.TimeSlot);
                cmd.ExecuteNonQuery();
            }
        }

        public List<TimeTable> GetAll()
        {
            var time_table = new List<TimeTable>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM Time_Table";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        time_table.Add(new TimeTable
                        {
                            Id = reader.GetInt32(0),
                            Room_Id = reader.GetInt32(1),
                            Room_Name = reader.GetString(2),
                            Subject_Id = reader.GetInt32(3),
                            Subject = reader.GetString(4),
                            TimeSlot = reader.GetInt32(5),
                        });
                    }
                }
            }
            return time_table;
        }

        public void Update(TimeTable time_table)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Time_Table SET Room_Id  = @Room_Id,Room_Name = @Room_Name, TimeSlot = @TimeSlot, Subject_Id = @Subject_Id, Subject = @Subject  WHERE Id = @id";
                cmd.Parameters.AddWithValue("@Room_Id ", time_table.Room_Id);
                cmd.Parameters.AddWithValue("@Room_Name ", time_table.Room_Name);
                cmd.Parameters.AddWithValue("@TimeSlot ", time_table.TimeSlot);
                cmd.Parameters.AddWithValue("@Subject_Id ", time_table.Subject_Id);
                cmd.Parameters.AddWithValue("@Subject ", time_table.Subject);
                cmd.Parameters.AddWithValue("@id", time_table.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Time_Table WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
