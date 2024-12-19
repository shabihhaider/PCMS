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
    public partial class ManageUserControl : UserControl
    {
        public ManageUserControl()
        {
            InitializeComponent();
            LoadComplaints();
        }

        //private void btnAddUser_Click(object sender, EventArgs e)
        //{
        //    if (ValidateForm())
        //    {
        //        try
        //        {
        //            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //            using (SqlConnection conn = new SqlConnection(connectionString))
        //            {
        //                string query = "INSERT INTO Users (FullName, Username, Email, Phone, Role) " +
        //                               "VALUES (@FullName, @Username, @Email, @Phone, @Role)";

        //                using (SqlCommand cmd = new SqlCommand(query, conn))
        //                {
        //                    cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
        //                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
        //                    //cmd.Parameters.AddWithValue("@PasswordHash", HashPassword(txtPassword.Text));
        //                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
        //                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
        //                    //cmd.Parameters.AddWithValue("@Role", cboRole.SelectedItem.ToString());

        //                    conn.Open();
        //                    cmd.ExecuteNonQuery();
        //                    MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                    LoadUsers();  // Refresh DataGridView
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        //private void LoadUsers()
        //{
        //    try
        //    {
        //        string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            string query = "SELECT UserID, FullName, Username, Email, Phone, Role FROM Users";

        //            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //            DataTable dataTable = new DataTable();
        //            adapter.Fill(dataTable);

        //            dgvComplaints.DataSource = dataTable;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnUpdateUser_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(lblComplaintTitle.Text) || cboStatus.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Please select a complaint and update its status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    try
        //    {
        //        string connectionString = "YourDatabaseConnectionString";
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            string query = "UPDATE Complaints SET Status = @Status, Response = @Response, DateResolved = CASE WHEN @Status = 'Resolved' THEN GETDATE() ELSE NULL END WHERE ComplaintID = @ComplaintID";

        //            using (SqlCommand cmd = new SqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString());
        //                cmd.Parameters.AddWithValue("@Response", txtResponse.Text);
        //                cmd.Parameters.AddWithValue("@ComplaintID", int.Parse(dgvComplaints.CurrentRow.Cells["ComplaintID"].Value.ToString()));

        //                conn.Open();
        //                cmd.ExecuteNonQuery();

        //                MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                LoadComplaints();  // Refresh DataGridView
        //                //ClearFields();     // Reset form fields
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private void btnDeleteUser_Click(object sender, EventArgs e)
        //{
        //    if (dgvComplaints.SelectedRows.Count > 0)
        //    {
        //        DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete",
        //                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        //        if (result == DialogResult.Yes)
        //        {
        //            try
        //            {
        //                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        //                using (SqlConnection conn = new SqlConnection(connectionString))
        //                {
        //                    string query = "DELETE FROM Users WHERE UserID = @UserID";

        //                    using (SqlCommand cmd = new SqlCommand(query, conn))
        //                    {
        //                        cmd.Parameters.AddWithValue("@UserID", dgvComplaints.SelectedRows[0].Cells["UserID"].Value);

        //                        conn.Open();
        //                        cmd.ExecuteNonQuery();
        //                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                        LoadUsers();  // Refresh DataGridView
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //    }
        //}

        //private bool ValidateForm()
        //{
        //    if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
        //        string.IsNullOrWhiteSpace(txtUsername.Text) ||
        //        string.IsNullOrWhiteSpace(txtEmail.Text) ||
        //        string.IsNullOrWhiteSpace(txtPhone.Text))
        //        //cboRole.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    if (!Regex.IsMatch(txtEmail.Text, @"^\w+@\w+\.\w+$"))
        //    {
        //        MessageBox.Show("Enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    if (!Regex.IsMatch(txtPhone.Text, @"^\d{10}$"))
        //    {
        //        MessageBox.Show("Enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }

        //    return true;
        //}

        private void ManageUserControl_Load(object sender, EventArgs e)
        {
            LoadComplaints();
        }





        private void LoadComplaints()
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Complaints";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvComplaints.DataSource = dt;
                }
            }
        }

        private void dgvComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvComplaints.CurrentRow != null)
            {
                DataGridViewRow row = dgvComplaints.Rows[e.RowIndex];

                txtComplaintTitle.Text = row.Cells["ComplaintTitle"].Value?.ToString() ?? string.Empty;
                cboComplaintType.Text = row.Cells["ComplaintType"].Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
                txtContactName.Text = row.Cells["ContactName"].Value?.ToString() ?? string.Empty;
                txtPhone.Text = row.Cells["Phone"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                dtpIncidentDate.Value = DateTime.TryParse(row.Cells["IncidentDate"].Value?.ToString(), out DateTime incidentDate) ? incidentDate : DateTime.Now;
                cboStatus.Text = row.Cells["Status"].Value?.ToString() ?? string.Empty;
                dateTimePicker2.Value = DateTime.TryParse(row.Cells["DateFiled"].Value?.ToString(), out DateTime dateFiled) ? dateFiled : DateTime.Now;
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComplaintTitle.Text) || cboStatus.SelectedIndex == -1 || dgvComplaints.CurrentRow == null)
            {
                MessageBox.Show("Please select a complaint and update its status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Complaints SET ComplaintTitle = @ComplaintTitle, ComplaintType = @ComplaintType, Description = @Description, ContactName = @ContactName, Phone = @Phone, Email = @Email, Status = @Status, DateResolved = CASE WHEN @Status = 'Resolved' THEN GETDATE() ELSE NULL END WHERE ComplaintID = @ComplaintID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ComplaintTitle", txtComplaintTitle.Text);
                        cmd.Parameters.AddWithValue("@ComplaintType", cboComplaintType.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text);
                        cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ComplaintID", Convert.ToInt32(dgvComplaints.CurrentRow.Cells["ComplaintID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadComplaints();  // Refresh DataGridView
                        ClearFields();     // Reset form fields
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtComplaintTitle.Clear();
            cboComplaintType.SelectedIndex = -1;
            txtDescription.Clear();
            txtContactName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            cboStatus.SelectedIndex = -1;
            dtpIncidentDate.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearFields();  // Reload the complaints list
        }

    }
}
