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
        [WebMethod]
        public bool AddProduct(int categoryId, string productName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Product (CategoryId, ProductName) VALUES (@CategoryId, @ProductName)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cmd.Parameters.AddWithValue("@ProductName", productName);
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if insert was successful
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        [WebMethod]
        public DataTable GetProductsByCategory(int categoryId)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT ProductId, ProductName FROM Product WHERE CategoryId = @CategoryId";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
                dt.TableName = "Products";
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
