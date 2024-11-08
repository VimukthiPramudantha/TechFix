using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class PlaceQuotation : System.Web.UI.Page
    {
        QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        // Method to load categories from the web service
        private void LoadCategories()
        {
            DataTable categories = service.GetCategories();

            if (categories != null)
            {
                ddlCategory.DataSource = categories;
                ddlCategory.DataTextField = "CategoryName"; // Column name for displaying
                ddlCategory.DataValueField = "CategoryId";  // Column name for value
                ddlCategory.DataBind();
            }

            ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
        }

        // Load products based on the selected category
        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlCategory.SelectedValue != "0")
            {
                LoadProducts(Convert.ToInt32(ddlCategory.SelectedValue));
            }
            else
            {
                ddlProduct.Items.Clear();
                ddlProduct.Items.Insert(0, new ListItem("-- Select Product --", "0"));
            }
        }

        // Method to load products based on selected category
        private void LoadProducts(int categoryId)
        {
            DataTable products = service.GetProductsByCategory(categoryId);

            if (products != null)
            {
                ddlProduct.DataSource = products;
                ddlProduct.DataTextField = "ProductName"; // Column name for displaying
                ddlProduct.DataValueField = "ProductId";  // Column name for value
                ddlProduct.DataBind();
            }

            ddlProduct.Items.Insert(0, new ListItem("-- Select Product --", "0"));
        }

        // Handle the Place Quotation button click
        protected void btnPlaceQuotation_Click(object sender, EventArgs e)
        {
            if (ddlCategory.SelectedValue == "0" || ddlProduct.SelectedValue == "0")
            {
                lblMessage.Text = "Please select a category and product.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Get selected values
            int productId = Convert.ToInt32(ddlProduct.SelectedValue);
            int categoryId = Convert.ToInt32(ddlCategory.SelectedValue);
            int quantity;

            // Validate quantity input
            if (!int.TryParse(txtQuantity.Text.Trim(), out quantity) || quantity <= 0)
            {
                lblMessage.Text = "Please enter a valid quantity.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            // Call the PlaceQuotation method from the web service
            bool isPlaced = service.PlaceQuotation(productId, categoryId, quantity);

            if (isPlaced)
            {
                lblMessage.Text = "Quotation placed successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblMessage.Text = "Failed to place quotation.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}