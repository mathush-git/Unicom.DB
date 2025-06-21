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
    public partial class SubjectForm : Form
    {
        private readonly SubjectController _subjectController;
        private readonly CourseController _courseController;
        private int selectedSubjectId = -1;
        public SubjectForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            _subjectController = new SubjectController();
            _courseController = new CourseController();
            LoadSubject();
            LoadCourse();

            cmbCourse_Id.SelectedIndexChanged += cmbCourse_Id_SelectedIndexChanged;

        }

        private void cmbCourse_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse_Id.SelectedItem is Course selectedCourse)
            {
                txtCourse.Text = selectedCourse.Name;
            }
        }

        private void LoadSubject()
        {
            dgvSubject.DataSource = null;
            dgvSubject.DataSource = _subjectController.GetAllSubject();

            if (dgvSubject.Columns.Contains("CourseId"))
            {
                dgvSubject.Columns["CourseId"].Visible = false;
            }
            dgvSubject.ClearSelection();
        }

        private void LoadCourse()
        {
            var course = _courseController.GetAllCourse();
            cmbCourse_Id.DataSource = course;
            cmbCourse_Id.DisplayMember = "Id";
            cmbCourse_Id.ValueMember = "Id";

            if (cmbCourse_Id.SelectedItem is Course selectedCourse)
            {
                txtCourse.Text = selectedCourse.Name;
            }
        }

        private void ClearForm()
        {
            txtSubject.Clear();
            txtCourse.Clear();
            cmbCourse_Id.SelectedIndex = -1;
            selectedSubjectId = -1;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please enter both Name and Course_Name.");
                return;
            }

            var subject = new Subject
            {
                
                Subject_Name = txtSubject.Text,
                Course_Name = txtCourse.Text,
                Course_Id = (int)cmbCourse_Id.SelectedValue
            };

            _subjectController.AddSubject(subject);
            LoadSubject();
            ClearForm();
            MessageBox.Show("Subject Added Successfully");
        }
        private void ClearInputs()
        {
            txtSubject.Text = "";
            txtCourse.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) || string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please enter both Name and Course_Name.");
                return;
            }

            if (selectedSubjectId <= 0)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            var subject = new Subject
            {
                Subject_Id = selectedSubjectId,
                Subject_Name = txtSubject.Text,
                Course_Name = txtCourse.Text,
                Course_Id = (int)cmbCourse_Id.SelectedValue
            };
            _subjectController.UpdateSubject(subject);
            LoadSubject();
            ClearForm();
            MessageBox.Show("Subject Update Successfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvSubject.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this Subject?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _subjectController.DeleteSubject(id);
                    LoadSubject();
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void dgvSubject_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSubject.SelectedRows.Count > 0)
            {
                var row = dgvSubject.SelectedRows[0];
                var subject = row.DataBoundItem as Subject;

                if (subject != null)
                {
                    selectedSubjectId = subject.Course_Id;


                    txtCourse.Text = subject.Course_Name.ToString();                   
                    txtSubject.Text = subject.Subject_Name.ToString();
                    cmbCourse_Id.SelectedValue = subject.Course_Id;
                }
            }
            else
            {
                ClearInputs();
                selectedSubjectId = -1;
            }
        }
    }
}
