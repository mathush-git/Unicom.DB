namespace Unicom.DB
{
    partial class StudentForm
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
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            cmbCourse = new ComboBox();
            dgvStudents = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            label5 = new Label();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label6 = new Label();
            cmbCourseId = new ComboBox();
            label7 = new Label();
            cmbRole = new ComboBox();
            cmbAddress = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Location = new Point(521, 145);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(75, 23);
            btn_add.TabIndex = 0;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(620, 189);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 1;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(713, 238);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(75, 23);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(163, 189);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(208, 23);
            cmbCourse.TabIndex = 3;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(25, 238);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(589, 190);
            dgvStudents.TabIndex = 4;
            dgvStudents.CellContentClick += dgvStudents_CellContentClick;
            dgvStudents.SelectionChanged += dgvStudents_SelectionChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 109);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 6;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 197);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 7;
            label3.Text = "Course";
            // 
            // txtName
            // 
            txtName.Location = new Point(163, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 153);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 10;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(163, 145);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(208, 23);
            txtPassword.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(306, 18);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 12;
            label5.Text = "Student Add Form ";
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(620, 320);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 13;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 366);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(464, 57);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 16;
            label6.Text = "Role";
            // 
            // cmbCourseId
            // 
            cmbCourseId.FormattingEnabled = true;
            cmbCourseId.Location = new Point(524, 106);
            cmbCourseId.Name = "cmbCourseId";
            cmbCourseId.Size = new Size(121, 23);
            cmbCourseId.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 109);
            label7.Name = "label7";
            label7.Size = new Size(54, 15);
            label7.TabIndex = 19;
            label7.Text = "CourseId";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(524, 58);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 21;
            // 
            // cmbAddress
            // 
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(163, 106);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(208, 23);
            cmbAddress.TabIndex = 22;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAddress);
            Controls.Add(cmbRole);
            Controls.Add(label7);
            Controls.Add(cmbCourseId);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(label5);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvStudents);
            Controls.Add(cmbCourse);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private ComboBox cmbCourse;
        private DataGridView dgvStudents;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private Label label4;
        private TextBox txtPassword;
        public Label label5;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label6;
        private ComboBox cmbCourseId;
        private Label label7;
        private ComboBox cmbRole;
        private ComboBox cmbAddress;
    }
}