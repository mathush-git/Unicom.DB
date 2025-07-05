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
using Unicom.DB.Service;

namespace Unicom.DB.AddForms
{
    public partial class Exam_MarkForm : Form
    {
        private readonly ExamController _examController = new ExamController();
        private readonly Exam_MarkController _markController = new Exam_MarkController();
        private readonly SubjectController _subjectController = new SubjectController();

        private string _userRole;

        private int selectedstudentId = -1;
        public Exam_MarkForm(string userRole)
        {
            InitializeComponent();

            _userRole = userRole;
            

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


            LoadExam_Mark();
            LoadSubjects();
            LoadStudents();

            cmbSubjectName.SelectedIndexChanged += cmbSubjectName_SelectedIndexChanged;

            cmbExam.SelectedIndexChanged += cmbExam_SelectedIndexChanged;
        }

        private void cmbSubjectName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubjectName.SelectedItem is Subject selectedSubject)
            {
                cmbSubjectName.Text = selectedSubject.Subject_Name; // Optional display
            }
        }


        private void LoadExam_Mark()
        {

            var examList = _examController.GetAllExam();

            cmbExam.DataSource = null;
            cmbExam.DataSource = examList;
            cmbExam.DisplayMember = "Name";
            cmbExam.ValueMember = "Id";

            dgvExam_Mark.DataSource = null;
            dgvExam_Mark.DataSource = _markController.GetAllExam_mark();
            dgvExam_Mark.ClearSelection();
        }



        private void LoadSubjects()
        {
            var subjects = _subjectController.GetAllSubject();

            cmbSubjectName.DataSource = null;
            cmbSubjectName.DataSource = subjects;
            cmbSubjectName.DisplayMember = "Subject_Name";
            cmbSubjectName.ValueMember = "Subject_Id";

            if (cmbSubjectName.SelectedItem is Subject selectedSubject)
            {
                cmbSubjectName.Text = selectedSubject.Subject_Name;
            }
        }

        private void LoadStudents()
        {
            var studentService = new StudentService();
            var students = studentService.GetAll();

            cmbStudentId.DataSource = students;
            cmbStudentId.DisplayMember = "Id";
            cmbStudentId.ValueMember = "Id";
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
            // Validate selections
            var selectedSubject = cmbSubjectName.SelectedItem as Subject;
            if (selectedSubject == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            var selectedStudent = cmbStudentId.SelectedItem as Student;
            if (selectedStudent == null)
            {
                MessageBox.Show("Please select a student.");
                return;
            }

            if (!int.TryParse(txtMark.Text, out int marks))
            {
                MessageBox.Show("Please enter valid marks.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbExam.Text))
            {
                MessageBox.Show("Please select or enter an exam name.");
                return;
            }

            // Create exam_mark object
            Exam_mark exam_mark = new Exam_mark
            {
                Student_Id = selectedStudent.Id,
                Subject_Id = selectedSubject.Subject_Id,
                Subject_Name = selectedSubject.Subject_Name,
                Exam = cmbExam.Text,
                Marks = marks
            };

            // Call service to add
            try
            {
                _markController.AddExam_mark(exam_mark);
                MessageBox.Show("Exam mark added successfully!");

                LoadExam_Mark();  // Reload data grid or list
                ClearInputs();    // Clear form inputs
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding exam mark: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            cmbStudentId.SelectedIndex = -1;
            cmbSubjectName.SelectedIndex = -1;
            cmbExam.Text = "";
            txtMark.Clear();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExam_Mark.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a record to update.");
                return;
            }

            var selectedSubject = cmbSubjectName.SelectedItem as Subject;
            if (selectedSubject == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            string subjectName = selectedSubject.Subject_Name;
            int subjectId = selectedSubject.Subject_Id;


            int selectedExamId = Convert.ToInt32(dgvExam_Mark.SelectedRows[0].Cells["Id"].Value);

            Exam_mark exam_mark = new Exam_mark
            {
                Id = selectedExamId,
                Student_Id = Convert.ToInt32(cmbStudentId.SelectedValue),
                Subject_Id = subjectId,
                Subject_Name = subjectName,
                Exam = cmbExam.Text,
                Marks = int.Parse(txtMark.Text)
            };

            _markController.UpdateExam_mark(exam_mark); // ✅ Calling service class
            LoadExam_Mark();
            ClearInputs();
            MessageBox.Show("Exam_Mark updated successfully");
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExam_Mark.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvExam_Mark.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to delete this exam mark?",
                    "Confirm Deletion",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    _markController.DeleteExam_mark(id);
                    LoadExam_Mark();
                    ClearInputs();
                    MessageBox.Show("Exam mark deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dgvExam_Mark_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Exam_MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvExam_Mark_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExam_Mark.SelectedRows.Count > 0)
            {
                var row = dgvExam_Mark.SelectedRows[0];
                var exam_mark = row.DataBoundItem as Exam_mark;  // Fix here

                if (exam_mark != null)
                {
                    selectedstudentId = exam_mark.Student_Id ?? -1;  // I think you want student id here, not Subject_Id

                    txtMark.Text = exam_mark.Marks.ToString();
                    cmbStudentId.Text = exam_mark.Student_Id.ToString();
                    cmbSubjectName.Text = exam_mark.Subject_Name.ToString();
                    cmbExam.Text = exam_mark.Exam; // Use Text property unless properly data bound
                }
            }
            else
            {
                ClearInputs();
                selectedstudentId = -1;
            }
        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbExam.SelectedItem is ExamItem selectedExam)
            {
                /* txtSubjectId.Text = selectedExam.Id.ToString();*/
            }
            else
            {
                /* txtSubjectId.Text = "";*/
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