using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Data;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class AdminController
    {
        private readonly AdminService _adminService;

        public AdminController()
        {
            _adminService = new AdminService();
        }

        public List<Admin> GetAllAdmin() => _adminService.GetAll();

        public void AddAdmin(Admin admin) => _adminService.Add(admin);

        public void UpdateAdmin(Admin admin) => _adminService.Update(admin);

        public void DeleteAdmin(int AdminId) => _adminService.Delete(AdminId);
    }
}
