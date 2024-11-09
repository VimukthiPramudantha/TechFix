using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TechFixServer
{
    /// <summary>
    /// Summary description for CategoryWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CategoryWebService : System.Web.Services.WebService
    {
        string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public bool AddCategory(string categoryName)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Category (CategoryName) VALUES (@CategoryName)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@CategoryName", categoryName);
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
        public DataTable GetCategories()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT CategoryId, CategoryName FROM Category";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
                dt.TableName = "Categories";
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
    }
}
