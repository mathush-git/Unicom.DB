using Unicom.DB.AddForms;
using Unicom.DB.Dashboard_Form;
using Unicom.DB.Data;
using Unicom.DB.Models;
using Unicom.DB.Service;
using Unicom.DB.View_Form;

namespace Unicom.DB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
       {
            static void Main(string[] args)
            {
                var adminService = new AdminService();
                adminService.SeedDefaultAdmin();
            }


                DbCon.GetConnection();
            Databaselnitilizer.CreateTables();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}