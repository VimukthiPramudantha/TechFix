using System;
using System.Collections.Generic;
using System.Configuration;
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
