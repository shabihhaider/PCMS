namespace LatestCMS
{
    partial class PoliceOfficerLogin
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
            chkShowPassword = new CheckBox();
            btnClear = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(280, 202);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(132, 24);
            chkShowPassword.TabIndex = 42;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged_1;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(280, 244);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 41;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(145, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 40;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(280, 153);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 27);
            txtPassword.TabIndex = 39;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(280, 108);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(278, 27);
            txtUsername.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 108);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 37;
            label5.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 156);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 36;
            label3.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(221, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 35;
            label1.Text = "Police Officer Login";
            // 
            // PoliceOfficerLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 377);
            Controls.Add(chkShowPassword);
            Controls.Add(btnClear);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "PoliceOfficerLogin";
            Text = "PoliceOfficerLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkShowPassword;
        private Button btnClear;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
        private Label label3;
        private Label label1;
    }
}