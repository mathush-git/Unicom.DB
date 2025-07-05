using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom.DB.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Address { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Course { get; set; }
        public int CourseId { get; set; }


        public override string ToString()
        {
            return $"{Id} - {Name}";
        }

    }

}
