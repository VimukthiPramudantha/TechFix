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
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Query to fetch order details from the Order table
                string query = "SELECT orderId, quotationId, userId, status FROM [Order]";
                SqlCommand cmd = new SqlCommand(query, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable ordersTable = new DataTable("Orders");
                adapter.Fill(ordersTable);

                return ordersTable;
            }
        
    }
        [WebMethod]
        public DataSet GetOrdersBySupplier(int supplierId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        Q.quotationId, 
                        P.productName, 
                        Q.quantity, 
                        R.price
                    FROM 
                        Quotations Q
                    INNER JOIN 
                        Product P ON Q.productId = P.productId
                    INNER JOIN 
                        QuotationResponse R ON Q.quotationId = R.quotationId
                    WHERE 
                        R.userId = @SupplierId";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SupplierId", supplierId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
        }
    }
}
