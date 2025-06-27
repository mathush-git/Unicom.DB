namespace Unicom.DB.View_Form
{
    partial class CourseForm
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
            dgvView_Course_Form = new DataGridView();
            label1 = new Label();
            btnBack_Page = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvView_Course_Form).BeginInit();
            SuspendLayout();
            // 
            // dgvView_Course_Form
            // 
            dgvView_Course_Form.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView_Course_Form.Location = new Point(262, 85);
            dgvView_Course_Form.Name = "dgvView_Course_Form";
            dgvView_Course_Form.Size = new Size(244, 235);
            dgvView_Course_Form.TabIndex = 0;
            dgvView_Course_Form.CellContentClick += dgvView_Course_Form_CellContentClick;
            dgvView_Course_Form.SelectionChanged += dgvView_Course_Form_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 35);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 1;
            label1.Text = "View Course Form";
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(208, 385);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 2;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(511, 385);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(label1);
            Controls.Add(dgvView_Course_Form);
            Name = "CourseForm";
            Text = "Course_Form";
            Load += CourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvView_Course_Form).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvView_Course_Form;
        private Label label1;
        private Button btnBack_Page;
        private Button btnCancel;
    }
}