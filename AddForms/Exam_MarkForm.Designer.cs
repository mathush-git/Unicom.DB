namespace Unicom.DB.AddForms
{
    partial class Exam_MarkForm
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
            dgvExam_Mark = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbExam = new ComboBox();
            txtMark = new TextBox();
            label5 = new Label();
            cmbSubjectName = new ComboBox();
            cmbStudentId = new ComboBox();
            btnBack_pageL = new Button();
            btnBack_PageS = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvExam_Mark).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(516, 84);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(565, 142);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(598, 199);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(598, 263);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(89, 23);
            btnBack_Page.TabIndex = 3;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(598, 386);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(89, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvExam_Mark
            // 
            dgvExam_Mark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam_Mark.Location = new Point(40, 244);
            dgvExam_Mark.Name = "dgvExam_Mark";
            dgvExam_Mark.Size = new Size(520, 175);
            dgvExam_Mark.TabIndex = 5;
            dgvExam_Mark.CellContentClick += dgvExam_Mark_CellContentClick;
            dgvExam_Mark.SelectionChanged += dgvExam_Mark_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 6;
            label1.Text = "Student_Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 167);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 7;
            label2.Text = "Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 203);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 8;
            label3.Text = "Mark";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(335, 16);
            label4.Name = "label4";
            label4.Size = new Size(185, 21);
            label4.TabIndex = 9;
            label4.Text = "Exam_Mark Add Form";
            // 
            // cmbExam
            // 
            cmbExam.FormattingEnabled = true;
            cmbExam.Location = new Point(178, 164);
            cmbExam.Name = "cmbExam";
            cmbExam.Size = new Size(170, 23);
            cmbExam.TabIndex = 11;
            cmbExam.SelectedIndexChanged += cmbExam_SelectedIndexChanged;
            // 
            // txtMark
            // 
            txtMark.Location = new Point(178, 203);
            txtMark.Name = "txtMark";
            txtMark.Size = new Size(170, 23);
            txtMark.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(72, 122);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 14;
            label5.Text = "Subject_Name";
            // 
            // cmbSubjectName
            // 
            cmbSubjectName.FormattingEnabled = true;
            cmbSubjectName.Location = new Point(178, 119);
            cmbSubjectName.Name = "cmbSubjectName";
            cmbSubjectName.Size = new Size(170, 23);
            cmbSubjectName.TabIndex = 15;
            // 
            // cmbStudentId
            // 
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(178, 76);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(170, 23);
            cmbStudentId.TabIndex = 16;
            // 
            // btnBack_pageL
            // 
            btnBack_pageL.Location = new Point(598, 303);
            btnBack_pageL.Name = "btnBack_pageL";
            btnBack_pageL.Size = new Size(89, 23);
            btnBack_pageL.TabIndex = 17;
            btnBack_pageL.Text = "Back_page(L)";
            btnBack_pageL.UseVisualStyleBackColor = true;
            btnBack_pageL.Click += btnBack_pageL_Click;
            // 
            // btnBack_PageS
            // 
            btnBack_PageS.Location = new Point(598, 347);
            btnBack_PageS.Name = "btnBack_PageS";
            btnBack_PageS.Size = new Size(89, 23);
            btnBack_PageS.TabIndex = 18;
            btnBack_PageS.Text = "Back_Page(S)";
            btnBack_PageS.UseVisualStyleBackColor = true;
            btnBack_PageS.Click += btnBack_PageS_Click;
            // 
            // Exam_MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack_PageS);
            Controls.Add(btnBack_pageL);
            Controls.Add(cmbStudentId);
            Controls.Add(cmbSubjectName);
            Controls.Add(label5);
            Controls.Add(txtMark);
            Controls.Add(cmbExam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvExam_Mark);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "Exam_MarkForm";
            Text = "Exam_MarkForm";
            Load += Exam_MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvExam_Mark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack_Page;
        private Button btnCancel;
        private DataGridView dgvExam_Mark;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbExam;
        private TextBox txtMark;
        private Label label5;
        private ComboBox cmbSubjectName;
        private ComboBox cmbStudentId;
        private Button btnBack_pageL;
        private Button btnBack_PageS;
    }
}