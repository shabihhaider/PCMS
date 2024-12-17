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
            label1 = new Label();
            cboComplaints = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cboOfficers = new ComboBox();
            btnAssign = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 30);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 0;
            label1.Text = "Assign Complaints";
            // 
            // cboComplaints
            // 
            cboComplaints.FormattingEnabled = true;
            cboComplaints.Location = new Point(260, 96);
            cboComplaints.Name = "cboComplaints";
            cboComplaints.Size = new Size(218, 28);
            cboComplaints.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 98);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 2;
            label2.Text = "Complaint List";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 155);
            label3.Name = "label3";
            label3.Size = new Size(123, 20);
            label3.TabIndex = 4;
            label3.Text = "Police Officer List";
            // 
            // cboOfficers
            // 
            cboOfficers.FormattingEnabled = true;
            cboOfficers.Location = new Point(260, 153);
            cboOfficers.Name = "cboOfficers";
            cboOfficers.Size = new Size(218, 28);
            cboOfficers.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Location = new Point(219, 214);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(94, 29);
            btnAssign.TabIndex = 5;
            btnAssign.Text = "Assign";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += btnAssign_Click;
            // 
            // AssignComplaintUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAssign);
            Controls.Add(label3);
            Controls.Add(cboOfficers);
            Controls.Add(label2);
            Controls.Add(cboComplaints);
            Controls.Add(label1);
            Name = "AssignComplaintUserControl";
            Size = new Size(592, 303);
            Load += AssignComplaintUserControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboComplaints;
        private Label label2;
        private Label label3;
        private ComboBox cboOfficers;
        private Button btnAssign;
    }
}
