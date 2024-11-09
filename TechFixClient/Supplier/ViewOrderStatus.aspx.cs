using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TechFixClient.Supplier
{
    public partial class ViewOrderStatus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadOrderStatus();
            }
        }

        private void LoadOrderStatus()
        {
            // Assume SupplierId is available (e.g., from session)
            int supplierId = Convert.ToInt32(Session["SupplierId"]);

            // Initialize the web service
            OrderServiceReference.OrderServiceSoapClient service = new OrderServiceReference.OrderServiceSoapClient();
            DataSet ds = service.GetOrdersBySupplier(supplierId);

            if (ds.Tables.Count > 0)
            {
                gvOrders.DataSource = ds;
                gvOrders.DataBind();
            }
        }
    }
}