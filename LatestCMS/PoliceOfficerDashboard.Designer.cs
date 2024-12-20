namespace LatestCMS
{
    partial class PoliceOfficerDashboard
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
            dgvAssignedComplaints = new DataGridView();
            btnUpdateStatus = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            lblDescription = new Label();
            txtOfficerName = new TextBox();
            label2 = new Label();
            txtDescription = new TextBox();
            txtComplaintTitle = new TextBox();
            lblComplaintTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedComplaints).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAssignedComplaints
            // 
            dgvAssignedComplaints.ColumnHeadersHeight = 29;
            dgvAssignedComplaints.Location = new Point(96, 305);
            dgvAssignedComplaints.Name = "dgvAssignedComplaints";
            dgvAssignedComplaints.RowHeadersWidth = 51;
            dgvAssignedComplaints.Size = new Size(654, 181);
            dgvAssignedComplaints.TabIndex = 0;
            dgvAssignedComplaints.CellClick += dgvAssignedComplaints_CellClick;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.FlatStyle = FlatStyle.Flat;
            btnUpdateStatus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateStatus.Location = new Point(386, 511);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnUpdateStatus.MouseEnter += btnUpdateStatus_MouseEnter;
            btnUpdateStatus.MouseLeave += btnUpdateStatus_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(876, 65);
            panel3.TabIndex = 56;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Police_Complaint_Management_Logo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(81, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(299, 19);
            label1.Name = "label1";
            label1.Size = new Size(259, 33);
            label1.TabIndex = 0;
            label1.Text = "Officer Dashboard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(txtOfficerName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(txtComplaintTitle);
            panel1.Controls.Add(lblComplaintTitle);
            panel1.Location = new Point(96, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 174);
            panel1.TabIndex = 57;
            // 
            // cboStatus
            // 
            cboStatus.Font = new Font("Segoe UI", 10F);
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "Pending", "In Progress", "Resolved" });
            cboStatus.Location = new Point(268, 65);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(278, 31);
            cboStatus.TabIndex = 103;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblStatus.Location = new Point(121, 68);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 23);
            lblStatus.TabIndex = 102;
            lblStatus.Text = "Current Status";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblDescription.Location = new Point(121, 114);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(96, 23);
            lblDescription.TabIndex = 100;
            lblDescription.Text = "Description";
            // 
            // txtOfficerName
            // 
            txtOfficerName.Location = new Point(-171, -28);
            txtOfficerName.Name = "txtOfficerName";
            txtOfficerName.Size = new Size(274, 27);
            txtOfficerName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(-355, -25);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 2;
            label2.Text = "Officer Name";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 10.2F);
            txtDescription.Location = new Point(268, 114);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(278, 30);
            txtDescription.TabIndex = 98;
            // 
            // txtComplaintTitle
            // 
            txtComplaintTitle.Font = new Font("Segoe UI", 10.2F);
            txtComplaintTitle.Location = new Point(268, 19);
            txtComplaintTitle.Name = "txtComplaintTitle";
            txtComplaintTitle.Size = new Size(278, 30);
            txtComplaintTitle.TabIndex = 97;
            // 
            // lblComplaintTitle
            // 
            lblComplaintTitle.AutoSize = true;
            lblComplaintTitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblComplaintTitle.Location = new Point(121, 19);
            lblComplaintTitle.Name = "lblComplaintTitle";
            lblComplaintTitle.Size = new Size(126, 23);
            lblComplaintTitle.TabIndex = 96;
            lblComplaintTitle.Text = "Complaint Title";
            // 
            // PoliceOfficerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(876, 561);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvAssignedComplaints);
            Name = "PoliceOfficerDashboard";
            Text = "PoliceDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvAssignedComplaints).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvAssignedComplaints;
        private Button btnUpdateStatus;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private TextBox txtOfficerName;
        private Label label2;
        private Label lblDescription;
        private TextBox txtDescription;
        private TextBox txtComplaintTitle;
        private Label lblComplaintTitle;
        private ComboBox cboStatus;
        private Label lblStatus;
    }
}