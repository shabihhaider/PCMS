using System;
using System.ServiceModel;
using System.Data.SqlClient;

namespace WcfService1
{
    public class Service1 : IService1
    {
        public bool AssignComplaint(int complaintID, int officerID)
        {
            try
            {
                // Retrieve connection string from Web.config
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string query = "UPDATE Complaints SET AssignedOfficerID = @OfficerID WHERE ComplaintID = @ComplaintID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OfficerID", officerID);
                    cmd.Parameters.AddWithValue("@ComplaintID", complaintID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                // Log exception details or throw a WCF Fault
                throw new FaultException($"Database Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                throw new FaultException($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
