using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class StaffController
    {
        private readonly StaffService _staffService;

        public StaffController()
        {
            _staffService = new StaffService();
        }

        public List<Staff> GetAllStaff() => _staffService.GetAll();

        public void AddStaff(Staff staff) => _staffService.Add(staff);

        public void UpdateStaff(Staff staff) => _staffService.Update(staff);

        public void DeleteStaff(int staffId) => _staffService.Delete(staffId);
    }
}

