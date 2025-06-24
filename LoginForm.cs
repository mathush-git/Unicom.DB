using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom.DB.Controller;
using Unicom.DB.Dashboard_Form;

namespace Unicom.DB
{
    public partial class LoginForm : Form
    {
        private readonly UserLoginController _loginController;

        public LoginForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\C.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            _loginController = new UserLoginController();

            cmbRole.Items.AddRange(new[] { "Admin", "Student", "Lecturer", "Staff" });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUserId.Text.Trim(), out int userId))
            {
                MessageBox.Show("Please enter a valid User ID.");
                return;
            }

            string password = txtPassword.Text.Trim();
            string role = cmbRole.Text.Trim();

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please enter both Password and select Role.");
                return;
            }

            var loginController = new UserLoginController();
            var user = loginController.Login(userId, password, role);

            if (user != null)
            {
                MessageBox.Show("Login successful!");

                this.Hide(); // Hide the login form

                // ✅ Role-based dashboard opening
                Form dashboardForm = null;

                switch (user.Role)
                {
                    case "Admin":
                        dashboardForm = new AdminDashboard();
                        break;
                    case "Student":
                        dashboardForm = new StudentDashboard();
                        break;
                    case "Staff":
                        dashboardForm = new StaffDashboard();
                        break;
                    case "Lecturer":
                        dashboardForm = new LecturerDashboard();
                        break;
                    default:
                        MessageBox.Show("Unknown role: " + user.Role);
                        this.Show(); // Show login form again if unknown role
                        return;
                }

                // ✅ Open dashboard
                dashboardForm.ShowDialog();

                this.Close(); // Close login form after dashboard closes
            }
            else
            {
                MessageBox.Show("Invalid ID, Password, or Role.");
            }
        }


        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
