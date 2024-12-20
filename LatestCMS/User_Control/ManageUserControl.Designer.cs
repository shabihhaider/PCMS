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
            btnUpdateUser.FlatStyle = FlatStyle.Flat;
            btnUpdateUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateUser.Location = new Point(314, 540);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(113, 29);
            btnUpdateUser.TabIndex = 33;
            btnUpdateUser.Text = "Update User";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            btnUpdateUser.MouseEnter += btnClear_MouseEnter;
            btnUpdateUser.MouseLeave += btnClear_MouseLeave;
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Segoe UI", 10F);
            txtContactName.Location = new Point(149, 230);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(278, 30);
            txtContactName.TabIndex = 23;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10F);
            txtDescription.Location = new Point(149, 180);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 30);
            txtDescription.TabIndex = 21;
            // 
            // txtComplaintTitle
            // 
            txtComplaintTitle.Font = new Font("Segoe UI", 10F);
            txtComplaintTitle.Location = new Point(149, 82);
            txtComplaintTitle.Name = "txtComplaintTitle";
            txtComplaintTitle.Size = new Size(278, 30);
            txtComplaintTitle.TabIndex = 19;
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintTitle.Location = new Point(14, 82);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(126, 23);
            lblComplaintTitle.TabIndex = 18;
            lblComplaintTitle.Text = "Complaint Title";
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClear.Location = new Point(451, 540);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(97, 29);
            btnClear.TabIndex = 35;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnRefresh_Click;
            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(281, 18);
            label1.Name = "label1";
            label1.Size = new Size(232, 24);
            label1.TabIndex = 0;
            label1.Text = "Complaint Management";
            // 
            // lblIncidentDate
            // 
            lblIncidentDate.AutoSize = true;
            lblIncidentDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblIncidentDate.Location = new Point(14, 374);
            lblIncidentDate.Name = "lblIncidentDate";
            lblIncidentDate.Size = new Size(113, 23);
            lblIncidentDate.TabIndex = 43;
            lblIncidentDate.Text = "Incident Date";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(149, 326);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 30);
            txtEmail.TabIndex = 42;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(14, 326);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 41;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(149, 276);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 30);
            txtPhone.TabIndex = 38;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPhone.Location = new Point(14, 276);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 37;
            lblPhone.Text = "Phone";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblStatus.Location = new Point(14, 423);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 23);
            lblStatus.TabIndex = 45;
            lblStatus.Text = "Current Status";
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Resolved" });
            cboStatus.Location = new Point(149, 420);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(278, 31);
            cboStatus.TabIndex = 48;
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintType.Location = new Point(14, 135);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(130, 23);
            lblComplaintType.TabIndex = 49;
            lblComplaintType.Text = "Complaint Type";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDescription.Location = new Point(14, 180);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 50;
            lblDescription.Text = "Description";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblContactName.Location = new Point(14, 230);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(121, 23);
            lblContactName.TabIndex = 51;
            lblContactName.Text = "Contact Name";
            // 
            // dtpIncidentDate
            // 
            dtpIncidentDate.Font = new Font("Segoe UI", 10F);
            dtpIncidentDate.Location = new Point(149, 376);
            dtpIncidentDate.Name = "dtpIncidentDate";
            dtpIncidentDate.Size = new Size(278, 30);
            dtpIncidentDate.TabIndex = 77;
            // 
            // cboComplaintType
            // 
            cboComplaintType.Font = new Font("Segoe UI", 10F);
            cboComplaintType.FormattingEnabled = true;
            cboComplaintType.Items.AddRange(new object[] { "Theft", "Harassment", "Property Dispute", "Missing Person" });
            cboComplaintType.Location = new Point(149, 135);
            cboComplaintType.Name = "cboComplaintType";
            cboComplaintType.Size = new Size(278, 31);
            cboComplaintType.TabIndex = 76;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 10F);
            dateTimePicker2.Location = new Point(149, 470);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(278, 30);
            dateTimePicker2.TabIndex = 79;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(14, 470);
            label2.Name = "label2";
            label2.Size = new Size(87, 23);
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
            BackColor = Color.White;
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
