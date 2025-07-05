using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom.DB.Models
{
    internal class UserLogin
    {
        public int Id { get; set; }
        public int UserId { get; set; } // FK to Student/Staff/Admin table
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "Student", etc.
    }
}
