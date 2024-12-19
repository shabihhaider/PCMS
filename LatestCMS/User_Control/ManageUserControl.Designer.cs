namespace LatestCMS.User_Control
{
    partial class ManageUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdateUser = new Button();
            txtContactName = new TextBox();
            txtDescription = new TextBox();
            txtComplaintTitle = new TextBox();
            lblComplaintTitle = new Label();
            btnClear = new Button();
            label1 = new Label();
            lblIncidentDate = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblComplaintType = new Label();
            lblDescription = new Label();
            lblContactName = new Label();
            dtpIncidentDate = new DateTimePicker();
            cboComplaintType = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dgvComplaints = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(183, 533);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(113, 29);
            btnUpdateUser.TabIndex = 33;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(149, 230);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(278, 27);
            txtContactName.TabIndex = 23;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(149, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 27);
            txtDescription.TabIndex = 21;
            // 
            // txtComplaintTitle
            // 
            txtComplaintTitle.Location = new Point(149, 82);
            txtComplaintTitle.Name = "txtComplaintTitle";
            txtComplaintTitle.Size = new Size(278, 27);
            txtComplaintTitle.TabIndex = 19;
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Location = new Point(14, 82);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(111, 20);
            lblComplaintTitle.TabIndex = 18;
            lblComplaintTitle.Text = "Complaint Title";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(330, 533);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 29);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 26);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Complaint Management";
            // 
            // lblIncidentDate
            // 
            lblIncidentDate.AutoSize = true;
            lblIncidentDate.Location = new Point(14, 374);
            lblIncidentDate.Name = "lblIncidentDate";
            lblIncidentDate.Size = new Size(98, 20);
            lblIncidentDate.TabIndex = 43;
            lblIncidentDate.Text = "Incident Date";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(14, 326);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(149, 276);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 38;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(14, 276);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 37;
            lblPhone.Text = "Phone";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(14, 423);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(101, 20);
            lblStatus.TabIndex = 45;
            lblStatus.Text = "Current Status";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Resolved" });
            cboStatus.Location = new Point(149, 420);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(151, 28);
            cboStatus.TabIndex = 48;
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Location = new Point(14, 135);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(113, 20);
            lblComplaintType.TabIndex = 49;
            lblComplaintType.Text = "Complaint Type";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(14, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 50;
            lblDescription.Text = "Description";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(14, 230);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(104, 20);
            lblContactName.TabIndex = 51;
            lblContactName.Text = "Contact Name";
            // 
            // dtpIncidentDate
            // 
            dtpIncidentDate.Location = new Point(149, 376);
            dtpIncidentDate.Name = "dtpIncidentDate";
            dtpIncidentDate.Size = new Size(250, 27);
            dtpIncidentDate.TabIndex = 77;
            // 
            // cboComplaintType
            // 
            cboComplaintType.FormattingEnabled = true;
            cboComplaintType.Items.AddRange(new object[] { "Theft", "Harassment", "Property Dispute", "Missing Person" });
            cboComplaintType.Location = new Point(149, 135);
            cboComplaintType.Name = "cboComplaintType";
            cboComplaintType.Size = new Size(151, 28);
            cboComplaintType.TabIndex = 76;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(149, 470);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 470);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 78;
            label2.Text = "Date Filed";
            // 
            // dgvComplaints
            // 
            dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComplaints.Location = new Point(451, 135);
            dgvComplaints.Name = "dgvComplaints";
            dgvComplaints.RowHeadersWidth = 51;
            dgvComplaints.Size = new Size(317, 271);
            dgvComplaints.TabIndex = 36;
            dgvComplaints.CellClick += dgvComplaints_CellClick;
            // 
            // ManageUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dtpIncidentDate);
            Controls.Add(cboComplaintType);
            Controls.Add(lblContactName);
            Controls.Add(lblDescription);
            Controls.Add(lblComplaintType);
            Controls.Add(cboStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblIncidentDate);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(dgvComplaints);
            Controls.Add(btnClear);
            Controls.Add(btnUpdateUser);
            Controls.Add(txtContactName);
            Controls.Add(txtDescription);
            Controls.Add(txtComplaintTitle);
            Controls.Add(lblComplaintTitle);
            Controls.Add(label1);
            Name = "ManageUserControl";
            Size = new Size(822, 596);
            Load += ManageUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDeleteUser;
        private Button btnUpdateUser;
        private Button btnAddUser;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtContactName;
        private TextBox txtDescription;
        private TextBox txtComplaintTitle;
        private Label lblComplaintTitle;
        private Button btnClear;
        private Label label1;
        private Label lblIncidentDate;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblComplaintType;
        private Label lblDescription;
        private Label lblContactName;
        private DateTimePicker dtpIncidentDate;
        private ComboBox cboComplaintType;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DataGridView dgvComplaints;
    }
}
