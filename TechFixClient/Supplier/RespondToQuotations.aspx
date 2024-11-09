<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RespondToQuotations.aspx.cs" Inherits="TechFixClient.Supplier.RespondToQuotations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Respond to Quotations</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 900px;
            margin: 30px auto;
            background-color: #fff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }
        h2 {
            text-align: center;
            color: #007bff;
        }
        .response-form {
            margin-top: 20px;
        }
        .response-form input[type="text"], .response-form input[type="number"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: 1px solid #ddd;
            border-radius: 5px;
        }
        .response-form input[type="submit"] {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            border-radius: 5px;
            transition: background-color 0.3s ease;
        }
        .response-form input[type="submit"]:hover {
            background-color: #0056b3;
        }
        .message {
            text-align: center;
            margin-top: 20px;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Respond to Quotations</h2>

            <asp:GridView ID="gvQuotations" runat="server" AutoGenerateColumns="False" OnRowCommand="gvQuotations_RowCommand" OnSelectedIndexChanged="gvQuotations_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="quotationId" HeaderText="Quotation ID" />
        <asp:BoundField DataField="productName" HeaderText="Product Name" />
        <asp:BoundField DataField="quantity" HeaderText="Quantity" />
        <asp:TemplateField HeaderText="Price">
            <ItemTemplate>
                <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button ID="btnRespond" runat="server" Text="Respond" CommandName="Respond" CommandArgument='<%# Eval("quotationId") %>' />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>

<asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>
