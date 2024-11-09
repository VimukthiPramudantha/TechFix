using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Supplier
{
    public partial class CategoryProducts : System.Web.UI.Page
    {
        CategoryWebServiceReferance.CategoryWebServiceSoapClient categoryService = new CategoryWebServiceReferance.CategoryWebServiceSoapClient();
        ProductServiceReference.ProductServiceSoapClient productService = new ProductServiceReference.ProductServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        // Method to load categories into the dropdown
        private void LoadCategories()
        {
            DataTable categories = categoryService.GetCategories();
            if (categories != null)
            {
                ddlCategory.DataSource = categories;
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryId";
                ddlCategory.DataBind();
            }

            ddlCategory.Items.Insert(0, new ListItem("-- Select Category --", "0"));
        }

        // Event handler for category selection
        protected void ddlCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedCategoryId = Convert.ToInt32(ddlCategory.SelectedValue);

            if (selectedCategoryId > 0)
            {
                LoadProductsByCategory(selectedCategoryId);
            }
            else
            {
                gvProducts.DataSource = null;
                gvProducts.DataBind();
            }
        }

        // Method to load products by category
        private void LoadProductsByCategory(int categoryId)
        {
            DataTable products = productService.GetProductsByCategory(categoryId);
            if (products != null && products.Rows.Count > 0)
            {
                gvProducts.DataSource = products;
                gvProducts.DataBind();
            }
            else
            {
                gvProducts.DataSource = null;
                gvProducts.DataBind();
                lblMessage.Text = "No products found for the selected category.";
            }
        }

        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Example of handling the selected row
            int index = gvProducts.SelectedIndex;
            GridViewRow selectedRow = gvProducts.Rows[index];
            string selectedProductName = selectedRow.Cells[0].Text; // Assuming ProductName is in the first column

            lblMessage.Text = "Selected Product: " + selectedProductName;
        }
    }
}