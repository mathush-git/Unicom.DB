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

namespace Unicom.DB.View_Form
{
    public partial class Exam_Mark_Form : Form
    {
        public Exam_Mark_Form()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\F.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

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
