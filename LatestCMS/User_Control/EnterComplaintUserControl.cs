using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatestCMS.User_Control
{
    public partial class EnterComplaintUserControl : UserControl
    {
        public Session session1 = new Session();
        public EnterComplaintUserControl(Session session)
        {
            InitializeComponent();
            session1 = session;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                try
                {
                    string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "INSERT INTO Complaints (ComplaintTitle, ComplaintType, Description, " +
                                       "ContactName, Phone, Email, IncidentDate, UserID) " +
                                       "VALUES (@ComplaintTitle, @ComplaintType, @Description, @ContactName, " +
                                       "@Phone, @Email, @IncidentDate, @UserID)";

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ComplaintTitle", txtComplaintTitle.Text);
                            cmd.Parameters.AddWithValue("@ComplaintType", cboComplaintType.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text);
                            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@IncidentDate", dtpIncidentDate.Value.Date);
                            cmd.Parameters.AddWithValue("@UserID", session1.UserID);

                            conn.Open();
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Complaint filed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();  // Reset all input fields
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            txtComplaintTitle.Clear();
            txtDescription.Clear();
            txtContactName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cboComplaintType.SelectedIndex = -1;
            dtpIncidentDate.Value = DateTime.Now;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtComplaintTitle.Text) ||
                string.IsNullOrWhiteSpace(txtDescription.Text) ||
                string.IsNullOrWhiteSpace(txtContactName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                cboComplaintType.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void EnterComplaintUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
