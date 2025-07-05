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
    public partial class ExamForm : Form
    {
        private ExamController examController = new ExamController();
        public ExamForm()
        {
            InitializeComponent();
            
            LoadExam();
        }

        private void LoadExam()
        {
            dgvExam.DataSource = null;
            dgvExam.DataSource = examController.GetAllExam();
            dgvExam.ClearSelection();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExam.Text))
            {
                MessageBox.Show("Please enter a Exam name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to add this Exam?",
                "Confirm Add",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                var exam = new ExamItem
                {
                    Name = txtExam.Text.Trim()
                };

                try
                {
                    examController.AddExam(exam);
                    LoadExam();
                    txtExam.Clear();

                    MessageBox.Show("Exam added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while adding the Exam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                if (string.IsNullOrWhiteSpace(txtExam.Text))
                {
                    MessageBox.Show("Please enter a Exam name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvExam.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to update this Exam?",
                    "Confirm Update",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    var exam = new ExamItem
                    {
                        Id = id,
                        Name = txtExam.Text.Trim()
                    };

                    try
                    {
                        examController.UpdateExam(exam);
                        LoadExam();
                        txtExam.Clear();
                        MessageBox.Show("Exam updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while updating the Exam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Exam to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvExam.SelectedRows[0].Cells["Id"].Value);

                var result = MessageBox.Show(
                    "Are you sure you want to delete this course?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        examController.DeleteExam(id);
                        LoadExam();
                        txtExam.Clear();
                        MessageBox.Show("Exam deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting Exam: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Exam to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnBack_Page_Click(object sender, EventArgs e)
        {
            AdminDashboard admindashboard = new AdminDashboard();
            admindashboard.Show();
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void dgvExam_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvExam.SelectedRows.Count > 0)
            {
                txtExam.Text = dgvExam.SelectedRows[0].Cells["Name"].Value.ToString();
            }
        }
    }
}
