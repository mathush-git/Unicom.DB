namespace Unicom.DB.AddForms
{
    partial class Time_Table
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack_Page = new Button();
            btnCancel = new Button();
            dgvTime_Table = new DataGridView();
            txtRoomName = new TextBox();
            cmbSubject_Id = new ComboBox();
            label5 = new Label();
            txtSubject = new TextBox();
            label6 = new Label();
            cmbRoomId = new ComboBox();
            cmbTime_Slot = new ComboBox();
            btnBack_PageL = new Button();
            btnBack_PageS = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTime_Table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 77);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject_Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 165);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Room_Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(366, 77);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Time_Slot";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(340, 15);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 3;
            label4.Text = "Time_Table";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(593, 132);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(657, 178);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(713, 218);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(625, 252);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(97, 23);
            btnBack_Page.TabIndex = 7;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(625, 415);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(97, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvTime_Table
            // 
            dgvTime_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTime_Table.Location = new Point(26, 252);
            dgvTime_Table.Name = "dgvTime_Table";
            dgvTime_Table.Size = new Size(570, 186);
            dgvTime_Table.TabIndex = 9;
            dgvTime_Table.CellContentClick += dgvTime_Table_CellContentClick;
            dgvTime_Table.SelectionChanged += dgvTime_Table_SelectionChanged;
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(135, 200);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(183, 23);
            txtRoomName.TabIndex = 14;
            // 
            // cmbSubject_Id
            // 
            cmbSubject_Id.FormattingEnabled = true;
            cmbSubject_Id.Location = new Point(135, 74);
            cmbSubject_Id.Name = "cmbSubject_Id";
            cmbSubject_Id.Size = new Size(183, 23);
            cmbSubject_Id.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 123);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 16;
            label5.Text = "Subject";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(134, 115);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(184, 23);
            txtSubject.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 203);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 18;
            label6.Text = "Room_Name";
            // 
            // cmbRoomId
            // 
            cmbRoomId.FormattingEnabled = true;
            cmbRoomId.Location = new Point(134, 162);
            cmbRoomId.Name = "cmbRoomId";
            cmbRoomId.Size = new Size(184, 23);
            cmbRoomId.TabIndex = 19;
            // 
            // cmbTime_Slot
            // 
            cmbTime_Slot.FormattingEnabled = true;
            cmbTime_Slot.Location = new Point(462, 74);
            cmbTime_Slot.Name = "cmbTime_Slot";
            cmbTime_Slot.Size = new Size(170, 23);
            cmbTime_Slot.TabIndex = 20;
            // 
            // btnBack_PageL
            // 
            btnBack_PageL.Location = new Point(625, 306);
            btnBack_PageL.Name = "btnBack_PageL";
            btnBack_PageL.Size = new Size(97, 23);
            btnBack_PageL.TabIndex = 21;
            btnBack_PageL.Text = "Back_page(L)";
            btnBack_PageL.UseVisualStyleBackColor = true;
            btnBack_PageL.Click += btnBack_PageL_Click;
            // 
            // btnBack_PageS
            // 
            btnBack_PageS.Location = new Point(625, 363);
            btnBack_PageS.Name = "btnBack_PageS";
            btnBack_PageS.Size = new Size(97, 23);
            btnBack_PageS.TabIndex = 22;
            btnBack_PageS.Text = "Back_Page(S)";
            btnBack_PageS.UseVisualStyleBackColor = true;
            btnBack_PageS.Click += btnBack_PageS_Click;
            // 
            // Time_Table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack_PageS);
            Controls.Add(btnBack_PageL);
            Controls.Add(cmbTime_Slot);
            Controls.Add(cmbRoomId);
            Controls.Add(label6);
            Controls.Add(txtSubject);
            Controls.Add(label5);
            Controls.Add(cmbSubject_Id);
            Controls.Add(txtRoomName);
            Controls.Add(dgvTime_Table);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Time_Table";
            Text = "Time_TableForm";
            Load += txtSubject_id_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTime_Table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack_Page;
        private Button btnCancel;
        private DataGridView dgvTime_Table;
        private TextBox txtTimeSlot;
        private TextBox txtRoomName;
        private ComboBox cmbSubject_Id;
        private Label label5;
        private TextBox txtSubject;
        private Label label6;
        private ComboBox cmbRoomId;
        private ComboBox cmbTime_Slot;
        private Button btnBack_PageL;
        private Button btnBack_PageS;
    }
}