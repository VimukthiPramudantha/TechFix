<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCategory.aspx.cs" Inherits="TechFixClient.Admin.CreateCategory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create New Category</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container mt-5">
        <h2>Create New Category</h2>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>

        <div class="form-group">
            <label>Category Name:</label>
            <asp:TextBox ID="txtCategoryName" runat="server" CssClass="form-control" placeholder="Enter category name"></asp:TextBox>
        </div>

        <asp:Button ID="btnCreateCategory" runat="server" Text="Add Category" CssClass="btn btn-primary" OnClick="btnCreateCategory_Click" />
    </div>
        </form>
</body>
</html>
