using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Admin
{
    public partial class ViewOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOrderData();
            }
        }

        private void LoadOrderData()
        {
            OrderServiceReference.OrderServiceSoapClient orderService = new OrderServiceReference.OrderServiceSoapClient();
            DataTable orderTable = orderService.GetOrders();
            OrderGridView.DataSource = orderTable;
            OrderGridView.DataBind();
        }

        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            int sampleQuotationId = 1; // Adjust with actual ID you want to place an order for
            int sampleUserId = 1;      // Adjust with the actual user ID
            string sampleStatus = "Pending";

            OrderServiceReference.OrderServiceSoapClient orderService = new OrderServiceReference.OrderServiceSoapClient();
            bool isOrderPlaced = orderService.PlaceOrder(sampleQuotationId, sampleUserId, sampleStatus);

            if (isOrderPlaced)
            {
                Response.Write("<script>alert('Order has been placed successfully!');</script>");
            }
            else
            {
                Response.Write("<script>alert('Failed to place the order.');</script>");
            }
        }
    }
   }