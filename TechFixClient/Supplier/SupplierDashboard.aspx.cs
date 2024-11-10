using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TechFixClient.SupplierServiceReference;

namespace TechFixClient.Supplier
{
    public partial class SupplierDashboard : System.Web.UI.Page
    {
        public void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Event handler for Category & Products button
        public void btnCategoryProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoryProducts.aspx");
        }

        // Event handler for Respond to Quotations button
        public void btnResponseQuotations_Click(object sender, EventArgs e)
        {
            Response.Redirect("RespondToQuotations.aspx");
        }

        // Event handler for View Order Status button
        public void btnOrderStatus_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewOrderStatus.aspx");
        }

        // Event handler for Logout button
        public void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon(); 
            Response.Redirect("../Login.aspx"); 
        }
    }
}