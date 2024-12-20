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
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(447, 9);
            label1.Name = "label1";
            label1.Size = new Size(102, 33);
            label1.TabIndex = 0;
            label1.Text = "Admin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
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
            btnAssignComplaint.BackColor = Color.DarkCyan;
            btnAssignComplaint.FlatStyle = FlatStyle.Flat;
            btnAssignComplaint.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnAssignComplaint.ForeColor = Color.White;
            btnAssignComplaint.Location = new Point(4, 254);
            btnAssignComplaint.Name = "btnAssignComplaint";
            btnAssignComplaint.Size = new Size(150, 45);
            btnAssignComplaint.TabIndex = 5;
            btnAssignComplaint.Text = "Assign Complaints";
            btnAssignComplaint.UseVisualStyleBackColor = false;
            btnAssignComplaint.Click += btnAssignComplaint_Click;
            btnAssignComplaint.MouseEnter += btnViewComplaints_MouseEnter;
            // 
            // btnManageOfficer
            // 
            btnManageOfficer.BackColor = Color.DarkCyan;
            btnManageOfficer.FlatStyle = FlatStyle.Flat;
            btnManageOfficer.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnManageOfficer.ForeColor = Color.White;
            btnManageOfficer.Location = new Point(4, 208);
            btnManageOfficer.Name = "btnManageOfficer";
            btnManageOfficer.Size = new Size(150, 40);
            btnManageOfficer.TabIndex = 4;
            btnManageOfficer.Text = "Manage Officer";
            btnManageOfficer.UseVisualStyleBackColor = false;
            btnManageOfficer.Click += btnManageOfficer_Click;
            btnManageOfficer.MouseEnter += btnViewComplaints_MouseEnter;
            // 
            // btnRegisterPoliceOfficer
            // 
            btnRegisterPoliceOfficer.BackColor = Color.DarkCyan;
            btnRegisterPoliceOfficer.FlatStyle = FlatStyle.Flat;
            btnRegisterPoliceOfficer.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnRegisterPoliceOfficer.ForeColor = Color.White;
            btnRegisterPoliceOfficer.Location = new Point(4, 163);
            btnRegisterPoliceOfficer.Name = "btnRegisterPoliceOfficer";
            btnRegisterPoliceOfficer.Size = new Size(150, 39);
            btnRegisterPoliceOfficer.TabIndex = 3;
            btnRegisterPoliceOfficer.Text = "Register Officer";
            btnRegisterPoliceOfficer.UseVisualStyleBackColor = false;
            btnRegisterPoliceOfficer.Click += btnRegisterPoliceOfficer_Click;
            btnRegisterPoliceOfficer.MouseEnter += btnViewComplaints_MouseEnter;
            // 
            // btnViewComplaints
            // 
            btnViewComplaints.BackColor = Color.DarkCyan;
            btnViewComplaints.FlatStyle = FlatStyle.Flat;
            btnViewComplaints.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnViewComplaints.ForeColor = Color.White;
            btnViewComplaints.Location = new Point(4, 69);
            btnViewComplaints.Name = "btnViewComplaints";
            btnViewComplaints.Size = new Size(148, 42);
            btnViewComplaints.TabIndex = 2;
            btnViewComplaints.Text = "View Complaints";
            btnViewComplaints.UseVisualStyleBackColor = false;
            btnViewComplaints.Click += btnViewComplaints_Click;
            btnViewComplaints.MouseEnter += btnViewComplaints_MouseEnter;
            btnViewComplaints.MouseLeave += btnViewComplaints_MouseLeave;
            // 
            // btnGenerateReports
            // 
            btnGenerateReports.BackColor = Color.DarkCyan;
            btnGenerateReports.FlatStyle = FlatStyle.Flat;
            btnGenerateReports.Font = new Font("Arial", 9F, FontStyle.Bold);
            btnGenerateReports.ForeColor = Color.White;
            btnGenerateReports.Location = new Point(3, 117);
            btnGenerateReports.Name = "btnGenerateReports";
            btnGenerateReports.Size = new Size(151, 40);
            btnGenerateReports.TabIndex = 1;
            btnGenerateReports.Text = "Generate Reports";
            btnGenerateReports.UseVisualStyleBackColor = false;
            btnGenerateReports.Click += btnGenerateReports_Click;
            btnGenerateReports.MouseEnter += btnViewComplaints_MouseEnter;
            btnGenerateReports.MouseLeave += btnGenerateReports_MouseLeave;
            // 
            // btnManageUsers
            // 
            btnManageUsers.BackColor = Color.DarkCyan;
            btnManageUsers.FlatStyle = FlatStyle.Flat;
            btnManageUsers.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUsers.ForeColor = Color.White;
            btnManageUsers.Location = new Point(3, 22);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Padding = new Padding(2);
            btnManageUsers.Size = new Size(149, 41);
            btnManageUsers.TabIndex = 0;
            btnManageUsers.Text = "Manage Users";
            btnManageUsers.UseVisualStyleBackColor = false;
            btnManageUsers.Click += btnManageUsers_Click;
            btnManageUsers.MouseEnter += btnManageUsers_MouseEnter;
            btnManageUsers.MouseLeave += btnManageUsers_MouseLeave;
            // 
            // panel2
            // 
            panel2.Location = new Point(175, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(849, 571);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1041, 56);
            panel3.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Police_Complaint_Management_Logo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1041, 635);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel3;
        private PictureBox pictureBox1;
    }
}