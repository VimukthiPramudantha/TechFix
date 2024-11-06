using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Retrieve the connection string from Web.config
            string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    // Query to check for a user with the entered email and password
                    string query = "SELECT COUNT(1) FROM [User] WHERE Email = @Email AND Password = @Password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count == 1)
                    {
                        // If credentials are valid, display welcome message with email
                        lblMessage.Text = "Welcome, " + email;
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                        // Redirect to another page if needed
                        // Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        // Display an error message if login fails
                        lblMessage.Text = "Invalid email or password.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    // Log the error and display a general error message
                    lblMessage.Text = "An error occurred while connecting to the database.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}