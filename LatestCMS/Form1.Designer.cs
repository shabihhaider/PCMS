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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(287, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "User Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 95);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(287, 95);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(278, 27);
            txtFullName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(287, 277);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(278, 27);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(152, 193);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(287, 315);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(278, 27);
            txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 236);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(287, 145);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 27);
            txtUsername.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 145);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 7;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(152, 277);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 9;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(152, 315);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 10;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(152, 365);
            label8.Name = "label8";
            label8.Size = new Size(39, 20);
            label8.TabIndex = 11;
            label8.Text = "Role";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(287, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(287, 233);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(278, 27);
            txtConfirmPassword.TabIndex = 13;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Items.AddRange(new object[] { "Admin", "Police Officer", "Citizen" });
            cboRole.Location = new Point(287, 362);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(151, 28);
            cboRole.TabIndex = 14;
            cboRole.Click += cboRole_Click;
            cboRole.KeyPress += cboRole_KeyPress;
            cboRole.MouseClick += cboRole_MouseClick;
            cboRole.MouseEnter += cboRole_MouseEnter;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(152, 440);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 15;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(287, 440);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(407, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 29);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Already Register";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(714, 512);
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
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
    }
}
