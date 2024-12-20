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
            panel1 = new Panel();
            panel2 = new Panel();
            btnViewComplaints = new Button();
            btnTrackComplaint = new Button();
            btnFileComplaint = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(172, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 493);
            panel1.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewComplaints);
            panel2.Controls.Add(btnTrackComplaint);
            panel2.Controls.Add(btnFileComplaint);
            panel2.Location = new Point(1, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(165, 166);
            panel2.TabIndex = 54;
            // 
            // btnViewComplaints
            // 
            btnViewComplaints.BackColor = Color.DarkCyan;
            btnViewComplaints.FlatStyle = FlatStyle.Flat;
            btnViewComplaints.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnViewComplaints.ForeColor = Color.White;
            btnViewComplaints.Location = new Point(2, 66);
            btnViewComplaints.Name = "btnViewComplaints";
            btnViewComplaints.Size = new Size(159, 32);
            btnViewComplaints.TabIndex = 2;
            btnViewComplaints.Text = "View Complaints";
            btnViewComplaints.UseVisualStyleBackColor = false;
            btnViewComplaints.Click += btnViewComplaints_Click;
            btnViewComplaints.MouseEnter += btnViewComplaints_MouseEnter;
            btnViewComplaints.MouseLeave += btnFileComplaint_MouseLeave;
            // 
            // btnTrackComplaint
            // 
            btnTrackComplaint.BackColor = Color.DarkCyan;
            btnTrackComplaint.FlatStyle = FlatStyle.Flat;
            btnTrackComplaint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTrackComplaint.ForeColor = Color.White;
            btnTrackComplaint.Location = new Point(5, 112);
            btnTrackComplaint.Name = "btnTrackComplaint";
            btnTrackComplaint.Size = new Size(157, 34);
            btnTrackComplaint.TabIndex = 1;
            btnTrackComplaint.Text = "Track Complaint";
            btnTrackComplaint.UseVisualStyleBackColor = false;
            btnTrackComplaint.Click += btnTrackComplaint_Click;
            btnTrackComplaint.MouseEnter += btnViewComplaints_MouseEnter;
            btnTrackComplaint.MouseLeave += btnFileComplaint_MouseLeave;
            // 
            // btnFileComplaint
            // 
            btnFileComplaint.BackColor = Color.DarkCyan;
            btnFileComplaint.FlatStyle = FlatStyle.Flat;
            btnFileComplaint.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnFileComplaint.ForeColor = Color.White;
            btnFileComplaint.Location = new Point(13, 18);
            btnFileComplaint.Name = "btnFileComplaint";
            btnFileComplaint.Size = new Size(135, 33);
            btnFileComplaint.TabIndex = 0;
            btnFileComplaint.Text = "File Complaint";
            btnFileComplaint.UseVisualStyleBackColor = false;
            btnFileComplaint.Click += btnFileComplaint_Click;
            btnFileComplaint.MouseEnter += btnViewComplaints_MouseEnter;
            btnFileComplaint.MouseLeave += btnFileComplaint_MouseLeave;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(936, 52);
            panel3.TabIndex = 55;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(447, 9);
            label2.Name = "label2";
            label2.Size = new Size(77, 33);
            label2.TabIndex = 0;
            label2.Text = "User";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CitizenDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(936, 563);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CitizenDashboard";
            Text = "CitizenDashboard";
            Load += CitizenDashboard_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button btnViewComplaints;
        private Button btnTrackComplaint;
        private Button btnFileComplaint;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
    }
}