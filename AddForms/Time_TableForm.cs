using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Unicom.DB.Controller;
using Unicom.DB.Dashboard_Form;
using Unicom.DB.Models;

namespace Unicom.DB.AddForms
{
    public partial class Time_Table : Form
    {
        private readonly Time_TableController _time_tableController;
        private readonly CourseController _courseController;
        private int selectedCourseId = -1;

        public Time_Table()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");


            this.BackgroundImageLayout = ImageLayout.Stretch;
            _time_tableController = new Time_TableController();
            _courseController = new CourseController();

            LoadTime_Table();
            LoadCourse();

            cmbSubject_Id.SelectedIndexChanged += cmbSubject_Id_SelectedIndexChanged;
        }
        private void LoadTime_Table()
        {
            dgvTime_Table.DataSource = null;
            dgvTime_Table.DataSource = _time_tableController.GetAllTimeTable();

            if (dgvTime_Table.Columns.Contains("CourseId"))
            {
                dgvTime_Table.Columns["CourseId"].Visible = false;
            }
            dgvTime_Table.ClearSelection();
        }

        private void cmbSubject_Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject_Id.SelectedItem is Subject selectedSubject)
            {
                txtSubject.Text = selectedSubject.Subject_Name;
            }
        }


        private void LoadCourse()
        {
            var subjects = new SubjectController().GetAllSubject();  
            cmbSubject_Id.DataSource = subjects;
            cmbSubject_Id.DisplayMember = "Subject_Id";            
            cmbSubject_Id.ValueMember = "Subject_Id";                

            if (cmbSubject_Id.SelectedItem is Subject selectedSubject)
            {
                txtSubject.Text = selectedSubject.Subject_Name;
            }
        }

        private void ClearForm()
        {
            txtRoomName.Clear();
            cmbSubject_Id.SelectedIndex = -1;
            selectedCourseId = -1;
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                MessageBox.Show("Please enter both RoomId and TimeSlot.");
                return;
            }

            var timt_table = new TimeTable
            {
                Room_Id = int.Parse(cmbRoomId.Text),
                Room_Name = txtRoomName.Text,
                TimeSlot = int.Parse(txtTimeSlot.Text),
                Subject = txtSubject.Text,
                Subject_Id = (int)cmbSubject_Id.SelectedValue
            };
            _time_tableController.UpdateTimeTable(timt_table);
            LoadTime_Table();
            ClearForm();
            MessageBox.Show("TimeTable Update Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                MessageBox.Show("Please enter both RoomId and TimeSlot.");
                return;
            }

            var timt_table = new TimeTable
            {
                Room_Id = int.Parse(txtRoomName.Text),
                Room_Name = txtRoomName.Text,
                TimeSlot = int.Parse(txtTimeSlot.Text),
                Subject = txtSubject.Text,
                Subject_Id = (int)cmbSubject_Id.SelectedValue
            };

            _time_tableController.AddTimeTable(timt_table);
            LoadTime_Table();
            ClearForm();
            MessageBox.Show("TimeTable Added Successfully");

        }
        private void ClearInputs()
        {
            txtRoomName.Text = "";
            txtTimeSlot.Text = "";
        }

        private void dgvTime_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTime_Table.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTime_Table.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _time_tableController.DeleteTimeTable(id);
                    LoadTime_Table();
                    ClearInputs();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSubject_id_Load(object sender, EventArgs e)
        {

        }

        private void dgvTime_Table_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTime_Table.SelectedRows.Count > 0)
            {
                var row = dgvTime_Table.SelectedRows[0];
                var TimeTableView = row.DataBoundItem as TimeTable;

                if (TimeTableView != null)
                {
                    selectedCourseId = TimeTableView.Subject_Id;


                    txtTimeSlot.Text = TimeTableView.TimeSlot.ToString();
                    txtRoomName.Text = TimeTableView.Room_Id.ToString();
                    txtSubject.Text = TimeTableView.Subject.ToString();
                    cmbSubject_Id.SelectedValue = TimeTableView.Subject_Id;
                }
            }
            else
            {
                ClearInputs();
                selectedCourseId = -1;
            }
        }
    }
}
