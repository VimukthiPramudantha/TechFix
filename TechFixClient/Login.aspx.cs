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
            lblErrorMessage.Text = string.Empty;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            // Get email and password from the textboxes
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            // Create an instance of the LoginService web service
            LoginServiceReference.LoginServiceSoapClient loginService = new LoginServiceReference.LoginServiceSoapClient();

            // Call the Login method in the LoginService
            bool isValidUser = loginService.Login(email, password);

            if (isValidUser)
            {
                // Redirect to the admin dashboard in the Admin folder on successful login
                Response.Redirect("~/Supplier/SupplierDashboard.aspx");
            }

            {
                // Display error message on login failure
                lblErrorMessage.Text = "Invalid email or password.";
                lblErrorMessage.Visible = true;
            }
        }
    }
}