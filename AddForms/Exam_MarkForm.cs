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

namespace Unicom.DB.AddForms
{
    public partial class Exam_MarkForm : Form
    {
        private readonly ExamController _examController = new ExamController();
        private readonly Exam_MarkController _markController = new Exam_MarkController();
        private readonly SubjectController _subjectController = new SubjectController();



        private int selectedstudentId = -1;
        public Exam_MarkForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            LoadExam_Mark();
            LoadSubjects();

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
            if (dgvExam_Mark.CurrentRow != null)
            {
                MessageBox.Show("Please select a Exam to Add. ");
                return;
            }

            Exam_mark exam_mark = new Exam_mark
            {
                Student_Id = int.Parse(txtStudentId.Text),
                Subject_Id = (int)cmbSubjectName.SelectedValue,
                Exam = cmbExam.Text,
                Marks = int.Parse(txtMark.Text)
            };
            _markController.AddExam_mark(exam_mark);
            LoadExam_Mark();
            ClearInputs();
            MessageBox.Show("Exam_Mark Add Successfully");
        }
        private void ClearInputs()
        {
            txtStudentId.Text = "";
           /* txtSubjectId.Text = "";*/
            cmbExam.Text = "";
            txtMark.Text = "";
            selectedstudentId = -1;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExam_Mark.CurrentRow == null)
            {
                MessageBox.Show("Please select a Exam to Update. ");
                return;
            }

            Exam_mark exam_mark = new Exam_mark
            {
                Student_Id = int.Parse(txtStudentId.Text),
                Subject_Id = (int)cmbSubjectName.SelectedValue,
                Exam = cmbExam.Text,
                Marks = int.Parse(txtMark.Text)
            };

            _markController.UpdateExam_mark(exam_mark);
            LoadExam_Mark();
            ClearInputs();
            MessageBox.Show("Exam_Mark Update Successfully");
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
                    selectedstudentId = exam_mark.Student_Id;  // I think you want student id here, not Subject_Id

                    txtMark.Text = exam_mark.Marks.ToString();
                    txtStudentId.Text = exam_mark.Student_Id.ToString();
                   /* txtSubjectId.Text = exam_mark.Subject_Id.ToString();*/
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
    }
}
