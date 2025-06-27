namespace Unicom.DB.View_Form
{
    partial class Exam_Mark_Form
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
            dgvView_Exam_Mark = new DataGridView();
            label1 = new Label();
            btnSubmit = new Button();
            label2 = new Label();
            txtStudentId = new TextBox();
            btnBack_Page = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvView_Exam_Mark).BeginInit();
            SuspendLayout();
            // 
            // dgvView_Exam_Mark
            // 
            dgvView_Exam_Mark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView_Exam_Mark.Location = new Point(53, 204);
            dgvView_Exam_Mark.Name = "dgvView_Exam_Mark";
            dgvView_Exam_Mark.Size = new Size(651, 200);
            dgvView_Exam_Mark.TabIndex = 0;
            dgvView_Exam_Mark.SelectionChanged += dgvView_Exam_Mark_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 31);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 1;
            label1.Text = "View Exam_Mark Form";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(639, 175);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 119);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 3;
            label2.Text = "Student Id";
            label2.Click += label2_Click;
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(329, 111);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(204, 23);
            txtStudentId.TabIndex = 4;
            txtStudentId.TextChanged += txtStudentId_TextChanged;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(469, 415);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 5;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(614, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Exam_Mark_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(txtStudentId);
            Controls.Add(label2);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(dgvView_Exam_Mark);
            Name = "Exam_Mark_Form";
            Text = "Exam_Mark_Form";
            ((System.ComponentModel.ISupportInitialize)dgvView_Exam_Mark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvView_Exam_Mark;
        private Label label1;
        private Button btnSubmit;
        private Label label2;
        private TextBox txtStudentId;
        private Button btnBack_Page;
        private Button btnCancel;
    }
}