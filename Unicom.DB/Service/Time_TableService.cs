using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
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
                cmd.CommandText = "INSERT INTO Time_Table (Room_Id, Room_Name, Subject_Id, Subject, TimeSlot) " +
                                  "VALUES (@Room_Id, @Room_Name, @Subject_Id, @Subject, @TimeSlot)";
                
                cmd.Parameters.AddWithValue("@Room_Id", time_table.Room_Id);
                cmd.Parameters.AddWithValue("@Room_Name", time_table.Room_Name); 
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
                            TimeTab_Id = Convert.ToInt32(reader.GetValue(0)),
                            Room_Id = Convert.ToInt32(reader.GetValue(1)),
                            Room_Name = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                            Subject = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            Subject_Id = Convert.ToInt32(reader.GetValue(4)),
                            TimeSlot = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        });

                    }
                }
            }
            return time_table;
        }

        public void Update(TimeTable time_table)
        {
            try
            {
                using (var conn = DbCon.GetConnection())
                {
                    //conn.Open();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"
                    UPDATE Time_Table
                    SET Room_Id = @Room_Id,
                        Room_Name = @Room_Name,
                        TimeSlot = @TimeSlot,
                        Subject_Id = @Subject_Id,
                        Subject = @Subject
                    WHERE TimeTab_Id = @TimeTab_Id";

                        // Make sure parameter names exactly match (no trailing spaces!)
                        cmd.Parameters.AddWithValue("@Room_Id", time_table.Room_Id);
                        cmd.Parameters.AddWithValue("@Room_Name", time_table.Room_Name);
                        cmd.Parameters.AddWithValue("@TimeSlot", time_table.TimeSlot);
                        cmd.Parameters.AddWithValue("@Subject_Id", time_table.Subject_Id);
                        cmd.Parameters.AddWithValue("@Subject", time_table.Subject);
                        cmd.Parameters.AddWithValue("@TimeTab_Id", time_table.TimeTab_Id);

                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows == 0)
                        {
                            MessageBox.Show("No record updated. Please check if the TimeTab_Id exists.");
                        }
                        else
                        {
                            MessageBox.Show("Record updated successfully.");
                        }
                    }
                }
            }
            catch (InvalidOperationException ioe)
            {
                MessageBox.Show("Invalid operation: " + ioe.Message);
            }
            catch (SQLiteException sqle)
            {
                MessageBox.Show("Database error: " + sqle.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }


        public void Delete(int TimeTab_Id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Time_Table WHERE TimeTab_Id = @TimeTab_Id";
                cmd.Parameters.AddWithValue("@TimeTab_Id", TimeTab_Id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
