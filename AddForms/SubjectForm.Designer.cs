namespace Unicom.DB.AddForms
{
    partial class SubjectForm
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
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbCourse_Id = new ComboBox();
            dgvSubject = new DataGridView();
            txtSubject = new TextBox();
            txtCourse = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(531, 169);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(625, 212);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 254);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(625, 313);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 3;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(625, 370);
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
            label1.Location = new Point(310, 42);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 5;
            label1.Text = "Subject Add Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(219, 98);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Subject_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(219, 173);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 7;
            label3.Text = "Course_Name";
            // 
            // cmbCourse_Id
            // 
            cmbCourse_Id.FormattingEnabled = true;
            cmbCourse_Id.Location = new Point(310, 130);
            cmbCourse_Id.Name = "cmbCourse_Id";
            cmbCourse_Id.Size = new Size(180, 23);
            cmbCourse_Id.TabIndex = 8;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(142, 215);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(415, 197);
            dgvSubject.TabIndex = 10;
            dgvSubject.SelectionChanged += dgvSubject_SelectionChanged;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(310, 90);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(180, 23);
            txtSubject.TabIndex = 11;
            // 
            // txtCourse
            // 
            txtCourse.Location = new Point(310, 165);
            txtCourse.Name = "txtCourse";
            txtCourse.Size = new Size(180, 23);
            txtCourse.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 13;
            label4.Text = "Course_Id";
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(txtCourse);
            Controls.Add(txtSubject);
            Controls.Add(dgvSubject);
            Controls.Add(cmbCourse_Id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "SubjectForm";
            Text = "SubjectForm";
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbCourse_Id;
        private DataGridView dgvSubject;
        private TextBox txtSubject;
        private TextBox txtCourse;
        private Label label4;
    }
}