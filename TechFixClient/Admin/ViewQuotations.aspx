<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewQuotations.aspx.cs" Inherits="TechFixClient.Admin.ViewQuotations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Quotation Responses</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            padding: 20px;
        }

        .container {
            max-width: 1000px;
            margin: 0 auto;
            background-color: #fff;
            padding: 20px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
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
            padding: 12px;
            border: 1px solid #ddd;
            text-align: center;
        }

        th {
            background-color: #007bff;
            color: #fff;
        }

        .message {
            margin-top: 20px;
            text-align: center;
            color: red;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>All Quotation Responses</h2>
            <asp:GridView ID="gvQuotationResponses" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="QuotationID" HeaderText="Quotation ID" />
                    <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="ResponsePrice" HeaderText="Response Price" />
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
