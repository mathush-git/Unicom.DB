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

namespace Unicom.DB.View_Form
{
    public partial class CourseForm : Form
    {
        private CourseController courseController = new CourseController();

        public CourseForm()
        {
            InitializeComponent();
            
            ReloadCourses();

            // Hook up the event
            dgvView_Course_Form.SelectionChanged += dgvView_Course_Form_SelectionChanged;
        }

        public void ReloadCourses()
        {
            var courses = courseController.GetAllCourse();
            dgvView_Course_Form.DataSource = null;
            dgvView_Course_Form.DataSource = courses;
            dgvView_Course_Form.ClearSelection();
        }

        private void dgvView_Course_Form_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvView_Course_Form.SelectedRows.Count > 0)
            {
                var cell = dgvView_Course_Form.SelectedRows[0].Cells["Name"];
                if (cell != null && cell.Value != null)
                    MessageBox.Show(cell.Value.ToString(), "Selected Course");
            }
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

        private void CourseForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvView_Course_Form_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
