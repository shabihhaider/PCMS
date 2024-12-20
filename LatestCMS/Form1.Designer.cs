namespace LatestCMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            cboRole = new ComboBox();
            btnRegister = new Button();
            btnClear = new Button();
            btnLogin = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(271, 18);
            label1.Name = "label1";
            label1.Size = new Size(242, 38);
            label1.TabIndex = 0;
            label1.Text = "User Registration";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(159, 110);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.White;
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(391, 107);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(250, 34);
            txtFullName.TabIndex = 2;
            txtFullName.Enter += txtConfirmPassword_Enter;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(391, 186);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(250, 34);
            txtEmail.TabIndex = 4;
            txtEmail.Enter += txtConfirmPassword_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(160, 267);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.Font = new Font("Segoe UI", 12F);
            txtPhone.Location = new Point(389, 229);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(250, 34);
            txtPhone.TabIndex = 6;
            txtPhone.Enter += txtConfirmPassword_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(159, 311);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 12F);
            txtUsername.Location = new Point(391, 148);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(250, 34);
            txtUsername.TabIndex = 8;
            txtUsername.Enter += txtConfirmPassword_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(160, 148);
            label5.Name = "label5";
            label5.Size = new Size(87, 23);
            label5.TabIndex = 7;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(160, 186);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(160, 229);
            label7.Name = "label7";
            label7.Size = new Size(59, 23);
            label7.TabIndex = 10;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(159, 358);
            label8.Name = "label8";
            label8.Size = new Size(44, 23);
            label8.TabIndex = 11;
            label8.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(389, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(250, 34);
            txtPassword.TabIndex = 12;
            txtPassword.Enter += txtConfirmPassword_Enter;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F);
            txtConfirmPassword.Location = new Point(387, 311);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(250, 34);
            txtConfirmPassword.TabIndex = 13;
            txtConfirmPassword.Enter += txtConfirmPassword_Enter;
            // 
            // cboRole
            // 
            cboRole.BackColor = Color.White;
            cboRole.Font = new Font("Segoe UI", 12F);
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Police Officer", "Citizen" });
            cboRole.Location = new Point(389, 358);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(250, 36);
            cboRole.TabIndex = 14;
            cboRole.Click += cboRole_Click;
            cboRole.KeyPress += cboRole_KeyPress;
            cboRole.MouseClick += cboRole_MouseClick;
            cboRole.MouseEnter += cboRole_MouseEnter;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.Window;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnRegister.Location = new Point(160, 439);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(130, 43);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // btnClear
            // 
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClear.Location = new Point(322, 439);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(131, 43);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.MouseEnter += btnClear_MouseEnter;
            btnClear.MouseLeave += btnClear_MouseLeave;
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(485, 439);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(150, 43);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Already Register";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 71);
            panel1.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Police_Complaint_Management_Logo_removebg_preview;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 512);
            Controls.Add(panel1);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(cboRole);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtUsername;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private ComboBox cboRole;
        private Button btnRegister;
        private Button btnClear;
        private Button btnLogin;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}
