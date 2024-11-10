using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TechFixServer
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {
        string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public string AuthenticateUser(string email, string password)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT role FROM [User] WHERE email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    object roleObj = cmd.ExecuteScalar();

                    if (roleObj != null)
                    {
                        return roleObj.ToString();
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    // Log detailed exception message
                    throw new Exception("AuthenticateUser failed: " + ex.Message);
                }
              
                
            }
        }

        [WebMethod]
        public int GetUserIdByEmail(string email)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Query to get the userId based on the email
                string query = "SELECT userId FROM [User] WHERE email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Email", email);

                    connection.Open();

                    // Execute the query and fetch the userId
                    object result = cmd.ExecuteScalar();

                    // If a userId is found, return it; otherwise, return 0
                    if (result != null)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 0; // Return 0 if no user is found with the given email
                    }
                }
            }
        }

        [WebMethod]
        public string AddSupplier(string userName, string email, string password, string contactNo)
        {
            // Define a success message
            string successMessage = "Supplier added successfully!";

            // Connection string to the database
            string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO [User] (userName, email, password, contactNo, role) " +
                                   "VALUES (@UserName, @Email, @Password, @ContactNo, @Role)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);  // Password should ideally be hashed
                    command.Parameters.AddWithValue("@ContactNo", contactNo);
                    command.Parameters.AddWithValue("@Role", "Supplier");  // Fixed role as 'Supplier'

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Return an error message if something goes wrong
                    successMessage = "Error: " + ex.Message;
                }
            }

            return successMessage;
        }
    }
}
