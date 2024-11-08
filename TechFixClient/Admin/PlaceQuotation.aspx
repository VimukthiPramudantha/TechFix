<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceQuotation.aspx.cs" Inherits="TechFixClient.Admin.PlaceQuotation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Place Quotation</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 30px;
        }
        .container {
            max-width: 500px;
            margin: 0 auto;
            padding: 20px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
        }
        .form-group {
            margin-bottom: 20px;
        }
        .form-group label {
            display: block;
            margin-bottom: 8px;
        }
        .form-group select {
            width: 100%;
            padding: 8px;
            font-size: 14px;
        }
        .btn {
            display: inline-block;
            padding: 10px 20px;
            background-color: #007bff;
            color: white;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }
        .btn:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
      <form id="form1" runat="server">
    <div class="container">
    <h2>Place Quotation</h2>
    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

    <div class="form-group">
        <label for="ddlCategory">Select Category:</label>
        <asp:DropDownList ID="ddlCategory" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged">
            <asp:ListItem Text="-- Select Category --" Value="0"></asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="ddlProduct">Select Product:</label>
        <asp:DropDownList ID="ddlProduct" runat="server">
            <asp:ListItem Text="-- Select Product --" Value="0"></asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="form-group">
        <label for="txtQuantity">Enter Quantity:</label>
        <asp:TextBox ID="txtQuantity" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <asp:Button ID="btnPlaceQuotation" runat="server" Text="Place Quotation" CssClass="btn btn-primary" OnClick="btnPlaceQuotation_Click" />
</div>
</form>
</body>
</html>
