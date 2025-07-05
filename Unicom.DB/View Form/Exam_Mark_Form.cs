using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom.DB.Dashboard_Form;
using Unicom.DB.Service;

namespace Unicom.DB.View_Form
{
    public partial class Exam_Mark_Form : Form
    {
        public Exam_Mark_Form()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStudentId.Text.Trim(), out int studentId))
            {
                MessageBox.Show("Please enter a valid Student ID.");
                return;
            }

            try
            {
                var examMarkService = new Exam_MarkService();
                var examMarks = examMarkService.GetByStudentId(studentId);

                if (examMarks.Any())
                {
                    dgvView_Exam_Mark.DataSource = null;
                    dgvView_Exam_Mark.DataSource = examMarks;
                    dgvView_Exam_Mark.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No exam records found for the given Student ID.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvView_Exam_Mark.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading exam marks: " + ex.Message);
            }
        }

        private void Exam_Mark_Form_Load(object sender, EventArgs e)
        {
            dgvView_Exam_Mark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void dgvView_Exam_Mark_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            StudentDashboard studentdashboard = new StudentDashboard();
            studentdashboard.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
