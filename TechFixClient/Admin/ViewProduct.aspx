<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="TechFixClient.ViewProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Products</title>
    <style>
        .container {
            max-width: 800px;
            margin: auto;
            padding: 20px;
            font-family: Arial, sans-serif;
        }
        .title {
            font-size: 24px;
            margin-bottom: 20px;
            text-align: center;
        }
        .grid-view {
            width: 100%;
            border-collapse: collapse;
        }
        .grid-view th, .grid-view td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: left;
        }
        .grid-view th {
            background-color: #f4f4f4;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="title">Product List</div>
            <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="true" CssClass="grid-view"></asp:GridView>
        </div>
    </form>
</body>
</html>
