using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom.DB.Models
{
    internal class Exam_mark
    {
        public int Id { get; set; }
        public string Exam { get; set; }
        public string Subject_Name { get; set; }
        public int? Marks { get; set; }
        public int? Student_Id { get; set; }
        public int? Subject_Id { get; set; }


    }
}
