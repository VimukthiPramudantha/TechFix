using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Services;

namespace TechFixServer
{
    /// <summary>
    /// Summary description for ProductService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ProductService : System.Web.Services.WebService
    {
        string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public DataTable GetProducts()
        {
            // Connection string from Web.config
            
            DataTable productsTable = new DataTable("Products");

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // SQL Query to fetch product and category data
                string query = @"SELECT p.ProductName, c.CategoryName
                                 FROM Product p
                                 INNER JOIN Category c ON p.CategoryId = c.CategoryId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(productsTable); // Fill the DataTable with data
                }
            }

            return productsTable; // Return DataTable
        }
    }
}
