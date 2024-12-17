namespace LatestCMS
{
    partial class CitizenDashboard
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
            panel2 = new Panel();
            btnViewComplaints = new Button();
            btnTrackComplaint = new Button();
            btnFileComplaint = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 9);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 52;
            label1.Text = "Citizen";
            // 
            // panel1
            // 
            panel1.Location = new Point(164, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 501);
            panel1.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewComplaints);
            panel2.Controls.Add(btnTrackComplaint);
            panel2.Controls.Add(btnFileComplaint);
            panel2.Location = new Point(1, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 166);
            panel2.TabIndex = 54;
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
            // btnTrackComplaint
            // 
            btnTrackComplaint.Location = new Point(11, 117);
            btnTrackComplaint.Name = "btnTrackComplaint";
            btnTrackComplaint.Size = new Size(139, 29);
            btnTrackComplaint.TabIndex = 1;
            btnTrackComplaint.Text = "Track Complaint";
            btnTrackComplaint.UseVisualStyleBackColor = true;
            btnTrackComplaint.Click += btnTrackComplaint_Click;
            // 
            // btnFileComplaint
            // 
            btnFileComplaint.Location = new Point(19, 18);
            btnFileComplaint.Name = "btnFileComplaint";
            btnFileComplaint.Size = new Size(117, 29);
            btnFileComplaint.TabIndex = 0;
            btnFileComplaint.Text = "File Complaint";
            btnFileComplaint.UseVisualStyleBackColor = true;
            btnFileComplaint.Click += btnFileComplaint_Click;
            // 
            // CitizenDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "CitizenDashboard";
            Text = "CitizenDashboard";
            Load += CitizenDashboard_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button btnViewComplaints;
        private Button btnTrackComplaint;
        private Button btnFileComplaint;
    }
}