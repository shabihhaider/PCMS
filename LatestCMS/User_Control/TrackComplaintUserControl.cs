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
    public partial class TrackComplaintUserControl : UserControl
    {
        public TrackComplaintUserControl()
        {
            InitializeComponent();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtComplaintID.Text))
            {
                MessageBox.Show("Please enter a Complaint ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Complaints WHERE ComplaintID = @ComplaintID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ComplaintID", int.Parse(txtComplaintID.Text));

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            dataGridView1.DataSource = dt;
                            MessageBox.Show("Complaint found!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Complaint not found. Please check the Complaint ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearComplaints();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearComplaints()
        {
            dataGridView1.DataSource = null;
        }

        private void txtComplaintID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;  // Reject non-numeric input
            }
        }

    }
}
