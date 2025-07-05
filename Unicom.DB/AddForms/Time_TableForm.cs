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
using Unicom.DB.Service;

namespace Unicom.DB.AddForms
{
    public partial class Time_Table : Form
    {
        private int currentSelectedTimeTabId = 0;
        private readonly Time_TableController _time_tableController;
        private readonly RoomController _roomController = new RoomController();
        private readonly CourseController _courseController;
        private int selectedCourseId = -1;

        private string _userRole;

        public Time_Table(string userRole)
        {
            InitializeComponent();

            _userRole = userRole;
            

            switch (_userRole)
            {
                case "Admin":
                    btnBack_PageL.Visible = false;
                    btnBack_PageS.Visible = false;

                    break;

                case "Lecturer":
                    btnBack_PageS.Visible = false;
                    btnBack_Page.Visible = false;
                    btnBack_PageL.Visible = true;
                    break;

                case "Staff":
                    btnBack_PageL.Visible = false;
                    btnBack_Page.Visible = false;
                    btnBack_PageS.Visible = true;
                    break;

                default:

                    btnBack_PageL.Visible = true;
                    btnBack_PageS.Visible = true;
                    btnBack_Page.Visible = true;
                    break;
            }



            _time_tableController = new Time_TableController();
            _courseController = new CourseController();

            LoadTime_Table();
            LoadCourse();
            LoadTimeSlots();
            LoadRooms();
            cmbRoomId.SelectedIndexChanged += cmbRoomId_SelectedIndexChanged;

            cmbSubject_Id.SelectedIndexChanged += cmbSubject_Id_SelectedIndexChanged;
        }

        private void LoadTimeSlots()
        {
            cmbTime_Slot.Items.Clear(); // Clear existing items if any

            // Add time slots manually
            cmbTime_Slot.Items.Add("9:00 AM To 5.00 PM");
            cmbTime_Slot.Items.Add("9:00 AM To 10.30 AM");
            cmbTime_Slot.Items.Add("10:30 AM To 12.00 PM");
            cmbTime_Slot.Items.Add("1.00 PM To 2.30 PM");
            cmbTime_Slot.Items.Add("2.30 PM To 5.00 PM");
            cmbTime_Slot.Items.Add("9:00 AM To 12.00 PM");
            cmbTime_Slot.Items.Add("9:00 AM To 2.00 PM");

            cmbTime_Slot.SelectedIndex = -1; // No selection by default
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

        private void LoadRooms()
        {
            var rooms = _roomController.GetAllRooms();
            cmbRoomId.DataSource = null;
            cmbRoomId.DataSource = rooms;
            cmbRoomId.DisplayMember = "Id";
            cmbRoomId.ValueMember = "Id";
            cmbRoomId.SelectedIndex = -1;
        }


        private void cmbRoomId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomId.SelectedItem is Room selectedRoom)
            {
                txtRoomName.Text = selectedRoom.Name;
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
            if (cmbRoomId.SelectedValue == null ||
                cmbTime_Slot.SelectedValue == null ||
                cmbSubject_Id.SelectedValue == null ||
                string.IsNullOrWhiteSpace(txtRoomName.Text) ||
                string.IsNullOrWhiteSpace(txtSubject.Text))
            {
                /* MessageBox.Show("Please fill in all fields and make selections.");
                 return;*/
            }

            var timt_table = new TimeTable
            {
                TimeTab_Id = currentSelectedTimeTabId,
                Room_Id = Convert.ToInt32(cmbRoomId.SelectedValue),
                Room_Name = txtRoomName.Text,
                TimeSlot = cmbTime_Slot.Text,
                Subject = txtSubject.Text,
                Subject_Id = Convert.ToInt32(cmbSubject_Id.SelectedValue)
            };


            _time_tableController.UpdateTimeTable(timt_table);
            LoadTime_Table();
            ClearForm();
            MessageBox.Show("TimeTable Update Successfully");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || string.IsNullOrWhiteSpace(cmbTime_Slot.Text))
            {
                MessageBox.Show("Please enter both RoomId and TimeSlot.");
                return;
            }

            var timt_table = new TimeTable
            {
                Room_Id = Convert.ToInt32(cmbRoomId.SelectedValue),
                Room_Name = txtRoomName.Text,
                TimeSlot = cmbTime_Slot.Text,
                Subject = txtSubject.Text,
                Subject_Id = Convert.ToInt32(cmbSubject_Id.SelectedValue)
            };

            _time_tableController.AddTimeTable(timt_table);
            LoadTime_Table();
            ClearForm();
            MessageBox.Show("TimeTable Added Successfully");

        }
        private void ClearInputs()
        {
            txtRoomName.Text = "";
            cmbTime_Slot.Text = "";
        }

        private void dgvTime_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTime_Table.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvTime_Table.SelectedRows[0].Cells["TimeTab_Id"].Value);

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
            if (dgvTime_Table.CurrentRow != null)
            {
                var TimeTableView = dgvTime_Table.CurrentRow.DataBoundItem as TimeTable;
                if (TimeTableView != null)
                {
                    currentSelectedTimeTabId = TimeTableView.TimeTab_Id;
                    selectedCourseId = TimeTableView.Subject_Id;

                    cmbTime_Slot.Text = TimeTableView.TimeSlot.ToString();
                    txtRoomName.Text = TimeTableView.Room_Id.ToString();
                    txtSubject.Text = TimeTableView.Subject;
                    cmbSubject_Id.SelectedValue = TimeTableView.Subject_Id;
                    cmbRoomId.SelectedValue = TimeTableView.Room_Id;
                }
            }
            else
            {
                ClearInputs();
                selectedCourseId = -1;
            }

        }

        private void btnBack_PageL_Click(object sender, EventArgs e)
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