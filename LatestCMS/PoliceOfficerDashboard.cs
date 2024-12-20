using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatestCMS
{
    public partial class PoliceOfficerDashboard : Form
    {
        private int officerID;
        public PoliceOfficerDashboard(int officerID)
        {
            InitializeComponent();
            this.officerID = officerID;
            LoadAssignedComplaints();
        }

        private void LoadAssignedComplaints()
        {
            try
            {
                string query = "SELECT ComplaintID, ComplaintTitle, Status, Description " +
                               "FROM Complaints WHERE AssignedOfficerID = @OfficerID";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OfficerID", officerID);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvAssignedComplaints.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComplaintTitle.Text) || cboStatus.SelectedIndex == -1 || dgvAssignedComplaints.CurrentRow == null)
            {
                MessageBox.Show("Please select a complaint and update its status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Complaints SET ComplaintTitle = @ComplaintTitle, Description = @Description, Status = @Status, DateResolved = CASE WHEN @Status = 'Resolved' THEN GETDATE() ELSE NULL END WHERE ComplaintID = @ComplaintID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ComplaintTitle", txtComplaintTitle.Text);
                        cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@ComplaintID", Convert.ToInt32(dgvAssignedComplaints.CurrentRow.Cells["ComplaintID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAssignedComplaints();  // Refresh DataGridView
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
            txtDescription.Clear();
            cboStatus.SelectedIndex = -1;
        }

        private void dgvAssignedComplaints_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvAssignedComplaints.CurrentRow != null)
            {
                DataGridViewRow row = dgvAssignedComplaints.Rows[e.RowIndex];

                txtComplaintTitle.Text = row.Cells["ComplaintTitle"].Value?.ToString() ?? string.Empty;
                txtDescription.Text = row.Cells["Description"].Value?.ToString() ?? string.Empty;
                cboStatus.Text = row.Cells["Status"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnUpdateStatus_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnUpdateStatus_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }
    }
}
