using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Supplier
{
    public partial class RespondToQuotations : System.Web.UI.Page
    {
        string connectionString = "Server=localhost;Database=TechFix;Integrated Security=True;";

        private string connectionStrin = ConfigurationManager.ConnectionStrings["TechFixConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuotations();
            }
        }

        // Method to load quotations with product names
        private void LoadQuotations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT Q.quotationId, P.productName, Q.quantity 
                FROM Quotations Q
                JOIN Products P ON Q.productId = P.productId";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                gvQuotations.DataSource = dt;
                gvQuotations.DataBind();
            }
        }

        // Event handler for GridView button click
        protected void gvQuotations_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Respond")
            {
                int quotationId = Convert.ToInt32(e.CommandArgument);

                // Find the GridView row where the button was clicked
                GridViewRow row = ((Button)e.CommandSource).NamingContainer as GridViewRow;
                TextBox txtPrice = (TextBox)row.FindControl("txtPrice");

                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    // Insert the response into the database
                    AddQuotationResponse(quotationId, price);

                    lblMessage.Text = "Quotation responded successfully!";
                }
                else
                {
                    lblMessage.Text = "Please enter a valid price.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        // Method to save response to the database
        private void AddQuotationResponse(int quotationId, decimal price)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO QuotationResponse (quotationId, price) VALUES (@quotationId, @price)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@quotationId", quotationId);
                cmd.Parameters.AddWithValue("@price", price);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}