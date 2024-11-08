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
                DataTable ordersTable = new DataTable();
                adapter.Fill(ordersTable);

                return ordersTable;
            }
        
    }
    }
}
