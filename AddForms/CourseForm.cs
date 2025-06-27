using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Collections.Specialized.BitVector32;

namespace Unicom.DB
{
    public partial class Course_Form : Form
    {
        private CourseController courseController = new CourseController();

        private string _userRole;
        public Course_Form(string userRole)
        {
            InitializeComponent();

            _userRole = userRole;
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;

            switch (_userRole)
            {
                case "Admin":
                    btnBack_pageL.Visible = false;  
                    btnBack_PageS.Visible = false;  
                                                    
                    break;

                case "Lecturer":
                    btnBack_PageS.Visible = false;  
                    btnBack_Page.Visible = false;   
                    btnBack_pageL.Visible = true;   
                    break;

                case "Staff":
                    btnBack_pageL.Visible = false;  
                    btnBack_Page.Visible = false;   
                    btnBack_PageS.Visible = true;  
                    break;

                default:
                    
                    btnBack_pageL.Visible = true;
                    btnBack_PageS.Visible = true;
                    btnBack_Page.Visible = true;
                    break;
            }

            LoadCourse();
        }

        public Course_Form() : this("Unknown") 
        {
        }

        private void LoadCourse()
        {
            dgvCourse.DataSource = null;
            dgvCourse.DataSource = courseController.GetAllCourse();
            dgvCourse.ClearSelection();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(couseName.Text))
            {
                MessageBox.Show("Please enter a course name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to add this course?",
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var course = new Course
                {
                    Name = couseName.Text.Trim()
                };

                try
                {
                    courseController.AddCourse(course);
                    LoadCourse();
                    couseName.Clear();

                    MessageBox.Show("Course added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void update_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(couseName.Text))
                {
                    MessageBox.Show("Please enter a course name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to update this course?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    var course = new Course
                    {
                        Id = id,
                        Name = couseName.Text.Trim()
                    };

                    try
                    {
                        courseController.UpdateCourse(course);
                        LoadCourse();
                        couseName.Clear();
                        MessageBox.Show("Course updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void delete_Click(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvCourse.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to delete this course?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        courseController.DeleteCourse(id);
                        LoadCourse();
                        couseName.Clear();
                        MessageBox.Show("Course deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting course: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a course to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void Course_Form_Load(object sender, EventArgs e)
        {

        }

        private void dgvCourse_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCourse.SelectedRows.Count > 0)
            {
                couseName.Text = dgvCourse.SelectedRows[0].Cells["Name"].Value.ToString();
            }
        }

        private void btnBack_pageL_Click(object sender, EventArgs e)
        {
            LecturerDashboard lecturerDashboard = new LecturerDashboard();
            lecturerDashboard.Show();
            this.Hide();
        }

        private void btnBack_PageS_Click(object sender, EventArgs e)
        {
            StaffDashboard staffDashboard = new StaffDashboard();
            staffDashboard.Show();
            this.Hide();
        }
    }
}
