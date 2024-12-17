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

namespace LatestCMS.User_Control
{
    public partial class ManagePoliceOfficerUserControl : UserControl
    {
        public ManagePoliceOfficerUserControl()
        {
            InitializeComponent();
            LoadOfficers();
        }

        private void ManagePoliceOfficerUserControl_Load(object sender, EventArgs e)
        {

        }

        private void LoadOfficers()
        {
            try
            {
                string query = "SELECT OfficerID, OfficerName, Rank, BadgeNo, ContactNo, Email, Username, DateJoined FROM PoliceOfficers";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvOfficers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOfficers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a police officer to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int officerID = Convert.ToInt32(dgvOfficers.SelectedRows[0].Cells["OfficerID"].Value);
            string officerName = dgvOfficers.SelectedRows[0].Cells["OfficerName"].Value.ToString();
            string rank = dgvOfficers.SelectedRows[0].Cells["Rank"].Value.ToString();
            string contactNo = dgvOfficers.SelectedRows[0].Cells["ContactNo"].Value.ToString();
            string email = dgvOfficers.SelectedRows[0].Cells["Email"].Value.ToString();

            string query = "UPDATE PoliceOfficers SET OfficerName = @OfficerName, Rank = @Rank, ContactNo = @ContactNo, Email = @Email WHERE OfficerID = @OfficerID";

            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OfficerName", officerName);
                    cmd.Parameters.AddWithValue("@Rank", rank);
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@OfficerID", officerID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Police officer details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadOfficers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOfficers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a police officer to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int officerID = Convert.ToInt32(dgvOfficers.SelectedRows[0].Cells["OfficerID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to delete this officer?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM PoliceOfficers WHERE OfficerID = @OfficerID";

                    using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OfficerID", officerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Police officer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOfficers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
