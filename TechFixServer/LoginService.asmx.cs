using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TechFixServer
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class LoginService : WebService
    {
        private readonly string _connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public bool Login(string email, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT COUNT(*) FROM [User] WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    isAuthenticated = count > 0;
                }
                catch (Exception ex)
                {
                    // Log or handle exception if needed
                }
            }

            return isAuthenticated;
        }
    }
}
