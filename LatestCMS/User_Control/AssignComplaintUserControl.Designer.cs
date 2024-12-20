namespace LatestCMS.User_Control
{
    partial class AssignComplaintUserControl
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
            cboComplaints = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboOfficers = new ComboBox();
            btnAssign = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // cboComplaints
            // 
            cboComplaints.Font = new Font("Segoe UI", 12F);
            cboComplaints.FormattingEnabled = true;
            cboComplaints.Location = new Point(260, 96);
            cboComplaints.Name = "cboComplaints";
            cboComplaints.Size = new Size(218, 36);
            cboComplaints.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(93, 98);
            label2.Name = "label2";
            label2.Size = new Size(119, 23);
            label2.TabIndex = 2;
            label2.Text = "Complaint List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(93, 155);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 4;
            label3.Text = "Police Officer List";
            // 
            // cboOfficers
            // 
            cboOfficers.Font = new Font("Segoe UI", 12F);
            cboOfficers.FormattingEnabled = true;
            cboOfficers.Location = new Point(260, 153);
            cboOfficers.Name = "cboOfficers";
            cboOfficers.Size = new Size(218, 36);
            cboOfficers.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.FlatStyle = FlatStyle.Flat;
            btnAssign.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(226, 228);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 29);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            btnAssign.MouseEnter += btnAssign_MouseEnter;
            btnAssign.MouseLeave += btnAssign_MouseLeave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkCyan;
            label4.Location = new Point(191, 25);
            label4.Name = "label4";
            label4.Size = new Size(175, 24);
            label4.TabIndex = 6;
            label4.Text = "Assign Complaint";
            // 
            // AssignComplaintUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(btnAssign);
            Controls.Add(label3);
            Controls.Add(cboOfficers);
            Controls.Add(label2);
            Controls.Add(cboComplaints);
            Name = "AssignComplaintUserControl";
            Size = new Size(559, 303);
            Load += AssignComplaintUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cboComplaints;
        private Label label2;
        private Label label3;
        private ComboBox cboOfficers;
        private Button btnAssign;
        private Label label4;
    }
}
