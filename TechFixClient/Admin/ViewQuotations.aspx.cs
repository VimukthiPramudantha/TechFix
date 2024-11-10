using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class ViewQuotations : System.Web.UI.Page
    {
        QuotationService.QuotationWebServiceSoapClient service = new QuotationService.QuotationWebServiceSoapClient();
        private int userId = 1; // Example user ID, replace with actual logged-in user ID


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuotationsResponses();
            }
        }

        private void LoadQuotationsResponses()
        {
            try
            {
                
                DataTable dt = service.GetAllQuotationResponses();

                if (dt != null && dt.Rows.Count > 0)
                {
                    gvQuotationResponses.DataSource = dt;
                    gvQuotationResponses.DataBind();
                    lblMessage.Text = string.Empty;
                }
                else
                {
                    lblMessage.Text = "No quotation responses available.";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred while loading quotations: " + ex.Message;
            }
        }
    }
}