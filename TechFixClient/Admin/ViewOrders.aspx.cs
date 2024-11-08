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
                    LoadOrders();
                }
            }

            private void LoadOrders()
            {
            OrderServiceReference.OrderServiceSoapClient service = new OrderServiceReference.OrderServiceSoapClient();
                DataTable ordersTable = service.GetOrders();

                gvOrders.DataSource = ordersTable;
                gvOrders.DataBind();
            }

            protected void btnPlaceOrder_Click(object sender, EventArgs e)
            {
               
                Response.Write("<script>alert('Place Order functionality to be implemented');</script>");
            }
        }
    }
    