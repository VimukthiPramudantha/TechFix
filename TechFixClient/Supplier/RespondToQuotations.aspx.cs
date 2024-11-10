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
            int userId = Convert.ToInt32(Session["userId"]);
            if (e.CommandName == "Respond")
            {
                int rowIndex = Convert.ToInt32(e.CommandArgument);

                if (rowIndex >= 0 && rowIndex < gvQuotations.Rows.Count)
                {
                    GridViewRow row = gvQuotations.Rows[rowIndex];

                    // Retrieve the Quotation ID from DataKeys
                    int quotationId = Convert.ToInt32(gvQuotations.DataKeys[rowIndex].Value);

                    // Find the TextBox and get the entered price
                    TextBox txtPrice = (TextBox)row.FindControl("txtPrice");
                    if (txtPrice != null && decimal.TryParse(txtPrice.Text, out decimal price))
                    {
                        // Initialize web service client to respond to the quotation
                        QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();
                        string result = service.RespondToQuotation(quotationId, price, userId);

                        // Display response message
                        lblMessage.Text = result;
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "Please enter a valid price.";
                    }
                }
                else
                {
                    lblMessage.Text = "Invalid row selected.";
                }
            }
        }

    }
}