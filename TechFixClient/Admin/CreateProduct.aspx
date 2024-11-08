<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="TechFixClient.Admin.CreateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create New Product</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container mt-5">
        <h2>Create New Product</h2>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        <div class="form-group">
            <label>Select Category:</label>
            <asp:DropDownList ID="ddlCategory" runat="server" CssClass="form-control">
                <asp:ListItem Text="-- Select Category --" Value="0"></asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group">
            <label>Product Name:</label>
            <asp:TextBox ID="txtProductName" runat="server" CssClass="form-control" placeholder="Enter product name"></asp:TextBox>
        </div>

        <asp:Button ID="btnCreateProduct" runat="server" Text="Add Product" CssClass="btn btn-primary" OnClick="btnCreateProduct_Click" />
    </div>
        </form>
</body>
</html>
