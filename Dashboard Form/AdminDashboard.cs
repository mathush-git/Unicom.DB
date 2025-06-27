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
using Unicom.DB.Models;

namespace Unicom.DB.Dashboard_Form
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\B.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Time_Table time_tableForm = new Time_Table("Admin");
            time_tableForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            staffForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LecturerForm lecturerForm = new LecturerForm();
            lecturerForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Course_Form courseForm = new Course_Form("Admin");
            courseForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Exam_MarkForm exam_markForm = new Exam_MarkForm("Admin");
            exam_markForm.Show();
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SubjectForm subjectForm = new SubjectForm();
            subjectForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RoomForm roomForm = new RoomForm();
            roomForm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            examForm.Show();
            this.Hide();
        }
    }
}
