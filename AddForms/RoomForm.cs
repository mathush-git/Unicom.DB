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
using Unicom.DB.Models;

namespace Unicom.DB.AddForms
{
    public partial class RoomForm : Form
    {
        private readonly RoomController _roomController = new RoomController();

        public RoomForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C#\\Management System for C#\\Unicom.DB\\A.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            LoadRooms();
        }

        private void LoadRooms()
        {
            dgvRoomName.DataSource = null;
            dgvRoomName.DataSource = _roomController.GetAllRooms();
            dgvRoomName.ClearSelection();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text))
            {
                MessageBox.Show("Please enter a Room name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to add this Room?", "Confirm Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                var room = new Room
                {
                    Name = txtRoomName.Text.Trim()
                };

                try
                {
                    _roomController.AddRoom(room);
                    LoadRooms();
                    txtRoomName.Clear();
                    MessageBox.Show("Room added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRoomName.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtRoomName.Text))
                {
                    MessageBox.Show("Please enter a Room name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvRoomName.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show("Are you sure you want to update this Room?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    var room = new Room
                    {
                        Id = id,
                        Name = txtRoomName.Text.Trim()
                    };

                    try
                    {
                        _roomController.UpdateRoom(room);
                        LoadRooms();
                        txtRoomName.Clear();
                        MessageBox.Show("Room updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Room to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvRoomName.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvRoomName.SelectedRows[0].Cells["Id"].Value);

                var confirm = MessageBox.Show("Are you sure you want to delete this Room?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        _roomController.DeleteRoom(id);
                        LoadRooms();
                        txtRoomName.Clear();
                        MessageBox.Show("Room deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting room: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Room to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void dgvRoomName_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoomName.SelectedRows.Count > 0)
            {
                txtRoomName.Text = dgvRoomName.SelectedRows[0].Cells["Name"].Value.ToString();
            }
        }
    }
}
