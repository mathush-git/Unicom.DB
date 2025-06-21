using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;

namespace Unicom.DB.Service
{
    internal class ExamService
    {
        public void Add(ExamItem examitem)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO ExamItem (Name) VALUES  (@name)";
                // cmd.Parameters.AddWithValue("@id", courses.Id);
                cmd.Parameters.AddWithValue("@name", examitem.Name);
                cmd.ExecuteNonQuery();
            }
        }

        public List<ExamItem> GetAll()
        {
            var examitem = new List<ExamItem>();
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM ExamItem";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        examitem.Add(new ExamItem
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return examitem;
        }

        public void Update(ExamItem examitem)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE ExamItem SET Name = @name WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", examitem.Name);
                cmd.Parameters.AddWithValue("@id", examitem.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM ExamItem WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

