using Microsoft.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace LatestCMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Users (FullName, Username, PasswordHash, Email, Phone, Role) " +
                                       "VALUES (@FullName, @Username, @PasswordHash, @Email, @Phone, @Role)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                            cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem.ToString());

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Login login = new Login();
                            login.Show();
                            //this.Hide();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        // Function to validate form input
        private bool ValidateForm()
        {
            // If user select Police Officer role, show error message
            if (cboRole.SelectedItem == "Police Officer")
            {
                MessageBox.Show("You can register only by Admin. If you already have an account. Please, Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PoliceOfficerLogin policeOfficerLogin = new PoliceOfficerLogin();
                policeOfficerLogin.Show();
                return false;
            }
            else
            {

                if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhone.Text) ||
                    cboRole.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!Regex.IsMatch(txtEmail.Text, @"^\w+@\w+\.\w+$"))
                {
                    MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
                {
                    MessageBox.Show("Enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cboRole.SelectedIndex = -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            //this.Hide();
        }

        private void cboRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (cboRole.Text == "Police Officer")
            //{
            //    MessageBox.Show("You can register only by Admin. If you already have an account. Please, Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboRole_MouseEnter(object sender, EventArgs e)
        {
            //if (cboRole.Text == "Police Officer")
            //{
            //    MessageBox.Show("You can register only by Admin. If you already have an account. Please, Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboRole_Click(object sender, EventArgs e)
        {
            //if (cboRole.Text == "Police Officer")
            //{
            //    MessageBox.Show("You can register only by Admin. If you already have an account. Please, Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void cboRole_MouseClick(object sender, MouseEventArgs e)
        {
            //if (cboRole.Text == "Police Officer")
            //{
            //    MessageBox.Show("You can register only by Admin. If you already have an account. Please, Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }
    }
}
