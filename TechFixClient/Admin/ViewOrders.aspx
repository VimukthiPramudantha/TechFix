<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrders.aspx.cs" Inherits="TechFixClient.Admin.ViewOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Orders</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Order List</h2>
        <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="orderId" HeaderText="Order ID" />
                <asp:BoundField DataField="quotationId" HeaderText="Quotation ID" />
                <asp:BoundField DataField="userId" HeaderText="User ID" />
                <asp:BoundField DataField="status" HeaderText="Status" />
            </Columns>
        </asp:GridView>
        
        <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" OnClick="btnPlaceOrder_Click" />
    </form>
</body>
</html>
