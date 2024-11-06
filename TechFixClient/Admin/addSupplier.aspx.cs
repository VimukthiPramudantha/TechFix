using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class addSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccessMessage.Text = string.Empty;
        }

        protected void btnSaveSupplier_Click(object sender, EventArgs e)
        {
            // Get the form data
            string userName = txtUserName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string contactNo = txtContactNo.Text;

            // Create an instance of the UserService web service
            UserServiceReference.UserServiceSoapClient userService = new UserServiceReference.UserServiceSoapClient();

            // Call the AddSupplier method of the web service and get the result
            string result = userService.AddSupplier(userName, email, password, contactNo);

            // Display the result in the label
            lblSuccessMessage.Text = result;
            lblSuccessMessage.Visible = true;

            // Optionally, clear the form fields
            txtUserName.Text = "";
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtContactNo.Text = "";
        
    }
    }
}