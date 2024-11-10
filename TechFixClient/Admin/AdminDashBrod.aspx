<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminDashBrod.aspx.cs" Inherits="TechFixClient.Admin.AdminDashBrod" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<title>TechFix Admin Dashboard</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }
        .dashboard-container {
            max-width: 600px;
            margin: 50px auto;
            padding: 20px;
            background-color: #fff;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
            text-align: center;
            border-radius: 8px;
        }
        h1 {
            color: #333;
        }
        .dashboard-button {
            display: block;
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            font-size: 16px;
            color: #fff;
            background-color: #007bff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .dashboard-button:hover {
            background-color: #0056b3;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="dashboard-container">
            <h1>Admin Dashboard</h1>
            
            <asp:Button ID="btnCreateCategory" runat="server" Text="Create Category" CssClass="dashboard-button" OnClick="btnCreateCategory_Click" />
            <asp:Button ID="btnCreateProduct" runat="server" Text="Create Product" CssClass="dashboard-button" OnClick="btnCreateProduct_Click" />
            <asp:Button ID="btnPlaceQuotation" runat="server" Text="Place Quotation" CssClass="dashboard-button" OnClick="btnPlaceQuotation_Click" />
            <asp:Button ID="btnViewProducts" runat="server" Text="View Products" CssClass="dashboard-button" OnClick="btnViewProducts_Click" />
            <asp:Button ID="btnNewQuotations" runat="server" Text="View Quotations" CssClass="dashboard-button" OnClick="btnNewQuotations_Click" />
            <asp:Button ID="btnAddSupplier" runat="server" Text="Add Supplier" CssClass="dashboard-button" OnClick="btnAddSupplier_Click" />
            <asp:Button ID="btnLogout" runat="server" Text="Logout" CssClass="dashboard-button" OnClick="btnLogout_Click" />
        </div>
    </form>
</body>

</html>
