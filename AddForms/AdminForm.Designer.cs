namespace Unicom.DB
{
    partial class AdminForm
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
            dgvAdmin = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtPassword = new TextBox();
            btnBack_Page = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label4 = new Label();
            cmbRole = new ComboBox();
            cmbAddress = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(660, 76);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(660, 135);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(660, 195);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvAdmin
            // 
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Location = new Point(12, 209);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.Size = new Size(642, 229);
            dgvAdmin.TabIndex = 3;
            dgvAdmin.CellContentClick += dgvAdmin_CellContentClick;
            dgvAdmin.SelectionChanged += dgvAdmin_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 84);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 135);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 5;
            label2.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(342, 84);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(316, 30);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 8;
            label5.Text = "Admin Add Form";
            // 
            // txtName
            // 
            txtName.Location = new Point(133, 81);
            txtName.Name = "txtName";
            txtName.Size = new Size(189, 23);
            txtName.TabIndex = 9;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(133, 127);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(405, 76);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(196, 23);
            txtPassword.TabIndex = 11;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(660, 257);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 13;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(660, 316);
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
            label6.Location = new Point(342, 135);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 15;
            label6.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 181);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 19;
            label4.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(133, 178);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(189, 23);
            cmbRole.TabIndex = 20;
            // 
            // cmbAddress
            // 
            cmbAddress.FormattingEnabled = true;
            cmbAddress.Location = new Point(405, 132);
            cmbAddress.Name = "cmbAddress";
            cmbAddress.Size = new Size(196, 23);
            cmbAddress.TabIndex = 21;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAddress);
            Controls.Add(cmbRole);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(txtPassword);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvAdmin);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtPassword;
        private Button btnBack_Page;
        private Button btnCancel;
        private Label label6;
        private Label label4;
        private ComboBox cmbRole;
        private ComboBox cmbAddress;
    }
}