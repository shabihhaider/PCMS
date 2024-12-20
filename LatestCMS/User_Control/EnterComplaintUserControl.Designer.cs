namespace LatestCMS.User_Control
{
    partial class EnterComplaintUserControl
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
            dtpIncidentDate = new DateTimePicker();
            cboComplaintType = new ComboBox();
            lblContactName = new Label();
            lblDescription = new Label();
            lblComplaintType = new Label();
            lblIncidentDate = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtPhone = new TextBox();
            lblPhone = new Label();
            btnRefresh = new Button();
            btnSubmit = new Button();
            txtContactName = new TextBox();
            txtDescription = new TextBox();
            txtComplaintTitle = new TextBox();
            lblComplaintTitle = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // dtpIncidentDate
            // 
            dtpIncidentDate.Font = new Font("Segoe UI", 10.2F);
            dtpIncidentDate.Location = new Point(244, 376);
            dtpIncidentDate.Name = "dtpIncidentDate";
            dtpIncidentDate.Size = new Size(278, 30);
            dtpIncidentDate.TabIndex = 96;
            // 
            // cboComplaintType
            // 
            cboComplaintType.Font = new Font("Segoe UI", 10.2F);
            cboComplaintType.FormattingEnabled = true;
            cboComplaintType.Items.AddRange(new object[] { "Theft", "Harassment", "Property Dispute", "Missing Person" });
            cboComplaintType.Location = new Point(244, 134);
            cboComplaintType.Name = "cboComplaintType";
            cboComplaintType.Size = new Size(151, 31);
            cboComplaintType.TabIndex = 95;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblContactName.Location = new Point(109, 232);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(121, 23);
            lblContactName.TabIndex = 94;
            lblContactName.Text = "Contact Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDescription.Location = new Point(109, 182);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 93;
            lblDescription.Text = "Description";
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintType.Location = new Point(109, 137);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(130, 23);
            lblComplaintType.TabIndex = 92;
            lblComplaintType.Text = "Complaint Type";
            // 
            // lblIncidentDate
            // 
            lblIncidentDate.AutoSize = true;
            lblIncidentDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblIncidentDate.Location = new Point(109, 376);
            lblIncidentDate.Name = "lblIncidentDate";
            lblIncidentDate.Size = new Size(113, 23);
            lblIncidentDate.TabIndex = 87;
            lblIncidentDate.Text = "Incident Date";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 10.2F);
            txtEmail.Location = new Point(244, 328);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 30);
            txtEmail.TabIndex = 86;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblEmail.Location = new Point(109, 328);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 23);
            lblEmail.TabIndex = 85;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 10.2F);
            txtPhone.Location = new Point(244, 278);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 30);
            txtPhone.TabIndex = 84;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblPhone.Location = new Point(109, 278);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(59, 23);
            lblPhone.TabIndex = 83;
            lblPhone.Text = "Phone";
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(333, 443);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 29);
            btnRefresh.TabIndex = 81;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            btnRefresh.MouseEnter += btnSubmit_MouseEnter;
            btnRefresh.MouseLeave += btnSubmit_MouseLeave;
            // 
            // btnSubmit
            // 
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSubmit.Location = new Point(186, 443);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 29);
            btnSubmit.TabIndex = 80;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseEnter += btnSubmit_MouseEnter;
            btnSubmit.MouseLeave += btnSubmit_MouseLeave;
            // 
            // txtContactName
            // 
            txtContactName.Font = new Font("Segoe UI", 10.2F);
            txtContactName.Location = new Point(244, 232);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(278, 30);
            txtContactName.TabIndex = 79;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F);
            txtDescription.Location = new Point(244, 182);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 30);
            txtDescription.TabIndex = 78;
            // 
            // txtComplaintTitle
            // 
            txtComplaintTitle.Font = new Font("Segoe UI", 10.2F);
            txtComplaintTitle.Location = new Point(244, 84);
            txtComplaintTitle.Name = "txtComplaintTitle";
            txtComplaintTitle.Size = new Size(278, 30);
            txtComplaintTitle.TabIndex = 77;
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintTitle.Location = new Point(109, 84);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(126, 23);
            lblComplaintTitle.TabIndex = 76;
            lblComplaintTitle.Text = "Complaint Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkCyan;
            label1.Location = new Point(208, 19);
            label1.Name = "label1";
            label1.Size = new Size(162, 24);
            label1.TabIndex = 97;
            label1.Text = "Enter Complaint";
            // 
            // EnterComplaintUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(dtpIncidentDate);
            Controls.Add(cboComplaintType);
            Controls.Add(lblContactName);
            Controls.Add(lblDescription);
            Controls.Add(lblComplaintType);
            Controls.Add(lblIncidentDate);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(btnRefresh);
            Controls.Add(btnSubmit);
            Controls.Add(txtContactName);
            Controls.Add(txtDescription);
            Controls.Add(txtComplaintTitle);
            Controls.Add(lblComplaintTitle);
            Name = "EnterComplaintUserControl";
            Size = new Size(610, 505);
            Load += EnterComplaintUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpIncidentDate;
        private ComboBox cboComplaintType;
        private Label lblContactName;
        private Label lblDescription;
        private Label lblComplaintType;
        private Label lblIncidentDate;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtPhone;
        private Label lblPhone;
        private Button btnRefresh;
        private Button btnSubmit;
        private TextBox txtContactName;
        private TextBox txtDescription;
        private TextBox txtComplaintTitle;
        private Label lblComplaintTitle;
        private Label label1;
    }
}
