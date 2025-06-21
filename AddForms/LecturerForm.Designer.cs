namespace Unicom.DB
{
    partial class LecturerForm
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
            dgvLecturers = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label6 = new Label();
            txtPassword = new TextBox();
            cmbRole = new ComboBox();
            cmbAddress = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvLecturers).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(566, 256);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(653, 305);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 366);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvLecturers
            // 
            dgvLecturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLecturers.Location = new Point(49, 256);
            dgvLecturers.Name = "dgvLecturers";
            dgvLecturers.Size = new Size(479, 169);
            dgvLecturers.TabIndex = 3;
            dgvLecturers.CellContentClick += dgvLecturers_CellContentClick;
            dgvLecturers.SelectionChanged += dgvLecturers_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 79);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 133);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Address";
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 71);
            txtName.Name = "txtName";
            txtName.Size = new Size(208, 23);
            txtName.TabIndex = 7;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(543, 71);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(212, 23);
            txtPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(297, 20);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 10;
            label4.Text = "Lecturer Add Form";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 191);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 11;
            label5.Text = "Role";
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(566, 340);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 13;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(566, 402);
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
            label6.Location = new Point(461, 133);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 16;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(543, 125);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(212, 23);
            txtPassword.TabIndex = 17;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(131, 183);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(208, 23);
            cmbRole.TabIndex = 19;
            // 
            // cmbAddress
            // 
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(132, 132);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(207, 23);
            cmbAddress.TabIndex = 20;
            // 
            // LecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAddress);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvLecturers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "LecturerForm";
            Text = "LecturerForm";
            Load += LecturerForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLecturers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvLecturers;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label6;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private ComboBox cmbAddress;
    }
}