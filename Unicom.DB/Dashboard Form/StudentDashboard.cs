using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom.DB.View_Form;

namespace Unicom.DB.Dashboard_Form
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnExam_Marks_Click(object sender, EventArgs e)
        {
            Exam_Mark_Form exam_mark_Form = new Exam_Mark_Form();
            exam_mark_Form.Show();
            this.Hide();
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            Time_Table_Form time_table_Form = new Time_Table_Form();
            time_table_Form.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            CourseForm courseForm = new CourseForm();
            courseForm.Show();
            this.Hide();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
