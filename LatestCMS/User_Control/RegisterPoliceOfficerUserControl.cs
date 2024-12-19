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
using static Org.BouncyCastle.Asn1.Cmp.Challenge;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

                // Initialize WCF client
                using (var client = new ServiceReference1.Service1Client())
                {
                    // Call the WCF service method
                    bool isAssigned = client.RegisterPoliceOfficer(txtName.Text, txtRank.Text, txtBadgeNo.Text, txtContactNo.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);

                    if (isAssigned)
                    {
                        MessageBox.Show("Officer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearRegistrationFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to Register Officer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
