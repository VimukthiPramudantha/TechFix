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
        UserServiceReference.UserServiceSoapClient userService = new UserServiceReference.UserServiceSoapClient();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Get the entered email and password
                string email = txtEmail.Text?.Trim();
                string password = txtPassword.Text?.Trim();

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    lblMessage.Text = "Please enter both email and password.";
                    return;
                }

               
               
                // Authenticate user
                string role = userService.AuthenticateUser(email, password);

                if (role == null)
                {
                    lblMessage.Text = "Error during authentication.";
                }
                else if (role == "Admin")
                {
                    Response.Redirect("Admin/AdminDashBrod.aspx");
                }
                else if (role == "Supplier")
                {
                    int userId = userService.GetUserIdByEmail(email);

                    // Save the userId in the session
                    Session["userId"] = userId;
                    Response.Redirect("Supplier/SupplierDashboard.aspx");
                }
                else
                {
                    lblMessage.Text = "Invalid email or password.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An unexpected error occurred: " + ex.Message;
            }
        }

    }
}