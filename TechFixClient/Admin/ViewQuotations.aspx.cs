using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class ViewQuotations : System.Web.UI.Page
    {
        QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();
        private int userId = 1; // Example user ID, replace with actual logged-in user ID

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            // Load product list for the dropdown - replace with actual method to get products
            ddlProducts.Items.Clear();
            ddlProducts.Items.Add(new ListItem("Select a Product", "0"));
            ddlProducts.Items.Add(new ListItem("Product 1", "1"));
            ddlProducts.Items.Add(new ListItem("Product 2", "2"));
            // Add more products as needed
        }

        protected void ddlProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(ddlProducts.SelectedValue);
            if (productId > 0)
            {
                LoadQuotations(productId);
            }
            else
            {
                gvQuotations.Visible = false;
            }
        }

        private void LoadQuotations(int productId)
        {
            DataTable quotationsTable = service.GetQuotationsByProduct(productId);
            

            gvQuotations.DataSource = quotationsTable;
            gvQuotations.DataBind();
            gvQuotations.Visible = true;
        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int quotationId = Convert.ToInt32(btn.CommandArgument);

            SaveQuotationResponse(quotationId, "Accepted");
        }

        protected void btnDecline_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int quotationId = Convert.ToInt32(btn.CommandArgument);

            SaveQuotationResponse(quotationId, "Declined");
        }

        private void SaveQuotationResponse(int quotationId, string response)
        {
            int quantity = 1; // Placeholder, replace with actual value
            decimal price = 100; // Placeholder, replace with actual price

            
            bool success = service.SaveQuotationResponse(quotationId, userId, quantity, price, response);

            if (success)
            {
                Response.Write("<script>alert('Quotation response saved successfully.');</script>");
                int productId = Convert.ToInt32(ddlProducts.SelectedValue);
                LoadQuotations(productId);
            }
            else
            {
                Response.Write("<script>alert('Failed to save quotation response.');</script>");
            }
        }
    }
}