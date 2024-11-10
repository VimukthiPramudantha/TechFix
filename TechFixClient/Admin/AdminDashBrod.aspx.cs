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
            
        }
        protected void btnCreateCategory_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateCategory.aspx");
        }
        protected void btnCreateProduct_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateProduct.aspx");
        }


        protected void btnPlaceQuotation_Click  (object sender, EventArgs e)
        {
            Response.Redirect("PlaceQuotation.aspx");
        }

        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProduct.aspx"); 
        }

        protected void btnNewQuotations_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewQuotations.aspx"); 
        }

        protected void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Response.Redirect("addSupplier.aspx"); 
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            
            Session.Clear();
            Response.Redirect("../Login.aspx"); 
        }

        
    }
}