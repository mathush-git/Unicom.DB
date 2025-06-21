namespace Unicom.DB.Dashboard_Form
{
    partial class StudentDashboard
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
            btnExam_Marks = new Button();
            btnTimeTable = new Button();
            btnCourse = new Button();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnExam_Marks
            // 
            btnExam_Marks.Location = new Point(307, 116);
            btnExam_Marks.Name = "btnExam_Marks";
            btnExam_Marks.Size = new Size(187, 23);
            btnExam_Marks.TabIndex = 0;
            btnExam_Marks.Text = "Exam_Marks";
            btnExam_Marks.UseVisualStyleBackColor = true;
            btnExam_Marks.Click += btnExam_Marks_Click;
            // 
            // btnTimeTable
            // 
            btnTimeTable.Location = new Point(307, 180);
            btnTimeTable.Name = "btnTimeTable";
            btnTimeTable.Size = new Size(187, 23);
            btnTimeTable.TabIndex = 1;
            btnTimeTable.Text = "TimeTable";
            btnTimeTable.UseVisualStyleBackColor = true;
            btnTimeTable.Click += btnTimeTable_Click;
            // 
            // btnCourse
            // 
            btnCourse.Location = new Point(307, 246);
            btnCourse.Name = "btnCourse";
            btnCourse.Size = new Size(187, 23);
            btnCourse.TabIndex = 2;
            btnCourse.Text = "Course";
            btnCourse.UseVisualStyleBackColor = true;
            btnCourse.Click += btnCourse_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(648, 313);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 3;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(648, 378);
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
            label1.Location = new Point(344, 26);
            label1.Name = "label1";
            label1.Size = new Size(150, 21);
            label1.TabIndex = 5;
            label1.Text = "Student Use Form";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnCourse);
            Controls.Add(btnTimeTable);
            Controls.Add(btnExam_Marks);
            Name = "StudentDashboard";
            Text = "StudentDashboard";
            Load += StudentDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExam_Marks;
        private Button btnTimeTable;
        private Button btnCourse;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label1;
    }
}