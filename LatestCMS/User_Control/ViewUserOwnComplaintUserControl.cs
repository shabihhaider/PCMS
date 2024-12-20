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
    public partial class ViewUserOwnComplaintUserControl : UserControl
    {
        public Session session1 = new Session();
        public ViewUserOwnComplaintUserControl(Session session)
        {
            InitializeComponent();
            session1 = session;
            LoadUserComplaint(session1);
        }

        public void LoadUserComplaint(Session session2)
        {
            try
            {
                string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=SELab;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    //string query = "SELECT c.ComplaintID, c.ComplaintTitle, c.ComplaintType, c.Description, c.ContactName, c.Phone, c.IncidentDate, c.Status, c.DateFiled, c.DateResolved FROM Complaints c INNER JOIN Users u ON c.UserID = u.UserID WHERE u.Username = @Username";

                    string query = "SELECT * FROM Complaints WHERE UserID = @UserID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();

                        // Bind the username parameter explicitly
                        cmd.Parameters.AddWithValue("@UserID", session2.UserID);

                        SqlDataReader reader = cmd.ExecuteReader();

                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        if (dt.Rows.Count > 0)
                        {
                            dataGridView1.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("You don't have any complaints to view.", "No Complaints", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database Error: {sqlEx.Message}", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ViewUserOwnComplaintUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
