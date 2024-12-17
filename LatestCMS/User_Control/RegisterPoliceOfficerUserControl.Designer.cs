namespace LatestCMS.User_Control
{
    partial class RegisterPoliceOfficerUserControl
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
            txtOfficerName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtRank = new TextBox();
            label4 = new Label();
            txtBadgeNo = new TextBox();
            label5 = new Label();
            txtContactNo = new TextBox();
            label6 = new Label();
            txtPassword = new TextBox();
            label7 = new Label();
            txtUsername = new TextBox();
            label8 = new Label();
            txtEmail = new TextBox();
            btnRegisterOfficer = new Button();
            panel1 = new Panel();
            txtName = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 17);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Register Police Officer";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 71);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "Rank";
            // 
            // txtRank
            // 
            txtRank.Location = new Point(279, 68);
            txtRank.Name = "txtRank";
            txtRank.Size = new Size(274, 27);
            txtRank.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 119);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 6;
            label4.Text = "Badge Number";
            // 
            // txtBadgeNo
            // 
            txtBadgeNo.Location = new Point(279, 116);
            txtBadgeNo.Name = "txtBadgeNo";
            txtBadgeNo.Size = new Size(274, 27);
            txtBadgeNo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 169);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 8;
            label5.Text = "Contact Number";
            // 
            // txtContactNo
            // 
            txtContactNo.Location = new Point(279, 166);
            txtContactNo.Name = "txtContactNo";
            txtContactNo.Size = new Size(274, 27);
            txtContactNo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 313);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 14;
            label6.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(279, 310);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(274, 27);
            txtPassword.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(95, 263);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 12;
            label7.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(279, 260);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(274, 27);
            txtUsername.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 215);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 10;
            label8.Text = "Email Address";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(279, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(274, 27);
            txtEmail.TabIndex = 9;
            // 
            // btnRegisterOfficer
            // 
            btnRegisterOfficer.Location = new Point(271, 439);
            btnRegisterOfficer.Name = "btnRegisterOfficer";
            btnRegisterOfficer.Size = new Size(126, 29);
            btnRegisterOfficer.TabIndex = 15;
            btnRegisterOfficer.Text = "Register Officer";
            btnRegisterOfficer.UseVisualStyleBackColor = true;
            btnRegisterOfficer.Click += btnRegisterOfficer_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtOfficerName);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtRank);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtBadgeNo);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(txtContactNo);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(49, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 354);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // txtName
            // 
            txtName.Location = new Point(279, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 27);
            txtName.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 26);
            label9.Name = "label9";
            label9.Size = new Size(98, 20);
            label9.TabIndex = 16;
            label9.Text = "Officer Name";
            // 
            // RegisterPoliceOfficerUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(btnRegisterOfficer);
            Controls.Add(label1);
            Name = "RegisterPoliceOfficerUserControl";
            Size = new Size(749, 532);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtOfficerName;
        private Label label2;
        private Label label3;
        private TextBox txtRank;
        private Label label4;
        private TextBox txtBadgeNo;
        private Label label5;
        private TextBox txtContactNo;
        private Label label6;
        private TextBox txtPassword;
        private Label label7;
        private TextBox txtUsername;
        private Label label8;
        private TextBox txtEmail;
        private Button btnRegisterOfficer;
        private Panel panel1;
        private TextBox txtName;
        private Label label9;
    }
}
