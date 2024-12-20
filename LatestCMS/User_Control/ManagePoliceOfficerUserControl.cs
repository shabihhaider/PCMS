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
            LoadOfficers();
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

            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE PoliceOfficers SET Rank = @Rank, BadgeNo = @BadgeNo, ContactNo = @ContactNo, Email = @Email WHERE OfficerID = @OfficerID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Rank", txtRank.Text);
                        cmd.Parameters.AddWithValue("@BadgeNo", txtBadgeNo.Text);
                        cmd.Parameters.AddWithValue("@ContactNo", txtContactNo.Text);
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                        cmd.Parameters.AddWithValue("@OfficerID", Convert.ToInt32(dgvOfficers.CurrentRow.Cells["OfficerID"].Value));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Complaint updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadOfficers();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvOfficers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvOfficers.CurrentRow != null)
            {
                DataGridViewRow row = dgvOfficers.Rows[e.RowIndex];

                txtRank.Text = row.Cells["Rank"].Value?.ToString() ?? string.Empty;
                txtBadgeNo.Text = row.Cells["BadgeNo"].Value?.ToString() ?? string.Empty;
                txtContactNo.Text = row.Cells["ContactNo"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnUpdate_MouseEnter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.DarkCyan;
            button.ForeColor = Color.White;
        }

        private void btnUpdate_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void dgvOfficers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
