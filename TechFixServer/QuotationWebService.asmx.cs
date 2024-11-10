using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Configuration;

namespace TechFixServer
{
    /// <summary>
    /// Summary description for QuotationWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class QuotationWebService : System.Web.Services.WebService
    {
        
        private readonly string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        [WebMethod]
        public DataTable GetQuotationsByProduct(int productId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT quotationId, productId, categoryId, status FROM Quotations WHERE productId = @ProductId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ProductId", productId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable quotationsTable = new DataTable();
                adapter.Fill(quotationsTable);

                return quotationsTable;
            }
        }

        [WebMethod]
        public bool SaveQuotationResponse(int quotationId, int userId, int quantity, decimal price, string response)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO QuotationResponse (quotationId, userId, quantity, price, response) VALUES (@QuotationId, @UserId, @Quantity, @Price, @Response)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@QuotationId", quotationId);
                cmd.Parameters.AddWithValue("@UserId", userId);
                cmd.Parameters.AddWithValue("@Quantity", quantity);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@Response", response);

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
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
            catch (Exception ex)
            {
                return null;
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

                dt.TableName = "Product";
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        [WebMethod]
        public bool PlaceQuotation(int productId, int categoryId, int quantity)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Quotations (ProductId, CategoryId, Status, Quantity) VALUES (@ProductId, @CategoryId, 'open', @Quantity)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProductId", productId);
                        cmd.Parameters.AddWithValue("@CategoryId", categoryId);
                        cmd.Parameters.AddWithValue("@Quantity", quantity);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        [WebMethod]
        public DataTable GetAllQuotations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT Q.quotationId, P.productName, Q.quantity
                    FROM Quotations Q
                    JOIN Product P ON Q.productId = P.productId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable("quotations");
                adapter.Fill(dt);
                return dt;
            }
        }

        [WebMethod]
        public string RespondToQuotation(int quotationId, decimal price, int userId)
        {
            if (quotationId <= 0 || price <= 0)
            {
                return "Invalid quotation ID or price.";
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = @"
                INSERT INTO QuotationResponse (quotationId,userId, price, response) 
                VALUES (@quotationId,@userId, @price, 'accept')";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@quotationId", quotationId);
                        cmd.Parameters.AddWithValue("@price", price);
                        cmd.Parameters.AddWithValue("@userId", userId);

                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return "Quotation responded successfully!";
                        }
                        else
                        {
                            return "Failed to respond to quotation.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "An error occurred: " + ex.Message;
                }
            }
        }
        [WebMethod]
        public DataTable GetAllQuotationResponses()
        {
            DataTable dt = new DataTable();

            try
            {
                // Ensure the connection string is configured correctly
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("Connection string is missing or empty.");
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
    q.quotationId AS QuotationID,
    p.productName AS ProductName,
    q.Quantity AS Quantity,
    COALESCE(qr.price, 0) AS ResponsePrice,
    COALESCE(qr.response, 'No Response') AS ResponseMessage,
    u.userName AS SupplierName
FROM Quotations q
LEFT JOIN QuotationResponse qr ON q.quotationId = qr.quotationId
LEFT JOIN Product p ON q.productId = p.productId
LEFT JOIN [User] u ON qr.userId = u.userId AND u.role = 'Supplier'
ORDER BY q.quotationId;";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Open the connection
                        conn.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                // If no rows are returned, handle it gracefully
                if (dt == null || dt.Rows.Count == 0)
                {
                    throw new Exception("No data found in Quotations responses table.");
                }
            }
            catch (SqlException sqlEx)
            {
                // Return detailed SQL error
                throw new Exception("Database error: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                // Return general error message
                throw new Exception("An error occurred: " + ex.Message);
            }
            dt.TableName = "Quotation";
            // Return the DataTable with the results
            return dt;
        }

        [WebMethod]
        public DataTable GetSupplierQuotations(int userId)
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                q.quotationId AS QuotationID,
                p.productName AS ProductName,
                q.quantity AS Quantity,
                qr.price AS ResponsePrice
            FROM Quotations q
            JOIN QuotationResponse qr ON q.quotationId = qr.quotationId
            JOIN Product p ON q.productId = p.productId
            WHERE qr.userId = @UserId
            ORDER BY q.quotationId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }

                dt.TableName = "SupplierQuotations";
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred: " + ex.Message);
            }

            return dt;
        }

    }
}
