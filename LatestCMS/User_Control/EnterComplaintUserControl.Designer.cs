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
            SuspendLayout();
            // 
            // dtpIncidentDate
            // 
            dtpIncidentDate.Location = new Point(181, 306);
            dtpIncidentDate.Name = "dtpIncidentDate";
            dtpIncidentDate.Size = new Size(250, 27);
            dtpIncidentDate.TabIndex = 96;
            // 
            // cboComplaintType
            // 
            cboComplaintType.FormattingEnabled = true;
            cboComplaintType.Items.AddRange(new object[] { "Theft", "Harassment", "Property Dispute", "Missing Person" });
            cboComplaintType.Location = new Point(181, 64);
            cboComplaintType.Name = "cboComplaintType";
            cboComplaintType.Size = new Size(151, 28);
            cboComplaintType.TabIndex = 95;
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(46, 162);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(104, 20);
            lblContactName.TabIndex = 94;
            lblContactName.Text = "Contact Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(46, 112);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 93;
            lblDescription.Text = "Description";
            // 
            // lblComplaintType
            // 
            lblComplaintType.AutoSize = true;
            lblComplaintType.Location = new Point(46, 67);
            lblComplaintType.Name = "lblComplaintType";
            lblComplaintType.Size = new Size(113, 20);
            lblComplaintType.TabIndex = 92;
            lblComplaintType.Text = "Complaint Type";
            // 
            // lblIncidentDate
            // 
            lblIncidentDate.AutoSize = true;
            lblIncidentDate.Location = new Point(46, 306);
            lblIncidentDate.Name = "lblIncidentDate";
            lblIncidentDate.Size = new Size(98, 20);
            lblIncidentDate.TabIndex = 87;
            lblIncidentDate.Text = "Incident Date";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(181, 258);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 86;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(46, 258);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 85;
            lblEmail.Text = "Email";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(181, 208);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 84;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(46, 208);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 83;
            lblPhone.Text = "Phone";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(235, 366);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 29);
            btnRefresh.TabIndex = 81;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(88, 366);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(113, 29);
            btnSubmit.TabIndex = 80;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(181, 162);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(278, 27);
            txtContactName.TabIndex = 79;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(181, 112);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 27);
            txtDescription.TabIndex = 78;
            // 
            // txtComplaintTitle
            // 
            txtComplaintTitle.Location = new Point(181, 14);
            txtComplaintTitle.Name = "txtComplaintTitle";
            txtComplaintTitle.Size = new Size(278, 27);
            txtComplaintTitle.TabIndex = 77;
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Location = new Point(46, 14);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(111, 20);
            lblComplaintTitle.TabIndex = 76;
            lblComplaintTitle.Text = "Complaint Title";
            // 
            // EnterComplaintUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
            Size = new Size(485, 424);
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
    }
}
