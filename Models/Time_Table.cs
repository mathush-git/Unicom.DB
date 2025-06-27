using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicom.DB.Models
{
    internal class TimeTable
    {
        public int TimeTab_Id { get; set; }
        public int Subject_Id { get; set; }
        public string Subject { get; set; }
        public string TimeSlot { get; set; }
        public int Room_Id { get; set; }
        public string Room_Name { get; set; }

    }
}
