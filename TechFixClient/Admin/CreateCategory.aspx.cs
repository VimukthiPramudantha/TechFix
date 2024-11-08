using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        CategoryWebServiceReferance.CategoryWebServiceSoapClient service = new CategoryWebServiceReferance.CategoryWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "";
        }

        protected void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                lblMessage.Text = "Please enter a category name.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Call the AddCategory method from the web service
            bool isAdded = service.AddCategory(categoryName);

            if (isAdded)
            {
                lblMessage.Text = "Category added successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtCategoryName.Text = ""; // Clear input
            }
            else
            {
                lblMessage.Text = "Failed to add category.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}