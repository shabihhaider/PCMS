namespace LatestCMS.User_Control
{
    partial class TrackComplaintUserControl
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
            txtComplaintID = new TextBox();
            label2 = new Label();
            btnTrack = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 19);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 0;
            label1.Text = "Track Complaint";
            // 
            // txtComplaintID
            // 
            txtComplaintID.Location = new Point(339, 115);
            txtComplaintID.Name = "txtComplaintID";
            txtComplaintID.Size = new Size(218, 27);
            txtComplaintID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 115);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Enter Complaint ID";
            // 
            // btnTrack
            // 
            btnTrack.Location = new Point(293, 172);
            btnTrack.Name = "btnTrack";
            btnTrack.Size = new Size(94, 29);
            btnTrack.TabIndex = 3;
            btnTrack.Text = "Track";
            btnTrack.UseVisualStyleBackColor = true;
            btnTrack.Click += btnTrack_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(687, 226);
            dataGridView1.TabIndex = 4;
            // 
            // TrackComplaintUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnTrack);
            Controls.Add(label2);
            Controls.Add(txtComplaintID);
            Controls.Add(label1);
            Name = "TrackComplaintUserControl";
            Size = new Size(728, 520);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtComplaintID;
        private Label label2;
        private Button btnTrack;
        private DataGridView dataGridView1;
    }
}
