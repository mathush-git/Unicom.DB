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
    public partial class Time_Table_Form : Form
    {
        private Time_TableController time_tableController = new Time_TableController();

        public Time_Table_Form()
        {
            InitializeComponent();
            

            ReloadTimeTable();

            // Hook up the event
            dvg_View_Time_Table_Form.SelectionChanged += dvg_View_Time_Table_Form_SelectionChanged;
        }

        public void ReloadTimeTable()
        {
            var timetable = time_tableController.GetAllTimeTable();  // Adjust method name as per your controller

            dvg_View_Time_Table_Form.DataSource = null;
            dvg_View_Time_Table_Form.DataSource = timetable;
            dvg_View_Time_Table_Form.ClearSelection();
        }

        private void dvg_View_Time_Table_Form_SelectionChanged(object sender, EventArgs e)
        {
            if (dvg_View_Time_Table_Form.SelectedRows.Count > 0)
            {
                var selectedRow = dvg_View_Time_Table_Form.SelectedRows[0];
                var cell = selectedRow.Cells["SomeColumnName"];  // Replace "SomeColumnName" with the actual column name you want

                if (cell != null && cell.Value != null)
                {
                    MessageBox.Show(cell.Value.ToString(), "Selected Time Table Item");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            StudentDashboard studentdashboard = new StudentDashboard();
            studentdashboard.Show();
            this.Hide();
        }
    }
}
