using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatestCMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateLoginForm())
            {
                try
                {
                    string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "SELECT Role FROM Users WHERE Username = @Username AND PasswordHash = @PasswordHash";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));

                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                string role = reader["Role"].ToString();
                                MessageBox.Show($"Login successful! Welcome, {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Navigate to the main dashboard based on role
                                NavigateToDashboard(role);
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ValidateLoginForm()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void NavigateToDashboard(string role)
        {

            // Open the appropriate dashboard based on role
            switch (role)
            {
                case "Admin":
                    new AdminDashboard().Show();
                    break;
                //case "Police Officer":
                //    new PoliceOfficerDashboard(PoliceID).Show();
                //    break;
                case "Citizen":
                    new CitizenDashboard().Show();
                    break;
            }

           // this.Hide(); // Close the login form
        }

    }
}
