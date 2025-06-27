namespace Unicom.DB
{
    partial class Course_Form
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
            txtName = new Label();
            couseName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvCourse = new DataGridView();
            label2 = new Label();
            btnBack_Page = new Button();
            btnCancel = new Button();
            btnBack_pageL = new Button();
            btnBack_PageS = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Location = new Point(173, 94);
            txtName.Name = "txtName";
            txtName.Size = new Size(79, 15);
            txtName.TabIndex = 0;
            txtName.Text = "Course Name";
            // 
            // couseName
            // 
            couseName.Location = new Point(282, 91);
            couseName.Name = "couseName";
            couseName.Size = new Size(235, 23);
            couseName.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(546, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += add_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(411, 164);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += update_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(282, 164);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += delete_Click;
            // 
            // dgvCourse
            // 
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourse.Location = new Point(264, 220);
            dgvCourse.Name = "dgvCourse";
            dgvCourse.Size = new Size(243, 150);
            dgvCourse.TabIndex = 7;
            dgvCourse.CellContentClick += dgvCourse_CellContentClick;
            dgvCourse.SelectionChanged += dgvCourse_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(329, 24);
            label2.Name = "label2";
            label2.Size = new Size(145, 21);
            label2.TabIndex = 8;
            label2.Text = "Course Add Form";
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(80, 388);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(93, 23);
            btnBack_Page.TabIndex = 9;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(653, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnBack_pageL
            // 
            btnBack_pageL.Location = new Point(264, 388);
            btnBack_pageL.Name = "btnBack_pageL";
            btnBack_pageL.Size = new Size(93, 23);
            btnBack_pageL.TabIndex = 11;
            btnBack_pageL.Text = "Back_page(L)";
            btnBack_pageL.UseVisualStyleBackColor = true;
            btnBack_pageL.Click += btnBack_pageL_Click;
            // 
            // btnBack_PageS
            // 
            btnBack_PageS.Location = new Point(469, 388);
            btnBack_PageS.Name = "btnBack_PageS";
            btnBack_PageS.Size = new Size(87, 23);
            btnBack_PageS.TabIndex = 12;
            btnBack_PageS.Text = "Back_Page(S)";
            btnBack_PageS.UseVisualStyleBackColor = true;
            btnBack_PageS.Click += btnBack_PageS_Click;
            // 
            // Course_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack_PageS);
            Controls.Add(btnBack_pageL);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(label2);
            Controls.Add(dgvCourse);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(couseName);
            Controls.Add(txtName);
            Name = "Course_Form";
            Text = "CourseForm";
            Load += Course_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private TextBox couseName;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvCourse;
        private Label label2;
        private Button btnBack_Page;
        private Button btnCancel;
        private Button btnBack_pageL;
        private Button btnBack_PageS;
    }
}