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
            ((System.ComponentModel.ISupportInitialize)dgvView_Course_Form).BeginInit();
            SuspendLayout();
            // 
            // dgvView_Course_Form
            // 
            dgvView_Course_Form.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvView_Course_Form.Location = new Point(26, 85);
            dgvView_Course_Form.Name = "dgvView_Course_Form";
            dgvView_Course_Form.Size = new Size(744, 333);
            dgvView_Course_Form.TabIndex = 0;
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
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dgvView_Course_Form);
            Name = "CourseForm";
            Text = "Course_Form";
            ((System.ComponentModel.ISupportInitialize)dgvView_Course_Form).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvView_Course_Form;
        private Label label1;
    }
}