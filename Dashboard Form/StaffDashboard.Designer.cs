namespace Unicom.DB.Dashboard_Form
{
    partial class StaffDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnTime_Table = new Button();
            btnExam_Marks = new Button();
            btnCourse = new Button();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnTime_Table
            // 
            btnTime_Table.Location = new Point(311, 140);
            btnTime_Table.Name = "btnTime_Table";
            btnTime_Table.Size = new Size(176, 23);
            btnTime_Table.TabIndex = 0;
            btnTime_Table.Text = "Time_Table";
            btnTime_Table.UseVisualStyleBackColor = true;
            btnTime_Table.Click += btnTime_Table_Click;
            // 
            // btnExam_Marks
            // 
            btnExam_Marks.Location = new Point(311, 216);
            btnExam_Marks.Name = "btnExam_Marks";
            btnExam_Marks.Size = new Size(176, 23);
            btnExam_Marks.TabIndex = 1;
            btnExam_Marks.Text = "Exam_Marks";
            btnExam_Marks.UseVisualStyleBackColor = true;
            btnExam_Marks.Click += btnExam_Marks_Click;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(311, 294);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(176, 23);
            btnCourse.TabIndex = 2;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(665, 327);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 3;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(665, 393);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(331, 63);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 5;
            label1.Text = "Staff Use Form";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnCourse);
            Controls.Add(btnExam_Marks);
            Controls.Add(btnTime_Table);
            Name = "StaffDashboard";
            Text = "StaffDashboard";
            Load += StaffDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTime_Table;
        private Button btnExam_Marks;
        private Button btnCourse;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label1;
    }
}