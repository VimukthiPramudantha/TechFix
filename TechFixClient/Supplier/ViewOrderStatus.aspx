<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewOrderStatus.aspx.cs" Inherits="TechFixClient.Supplier.ViewOrderStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Order Status</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f7f7f7;
            padding: 20px;
        }

        .container {
            max-width: 900px;
            margin: 0 auto;
            background-color: #fff;
            padding: 30px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 10px;
        }

        h2 {
            text-align: center;
            color: #333;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            margin-top: 20px;
        }

        th, td {
            padding: 15px;
            text-align: center;
            border: 1px solid #ddd;
        }

        th {
            background-color: #007bff;
            color: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Order Status</h2>
            <asp:GridView ID="gvOrders" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="quotationId" HeaderText="Quotation ID" />
                    <asp:BoundField DataField="productName" HeaderText="Product Name" />
                    <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="price" HeaderText="Price" DataFormatString="{0:C}" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
