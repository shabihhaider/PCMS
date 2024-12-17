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
            label1 = new Label();
            dgvAssignedComplaints = new DataGridView();
            btnUpdateStatus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAssignedComplaints).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Officer Dashboard";
            // 
            // dgvAssignedComplaints
            // 
            dgvAssignedComplaints.ColumnHeadersHeight = 29;
            dgvAssignedComplaints.Location = new Point(28, 71);
            dgvAssignedComplaints.Name = "dgvAssignedComplaints";
            dgvAssignedComplaints.RowHeadersWidth = 51;
            dgvAssignedComplaints.Size = new Size(747, 193);
            dgvAssignedComplaints.TabIndex = 0;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(331, 297);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(94, 29);
            btnUpdateStatus.TabIndex = 1;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // PoliceOfficerDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdateStatus);
            Controls.Add(dgvAssignedComplaints);
            Controls.Add(label1);
            Name = "PoliceOfficerDashboard";
            Text = "PoliceDashboard";
            ((System.ComponentModel.ISupportInitialize)dgvAssignedComplaints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvAssignedComplaints;
        private Button btnUpdateStatus;
    }
}