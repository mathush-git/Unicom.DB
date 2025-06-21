namespace Unicom.DB.View_Form
{
    partial class Time_Table_Form
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
            dvg_View_Time_Table_Form = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dvg_View_Time_Table_Form).BeginInit();
            SuspendLayout();
            // 
            // dvg_View_Time_Table_Form
            // 
            dvg_View_Time_Table_Form.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvg_View_Time_Table_Form.Location = new Point(43, 94);
            dvg_View_Time_Table_Form.Name = "dvg_View_Time_Table_Form";
            dvg_View_Time_Table_Form.Size = new Size(714, 283);
            dvg_View_Time_Table_Form.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(292, 41);
            label1.Name = "label1";
            label1.Size = new Size(187, 21);
            label1.TabIndex = 1;
            label1.Text = "View Time_Table Form";
            // 
            // Time_Table_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dvg_View_Time_Table_Form);
            Name = "Time_Table_Form";
            Text = "Time_Table_Form";
            ((System.ComponentModel.ISupportInitialize)dvg_View_Time_Table_Form).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvg_View_Time_Table_Form;
        private Label label1;
    }
}