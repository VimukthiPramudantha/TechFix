using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class AdminDashBrod : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Page load logic, if necessary
        }

        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProducts.aspx"); // Redirect to the View Products page
        }

        protected void btnViewOrders_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrders.aspx"); // Redirect to the View Orders page
        }

        protected void btnNewQuotations_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewQuotations.aspx"); // Redirect to the New Quotations page
        }

        protected void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("addSupplier.aspx"); 
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Clear session or authentication cookie, if applicable
            Session.Clear();
            Response.Redirect("../Login.aspx"); // Redirect to the Login page
        }
    }
}