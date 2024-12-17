using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Crypto.Generators;
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

namespace LatestCMS.User_Control
{
    public partial class RegisterPoliceOfficerUserControl : UserControl
    {
        public RegisterPoliceOfficerUserControl()
        {
            InitializeComponent();
        }

        private void btnRegisterOfficer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) ||
                    string.IsNullOrEmpty(txtBadgeNo.Text) ||
                    string.IsNullOrEmpty(txtUsername.Text) ||
                    string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "INSERT INTO PoliceOfficers (OfficerName, Rank, BadgeNo, ContactNo, Email, Username, PasswordHash) " +
                               "VALUES (@Name, @Rank, @BadgeNo, @ContactNo, @Email, @Username, @PasswordHash)";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Rank", txtRank.Text);
                    cmd.Parameters.AddWithValue("@BadgeNo", txtBadgeNo.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);

                    // Hashing the password
                    string passwordHash = HashPassword(txtPassword.Text);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Police Officer registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearRegistrationFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearRegistrationFields()
        {
            txtName.Clear();
            txtRank.Clear();
            txtBadgeNo.Clear();
            txtContactNo.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
