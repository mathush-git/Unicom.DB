using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unicom.DB.Models;
using Unicom.DB.Service;

namespace Unicom.DB.Controller
{
    internal class UserLoginController
    {
        private readonly UserLoginService _loginService;

        public UserLoginController()
        {
            _loginService = new UserLoginService();
        }

        public UserLogin Login(int userId, string password, string role)
        {
            var user = _loginService.GetLoginByUserIdAndRole(userId, role);
            if (user != null && user.Password == password)
            {
                return user;
            }

            return null;
        }

        public void RegisterLogin(int userId, string password, string role)
        {
            var login = new UserLogin
            {
                UserId = userId,
                Password = password,
                Role = role
            };

            _loginService.CreateLogin(login);
        }

    }
}
