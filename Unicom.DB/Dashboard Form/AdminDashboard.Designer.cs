namespace Unicom.DB.Dashboard_Form
{
    partial class AdminDashboard
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label1 = new Label();
            button7 = new Button();
            button8 = new Button();
            colorDialog1 = new ColorDialog();
            button9 = new Button();
            button10 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(171, 104);
            button1.Name = "button1";
            button1.Size = new Size(181, 23);
            button1.TabIndex = 0;
            button1.Text = "Manage_Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(451, 104);
            button2.Name = "button2";
            button2.Size = new Size(194, 23);
            button2.TabIndex = 1;
            button2.Text = "Manage_Staff";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(171, 170);
            button3.Name = "button3";
            button3.Size = new Size(181, 23);
            button3.TabIndex = 2;
            button3.Text = "Manage_Lecturer";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(451, 170);
            button4.Name = "button4";
            button4.Size = new Size(194, 23);
            button4.TabIndex = 3;
            button4.Text = "Manage_Course";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(171, 248);
            button5.Name = "button5";
            button5.Size = new Size(181, 23);
            button5.TabIndex = 4;
            button5.Text = "Manage_Exam_Mark";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(451, 248);
            button6.Name = "button6";
            button6.Size = new Size(194, 23);
            button6.TabIndex = 5;
            button6.Text = "Manage_Time_Table";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(69, 402);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 6;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(638, 402);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 41);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 8;
            label1.Text = "Admin Use Form";
            // 
            // button7
            // 
            button7.Location = new Point(171, 316);
            button7.Name = "button7";
            button7.Size = new Size(181, 23);
            button7.TabIndex = 9;
            button7.Text = "Manage_Subject";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(451, 316);
            button8.Name = "button8";
            button8.Size = new Size(194, 23);
            button8.TabIndex = 10;
            button8.Text = "Manage_Addmin";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(451, 375);
            button9.Name = "button9";
            button9.Size = new Size(194, 23);
            button9.TabIndex = 11;
            button9.Text = "Manage_Room";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(171, 375);
            button10.Name = "button10";
            button10.Size = new Size(181, 23);
            button10.TabIndex = 12;
            button10.Text = "Manage_Exam";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 481);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(label1);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            Load += AdminDashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label1;
        private Button button7;
        private Button button8;
        private ColorDialog colorDialog1;
        private Button button9;
        private Button button10;
    }
}