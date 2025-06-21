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
using Unicom.DB.Models;

namespace Unicom.DB.AddForms
{
    public partial class StaffForm : Form
    {
        private StaffController _controller = new StaffController();
        private int selectedStaffId = -1;

        public StaffForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadStaff();
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

        private void LoadStaff()
        {
            dgvStaff.DataSource = _controller.GetAllStaff();
            dgvStaff.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name,Phone, Address, Password and Role.");
                return;
            }

            Staff staff = new Staff
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };
            _controller.AddStaff(staff);
            LoadStaff();
            ClearInputs();
            MessageBox.Show("Staff Added Successfully");
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            cmbAddress.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
            selectedStaffId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a Staff to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name, Phone, Address, Password and Role.");
                return;
            }
            Staff staff = new Staff
            {
                Id = selectedStaffId,
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };
            _controller.UpdateStaff(staff);
            LoadStaff();
            ClearInputs();
            MessageBox.Show("Staff Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a Staff to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Staff?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _controller.DeleteStaff(selectedStaffId);
                LoadStaff();
                ClearInputs();
                MessageBox.Show("Staff Delete Successfully");
            }
        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            admindashboard.Show();
            this.Hide();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show(); 
            this.Hide();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                var row = dgvStaff.SelectedRows[0];
                var staff = row.DataBoundItem as Staff;
                if (staff != null)
                {
                    selectedStaffId = staff.Id;
                    txtName.Text = staff.Name;
                    txtPhone.Text = staff.Phone;
                    cmbAddress.Text = staff.Address;
                    txtPassword.Text = staff.Password;
                    cmbRole.Text = staff.Role;
                }
            }
        }
    }

}
