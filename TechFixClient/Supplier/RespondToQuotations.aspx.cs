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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuotations();
            }
        }

        private void LoadQuotations()
        {
            // Initialize web service client
            QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();
            
            // Fetch quotations data from the service
            DataTable ds = service.GetAllQuotations();
            
            if (ds.Rows.Count > 0)
            {
                gvQuotations.DataSource = ds;
                gvQuotations.DataBind();
            }
        }

        protected void gvQuotations_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Respond")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);
                GridViewRow row = gvQuotations.Rows[rowIndex];

                // Get Quotation ID
                int quotationId = Convert.ToInt32(gvQuotations.DataKeys[rowIndex].Value);

                // Get the supplier's price from the TextBox
                TextBox txtPrice = (TextBox)row.FindControl("txtPrice");
                if (decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    // Send the response using the web service
                    QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();
                    string result = service.RespondToQuotation(quotationId, price);

                    // Display success message
                    lblMessage.Text = result;
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lblMessage.Text = "Please enter a valid price.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}