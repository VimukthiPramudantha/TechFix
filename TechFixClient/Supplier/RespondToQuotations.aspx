<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RespondToQuotations.aspx.cs" Inherits="TechFixClient.Supplier.RespondToQuotations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Respond to Quotations</title>
    <style>
        /* General Styling */
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

        table, th, td {
            border: 1px solid #ddd;
        }

        th, td {
            padding: 15px;
            text-align: center;
        }

        th {
            background-color: #007bff;
            color: #fff;
        }

        .btn {
            background-color: #28a745;
            color: white;
            border: none;
            padding: 8px 15px;
            border-radius: 5px;
            cursor: pointer;
            transition: background-color 0.3s ease;
        }

        .btn:hover {
            background-color: #218838;
        }

        .text-box {
            width: 80px;
            padding: 5px;
            text-align: center;
        }

        .message {
            margin-top: 20px;
            text-align: center;
            color: green;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Respond to Quotations</h2>
            <asp:GridView ID="gvQuotations" runat="server" AutoGenerateColumns="False" DataKeyNames="quotationId" OnRowCommand="gvQuotations_RowCommand">
                <Columns>
                    <asp:BoundField DataField="quotationId" HeaderText="Quotation ID" />
                    <asp:BoundField DataField="productName" HeaderText="Product Name" />
                    <asp:BoundField DataField="quantity" HeaderText="Quantity" />
                    <asp:TemplateField HeaderText="Your Price">
                        <ItemTemplate>
                            <asp:TextBox ID="txtPrice" runat="server" CssClass="text-box"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnRespond" runat="server" Text="Submit Response" CommandName="Respond" CommandArgument='<%# Container.DataItemIndex %>' CssClass="btn" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="lblMessage" runat="server" CssClass="message" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
