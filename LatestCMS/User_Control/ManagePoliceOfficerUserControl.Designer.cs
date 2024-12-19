namespace LatestCMS.User_Control
{
    partial class ManagePoliceOfficerUserControl
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
            dgvOfficers = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtRank = new TextBox();
            label3 = new Label();
            txtBadgeNo = new TextBox();
            label8 = new Label();
            label4 = new Label();
            txtEmail = new TextBox();
            txtContactNo = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvOfficers).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 17);
            label1.Name = "label1";
            label1.Size = new Size(161, 20);
            label1.TabIndex = 0;
            label1.Text = "Manage Police Officers";
            // 
            // dgvOfficers
            // 
            dgvOfficers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOfficers.Location = new Point(517, 107);
            dgvOfficers.Name = "dgvOfficers";
            dgvOfficers.RowHeadersWidth = 51;
            dgvOfficers.Size = new Size(323, 273);
            dgvOfficers.TabIndex = 1;
            dgvOfficers.CellClick += dgvOfficers_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(253, 392);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(99, 392);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtRank
            // 
            txtRank.Location = new Point(202, 159);
            txtRank.Name = "txtRank";
            txtRank.Size = new Size(274, 27);
            txtRank.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 162);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 18;
            label3.Text = "Rank";
            // 
            // txtBadgeNo
            // 
            txtBadgeNo.Location = new Point(202, 207);
            txtBadgeNo.Name = "txtBadgeNo";
            txtBadgeNo.Size = new Size(274, 27);
            txtBadgeNo.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 306);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 24;
            label8.Text = "Email Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 210);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 20;
            label4.Text = "Badge Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 303);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 27);
            txtEmail.TabIndex = 23;
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(202, 257);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(274, 27);
            txtContactNo.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 260);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 22;
            label5.Text = "Contact Number";
            // 
            // ManagePoliceOfficerUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtRank);
            Controls.Add(label3);
            Controls.Add(txtBadgeNo);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(txtContactNo);
            Controls.Add(label5);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvOfficers);
            Controls.Add(label1);
            Name = "ManagePoliceOfficerUserControl";
            Size = new Size(881, 577);
            Load += ManagePoliceOfficerUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dgvOfficers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvOfficers;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtRank;
        private Label label3;
        private TextBox txtBadgeNo;
        private Label label8;
        private Label label4;
        private TextBox txtEmail;
        private TextBox txtContactNo;
        private Label label5;
    }
}
