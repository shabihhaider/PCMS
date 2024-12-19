using System;
using System.ServiceModel;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Text;

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

        public bool RegisterPoliceOfficer(string officerName, string rank, string badgeNo, string contactNo, string email, string username, string password)
        {
            try
            {
                // Retrieve connection string from Web.config
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

                string query = "INSERT INTO PoliceOfficers (OfficerName, Rank, BadgeNo, ContactNo, Email, Username, PasswordHash) " +
                               "VALUES (@Name, @Rank, @BadgeNo, @ContactNo, @Email, @Username, @PasswordHash)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", officerName);
                    cmd.Parameters.AddWithValue("@Rank", rank);
                    cmd.Parameters.AddWithValue("@BadgeNo", badgeNo);
                    cmd.Parameters.AddWithValue("@ContactNo", contactNo);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Username", username);

                    // Hashing the password
                    string passwordHash = HashPassword(password);
                    cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return true;
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

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }
    }
}