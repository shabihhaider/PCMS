namespace LatestCMS
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
            label1 = new Label();
            panel1 = new Panel();
            btnAssignComplaint = new Button();
            btnManageOfficer = new Button();
            btnRegisterPoliceOfficer = new Button();
            btnViewComplaints = new Button();
            btnGenerateReports = new Button();
            btnManageUsers = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Complaint Management";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAssignComplaint);
            panel1.Controls.Add(btnManageOfficer);
            panel1.Controls.Add(btnRegisterPoliceOfficer);
            panel1.Controls.Add(btnViewComplaints);
            panel1.Controls.Add(btnGenerateReports);
            panel1.Controls.Add(btnManageUsers);
            panel1.Location = new Point(12, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 302);
            panel1.TabIndex = 1;
            // 
            // btnAssignComplaint
            // 
            btnAssignComplaint.Location = new Point(11, 254);
            btnAssignComplaint.Name = "btnAssignComplaint";
            btnAssignComplaint.Size = new Size(139, 29);
            btnAssignComplaint.TabIndex = 5;
            btnAssignComplaint.Text = "Assign Complaints";
            btnAssignComplaint.UseVisualStyleBackColor = true;
            btnAssignComplaint.Click += btnAssignComplaint_Click;
            // 
            // btnManageOfficer
            // 
            btnManageOfficer.Location = new Point(11, 208);
            btnManageOfficer.Name = "btnManageOfficer";
            btnManageOfficer.Size = new Size(139, 29);
            btnManageOfficer.TabIndex = 4;
            btnManageOfficer.Text = "Manage Officer";
            btnManageOfficer.UseVisualStyleBackColor = true;
            btnManageOfficer.Click += btnManageOfficer_Click;
            // 
            // btnRegisterPoliceOfficer
            // 
            btnRegisterPoliceOfficer.Location = new Point(11, 163);
            btnRegisterPoliceOfficer.Name = "btnRegisterPoliceOfficer";
            btnRegisterPoliceOfficer.Size = new Size(139, 29);
            btnRegisterPoliceOfficer.TabIndex = 3;
            btnRegisterPoliceOfficer.Text = "Register Officer";
            btnRegisterPoliceOfficer.UseVisualStyleBackColor = true;
            btnRegisterPoliceOfficer.Click += btnRegisterPoliceOfficer_Click;
            // 
            // btnViewComplaints
            // 
            btnViewComplaints.Location = new Point(8, 69);
            btnViewComplaints.Name = "btnViewComplaints";
            btnViewComplaints.Size = new Size(141, 29);
            btnViewComplaints.TabIndex = 2;
            btnViewComplaints.Text = "View Complaints";
            btnViewComplaints.UseVisualStyleBackColor = true;
            btnViewComplaints.Click += btnViewComplaints_Click;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.Location = new Point(11, 117);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(139, 29);
            btnGenerateReports.TabIndex = 1;
            btnGenerateReports.Text = "Generate Reports";
            btnGenerateReports.UseVisualStyleBackColor = true;
            btnGenerateReports.Click += btnGenerateReports_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(19, 18);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(117, 29);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(175, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 592);
            panel2.TabIndex = 2;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 625);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnViewComplaints;
        private Button btnGenerateReports;
        private Button btnManageUsers;
        private Panel panel2;
        private Button btnRegisterPoliceOfficer;
        private Button btnManageOfficer;
        private Button btnAssignComplaint;
    }
}