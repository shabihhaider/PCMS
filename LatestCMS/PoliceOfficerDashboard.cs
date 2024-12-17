using Microsoft.Data.SqlClient;
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
            if (dgvAssignedComplaints.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a complaint to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int complaintID = Convert.ToInt32(dgvAssignedComplaints.SelectedRows[0].Cells["ComplaintID"].Value);
            string newStatus = "Resolved";  // You can add a status dropdown for flexibility

            try
            {
                string query = "UPDATE Complaints SET Status = @Status WHERE ComplaintID = @ComplaintID";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@ComplaintID", complaintID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Complaint status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignedComplaints();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
