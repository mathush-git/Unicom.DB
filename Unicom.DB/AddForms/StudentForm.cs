using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom.DB.Controller;
using Unicom.DB.Dashboard_Form;
using Unicom.DB.Models;

namespace Unicom.DB
{
    public partial class StudentForm : Form
    {
        private readonly StudentController _studentController;
        private readonly CourseController _courseController;
        private int selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
           
            _studentController = new StudentController();
            _courseController = new CourseController();

            LoadStudents();
            LoadSections();
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
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedItem != null)
            {
                var selectedCourse = cmbCourse.SelectedItem as Course;
                if (selectedCourse != null)
                {
                    cmbCourseId.SelectedValue = selectedCourse.Id;
                }
            }
        }

        private void cmbCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourseId.SelectedItem != null)
            {
                var selectedCourse = cmbCourseId.SelectedItem as Course;
                if (selectedCourse != null)
                {
                    cmbCourse.SelectedValue = selectedCourse.Id;
                }
            }
        }




        private void LoadStudents()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = _studentController.GetAllStudent();

            // Hide the SectionId column if it exists
            if (dgvStudents.Columns.Contains("CourseId"))
            {
                dgvStudents.Columns["CourseId"].Visible = false;
            }

            dgvStudents.ClearSelection();
        }

        private void LoadSections()
        {
            var courses = _courseController.GetAllCourse();

            cmbCourse.DataSource = new List<Course>(courses);
            cmbCourse.DisplayMember = "Name";
            cmbCourse.ValueMember = "Id";
            cmbCourse.SelectedIndexChanged += cmbCourse_SelectedIndexChanged;

            cmbCourseId.DataSource = new List<Course>(courses);
            cmbCourseId.DisplayMember = "Id";
            cmbCourseId.ValueMember = "Id";
            cmbCourseId.SelectedIndexChanged += cmbCourseId_SelectedIndexChanged;
        }



        private void ClearForm()
        {
            txtName.Clear();
            cmbAddress.SelectedIndex = -1;
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbCourseId.SelectedIndex = -1;
            selectedStudentId = -1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text))
            {
                MessageBox.Show("Please enter both Name, Password, Address, Role .");
                return;
            }

            if (cmbCourse.SelectedValue == null)
            {
                MessageBox.Show("Please select a Course.");
                return;
            }

            var student = new Student
            {
                Name = txtName.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text,
                Course = cmbCourse.Text,
                CourseId = (int)cmbCourseId.SelectedValue
            };

            _studentController.AddStudent(student);
            LoadStudents();
            ClearForm();
            MessageBox.Show("Student Added Successfully");

        }


        private void ClearInputs()
        {
            txtName.Text = "";
            cmbAddress.Text = "";
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                var studentView = row.DataBoundItem as Student;

                if (studentView != null)
                {
                    selectedStudentId = studentView.Id;
                    txtName.Text = studentView.Name;
                    cmbAddress.Text = studentView.Address;
                    txtPassword.Text = studentView.Password;
                    cmbRole.Text = studentView.Role;
                    cmbCourse.Text = studentView.Course;
                    cmbCourse.SelectedValue = studentView.CourseId;
                }
            }
            else
            {
                ClearInputs();
                selectedStudentId = -1;
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(cmbAddress.Text))
            {
                MessageBox.Show("Please enter both Name and Address.");
                return;
            }

            var student = new Student
            {
                Id = selectedStudentId,
                Name = txtName.Text,
                Address = cmbAddress.Text,
                Password = txtPassword.Text,
                Role = cmbRole.Text,
                CourseId = (int)cmbCourseId.SelectedValue,
                Course = cmbCourse.Text

            };

            _studentController.UpdateStudent(student);
            LoadStudents();
            ClearForm();
            MessageBox.Show("Student Updated Successfully");

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _studentController.DeleteStudent(selectedStudentId);
                LoadStudents();
                ClearForm();
                MessageBox.Show("Student Deleted Successfully");

            }
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void dgvStudents_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                var row = dgvStudents.SelectedRows[0];
                var student = row.DataBoundItem as Student;
                if (student != null)
                {
                    selectedStudentId = student.Id;
                    txtName.Text = student.Name;
                    txtPassword.Text = student.Password;
                    cmbAddress.Text = student.Address;
                    cmbRole.Text = student.Role;
                    cmbCourse.Text = student.Course;
                    cmbCourse.SelectedValue = student.CourseId;
                }
            }
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
