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

namespace Unicom.DB
{
    public partial class LecturerForm : Form
    {
        private LecturerController _controller = new LecturerController();
        private int selectedlecturerId = -1;
        public LecturerForm()
        {
            InitializeComponent();
            
            LoadLecturer();
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

        private void LoadLecturer()
        {
            dgvLecturers.DataSource = _controller.GetAllLecturer();
            dgvLecturers.ClearSelection();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name, Phone, Address, Password and Role.");
                return;
            }

            Lecturer lecturer = new Lecturer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };
            _controller.AddLecturer(lecturer);
            LoadLecturer();
            ClearInputs();
            MessageBox.Show("Lecturer Added Successfully");
        }
        private void ClearInputs()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            cmbAddress.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
            selectedlecturerId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedlecturerId == -1)
            {
                MessageBox.Show("Please select a Lecturer to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(cmbRole.Text))
            {
                MessageBox.Show("Please enter both Name, Phone, Address, Password and Role.");
                return;
            }
            Lecturer lecturer = new Lecturer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text
            };
            _controller.UpdateLecturer(lecturer);
            LoadLecturer();
            ClearInputs();
            MessageBox.Show("Lecturer Updated Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedlecturerId == -1)
            {
                MessageBox.Show("Please select a Lecturer to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this Lecturer?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _controller.DeleteLecturer(selectedlecturerId);
                LoadLecturer();
                ClearInputs();
                MessageBox.Show("Lecturer Delete Successfully");
            }
        }

        private void dgvLecturers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
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

        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvLecturers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLecturers.SelectedRows.Count > 0)
            {
                var row = dgvLecturers.SelectedRows[0];
                var lecturer = row.DataBoundItem as Lecturer;
                if (lecturer != null)
                {
                    selectedlecturerId = lecturer.Id;
                    txtName.Text = lecturer.Name;
                    txtPhone.Text = lecturer.Phone;
                    cmbAddress.Text = lecturer.Address;
                    txtPassword.Text = lecturer.Password;
                    cmbRole.Text = lecturer.Role;
                }
            }
        }
    }
}
