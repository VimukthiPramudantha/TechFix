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
    /// Summary description for OrderService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class OrderService : System.Web.Services.WebService
    {
        private string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public DataTable GetOrders()
        {
            DataTable orderTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Adjusted query to fetch data related to order without quantity and product
                string query = @"SELECT o.orderId, q.quotationId, q.status AS QuotationStatus, u.userId, u.userName, 
                                c.categoryName, p.productName
                                FROM [Order] o
                                JOIN Quotations q ON o.quotationId = q.quotationId
                                JOIN Product p ON q.productId = p.productId
                                JOIN Category c ON p.categoryId = c.categoryId
                                JOIN Users u ON o.userId = u.userId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(orderTable);
                }
            }

            return orderTable;
        }

        [WebMethod]
        public bool PlaceOrder(int quotationId, int userId, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // Insert into Order table with adjusted columns
                string query = "INSERT INTO [Order] (quotationId, userId, status) VALUES (@QuotationId, @UserId, @Status)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@QuotationId", quotationId);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
