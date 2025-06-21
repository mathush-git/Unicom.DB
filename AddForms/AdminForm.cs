using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom.DB.Controller;
using Unicom.DB.Dashboard_Form;
using Unicom.DB.Models;

namespace Unicom.DB
{
    public partial class AdminForm : Form
    {
        private AdminController _controller = new AdminController();
        private int selectedadminId = -1;
        public AdminForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadAdmin();
            LoadRoles();
            LoadSriLankaDistricts();
        }

        private void LoadSriLankaDistricts()
        {
            string[] districts = {
        "Ampara",
        "Anuradhapura",
        "Badulla",
        "Batticaloa",
        "Colombo",
        "Galle",
        "Gampaha",
        "Hambantota",
        "Jaffna",
        "Kalutara",
        "Kandy",
        "Kegalle",
        "Kilinochchi",
        "Kurunegala",
        "Mannar",
        "Matale",
        "Matara",
        "Monaragala",
        "Mullaitivu",
        "Nuwara Eliya",
        "Polonnaruwa",
        "Puttalam",
        "Ratnapura",
        "Trincomalee",
        "Vavuniya"
    };

            cmbAddress.Items.Clear();
            cmbAddress.Items.AddRange(districts);
            cmbAddress.SelectedIndex = -1; // Optional: no default selected
        }


        private void LoadRoles()
        {
            cmbRole.Items.Clear(); 
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Staff");
            cmbRole.Items.Add("Student");

            cmbRole.SelectedIndex = -1; 
        }


        private void LoadAdmin()
        {
            dgvAdmin.DataSource = _controller.GetAllAdmin();
            dgvAdmin.ClearSelection();

        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            admindashboard.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name, Phone, Address, Password and Role.");
                return;
            }

            var admin = new Admin
            {
                Name = txtName.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                Address = cmbAddress.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.Text.Trim()
            };
            _controller.AddAdmin(admin);
            LoadAdmin();
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            cmbAddress.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
            selectedadminId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedadminId == -1)
            {
                MessageBox.Show("Please select a Admin to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name, Phone, Address, Password and Role.");
                return;
            }
            Admin admin = new Admin
            {
                Id = selectedadminId,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };
            _controller.UpdateAdmin(admin);
            LoadAdmin();
            ClearInputs();
            MessageBox.Show("Admin Update Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedadminId == -1)
            {
                MessageBox.Show("Please select a Admin to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Admin?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
                if (selectedadminId != -1)
                {
                    _controller.DeleteAdmin(selectedadminId);
                    LoadAdmin();
                    ClearInputs();
                    MessageBox.Show("Admin Deleted Successfully");
                }
        }

        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvAdmin_SelectionChanged(object sender, EventArgs e)
        {

            if (dgvAdmin.SelectedRows.Count > 0)
            {
                var row = dgvAdmin.SelectedRows[0];
                var admin = row.DataBoundItem as Admin;
                if (admin != null)
                {
                    selectedadminId = admin.Id;
                    txtName.Text = admin.Name;
                    txtPhone.Text = admin.Phone;
                    cmbAddress.Text = admin.Address;
                    txtPassword.Text = admin.Password;
                    cmbRole.Text = admin.Role;
                }
            }
        }
    }
}
