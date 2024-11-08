using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace TechFixClient.Admin
{
    public partial class CreateProduct : System.Web.UI.Page
    {
        CategoryWebServiceReferance.CategoryWebServiceSoapClient categoryService;
        ProductServiceReference.ProductServiceSoapClient productService;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Initialize service clients
            categoryService = new CategoryWebServiceReferance.CategoryWebServiceSoapClient();
            productService = new ProductServiceReference.ProductServiceSoapClient();

            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        // Method to load categories from the Category Web Service
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

        protected void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (ddlCategory.SelectedValue == "0")
            {
                lblMessage.Text = "Please select a category.";
                return;
            }

            string productName = txtProductName.Text.Trim();

            if (string.IsNullOrEmpty(productName))
            {
                lblMessage.Text = "Please enter a product name.";
                return;
            }

            int categoryId = Convert.ToInt32(ddlCategory.SelectedValue);
            bool isAdded = productService.AddProduct(categoryId, productName);

            if (isAdded)
            {
                lblMessage.Text = "Product added successfully!";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                txtProductName.Text = "";
            }
            else
            {
                lblMessage.Text = "Failed to add product.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}