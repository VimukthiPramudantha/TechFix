using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient
{
    public partial class ViewProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadProducts();
            }
        }

        private void LoadProducts()
        {
            // Create an instance of the ProductService web service
            ProductServiceReference.ProductServiceSoapClient productService = new ProductServiceReference.ProductServiceSoapClient();

            // Call the GetProducts method to retrieve product data
            DataTable productsTable = productService.GetProducts();

            // Bind the data to the GridView
            gvProducts.DataSource = productsTable;
            gvProducts.DataBind();
        }
    }
}