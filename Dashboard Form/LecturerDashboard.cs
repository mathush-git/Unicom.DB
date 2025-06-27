using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unicom.DB.AddForms;

namespace Unicom.DB.Dashboard_Form
{
    public partial class LecturerDashboard : Form
    {
        public LecturerDashboard()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\B.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTime_Table_Click(object sender, EventArgs e)
        {
            Time_Table time_tableForm = new Time_Table("Lecturer");
            time_tableForm.Show();
            this.Hide();
        }

        private void BtnExam_Marks_Click(object sender, EventArgs e)
        {
            Exam_MarkForm exam_markForm = new Exam_MarkForm("Lecturer");
            exam_markForm.Show();
            this.Hide();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            Course_Form courseForm = new Course_Form("Lecturer");
            courseForm.Show();
            this.Hide();
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

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
