namespace Unicom.DB.AddForms
{
    partial class RoomForm
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
            dgvRoomName = new DataGridView();
            label1 = new Label();
            txtRoomName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRoomName).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(71, 380);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(206, 380);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(352, 380);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack_Page
            // 
            btnBack_Page.Location = new Point(509, 380);
            btnBack_Page.Name = "btnBack_Page";
            btnBack_Page.Size = new Size(75, 23);
            btnBack_Page.TabIndex = 3;
            btnBack_Page.Text = "Back_Page";
            btnBack_Page.UseVisualStyleBackColor = true;
            btnBack_Page.Click += btnBack_Page_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(646, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvRoomName
            // 
            dgvRoomName.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomName.Location = new Point(235, 202);
            dgvRoomName.Name = "dgvRoomName";
            dgvRoomName.Size = new Size(240, 150);
            dgvRoomName.TabIndex = 5;
            dgvRoomName.SelectionChanged += dgvRoomName_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(210, 136);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 6;
            label1.Text = "RoomName";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(317, 132);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(158, 23);
            txtRoomName.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 32);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 8;
            label2.Text = "Room Add Form";
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtRoomName);
            Controls.Add(label1);
            Controls.Add(dgvRoomName);
            Controls.Add(btnCancel);
            Controls.Add(btnBack_Page);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "RoomForm";
            Text = "RoomForm";
            ((System.ComponentModel.ISupportInitialize)dgvRoomName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack_Page;
        private Button btnCancel;
        private DataGridView dgvRoomName;
        private Label label1;
        private TextBox txtRoomName;
        private Label label2;
    }
}