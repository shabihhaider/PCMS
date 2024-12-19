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
    public partial class AssignComplaintUserControl : UserControl
    {
        public AssignComplaintUserControl()
        {
            InitializeComponent();
            LoadComplaints();
            LoadOfficers();
        }

        private void AssignComplaintUserControl_Load(object sender, EventArgs e)
        {
            LoadComplaints();
            LoadOfficers();
        }

        private void LoadComplaints()
        {
            try
            {
                string query = "SELECT ComplaintID, ComplaintTitle FROM Complaints WHERE AssignedOfficerID IS NULL";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboComplaints.Items.Clear();
                    while (reader.Read())
                    {
                        cboComplaints.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0), reader.GetString(1)
                        ));
                    }
                    cboComplaints.DisplayMember = "Value";
                    cboComplaints.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading complaints: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOfficers()
        {
            try
            {
                string query = "SELECT OfficerID, OfficerName FROM PoliceOfficers";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False"))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboOfficers.Items.Clear();
                    while (reader.Read())
                    {
                        cboOfficers.Items.Add(new KeyValuePair<int, string>(
                            reader.GetInt32(0), reader.GetString(1)
                        ));
                    }
                    cboOfficers.DisplayMember = "Value";
                    cboOfficers.ValueMember = "Key";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading officers: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cboComplaints.SelectedItem == null || cboOfficers.SelectedItem == null)
            {
                MessageBox.Show("Please select both a complaint and a police officer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Extract selected complaint and officer
                var selectedComplaint = (KeyValuePair<int, string>)cboComplaints.SelectedItem;
                var selectedOfficer = (KeyValuePair<int, string>)cboOfficers.SelectedItem;

                // Initialize WCF client
                using (var client = new ServiceReference1.Service1Client())
                {
                    // Call the WCF service method
                    bool isAssigned = client.AssignComplaint(selectedComplaint.Key, selectedOfficer.Key);

                    if (isAssigned)
                    {
                        MessageBox.Show("Complaint assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadComplaints();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign complaint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
