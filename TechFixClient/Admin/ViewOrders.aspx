<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrders.aspx.cs" Inherits="TechFixClient.Admin.ViewOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Orders</title>
    <style>
        .container {
            width: 80%;
            margin: 20px auto;
            font-family: Arial, sans-serif;
        }
        h2 {
            text-align: center;
            margin-bottom: 20px;
        }
        .order-grid {
            width: 100%;
            border-collapse: collapse;
            margin-bottom: 20px;
        }
        .order-grid th, .order-grid td {
            padding: 12px;
            border: 1px solid #ddd;
            text-align: left;
        }
        .order-grid th {
            background-color: #f2f2f2;
            font-weight: bold;
        }
        .btn-place-order {
            display: block;
            width: 200px;
            margin: 0 auto;
            padding: 10px;
            background-color: #4CAF50;
            color: white;
            text-align: center;
            font-size: 16px;
            border: none;
            cursor: pointer;
        }
        .btn-place-order:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Order Details</h2>
            <asp:GridView ID="OrderGridView" runat="server" CssClass="order-grid" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="orderId" HeaderText="Order ID" />
                    <asp:BoundField DataField="userName" HeaderText="User Name" />
                    <asp:BoundField DataField="productName" HeaderText="Product Name" />
                    <asp:BoundField DataField="categoryName" HeaderText="Category" />
                    <asp:BoundField DataField="QuotationStatus" HeaderText="Quotation Status" />
                </Columns>
            </asp:GridView>
            
            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order" CssClass="btn-place-order" OnClick="btnPlaceOrder_Click" />
        </div>
    </form>
</body>
</html>
