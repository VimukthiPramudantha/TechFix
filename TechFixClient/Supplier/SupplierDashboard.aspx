<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SupplierDashboard.aspx.cs" Inherits="TechFixClient.Supplier.SupplierDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Supplier Dashboard</title>
    <style>
        /* General Styles */
        body {
            font-family: Arial, sans-serif;
            background-color: #f5f5f5;
            margin: 0;
            padding: 0;
        }

        .container {
            max-width: 600px;
            margin: 50px auto;
            background-color: #fff;
            padding: 30px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            border-radius: 8px;
            text-align: center;
        }

        h2 {
            color: #333;
            font-size: 28px;
            margin-bottom: 20px;
        }

        .welcome-message {
            font-size: 18px;
            color: #666;
            margin-bottom: 30px;
        }

        .dashboard-buttons {
            display: flex;
            flex-direction: column;
            gap: 20px;
        }

        .btn {
            background-color: #007bff;
            color: white;
            border: none;
            padding: 15px;
            font-size: 18px;
            cursor: pointer;
            border-radius: 5px;
            transition: background-color 0.3s ease, transform 0.2s ease;
            text-align: center;
        }

        .btn:hover {
            background-color: #0056b3;
            transform: translateY(-2px);
        }

        .btn:active {
            background-color: #003d7a;
        }

        .btn-logout {
            background-color: #dc3545;
        }

        .btn-logout:hover {
            background-color: #c82333;
        }

        /* Responsive Design */
        @media (max-width: 768px) {
            .container {
                padding: 20px;
            }

            .btn {
                font-size: 16px;
                padding: 12px;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Supplier Dashboard</h2>           

            <!-- Dashboard Buttons -->
            <div class="dashboard-buttons">
                <asp:Button ID="btnCategoryProducts" runat="server" CssClass="btn" Text="Category & Products" OnClick="btnCategoryProducts_Click" />
                <asp:Button ID="btnResponseQuotations" runat="server" CssClass="btn" Text="Respond to Quotations" OnClick="btnResponseQuotations_Click" />
                <asp:Button ID="btnOrderStatus" runat="server" CssClass="btn" Text="View Order Status" OnClick="btnOrderStatus_Click" />
                <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-logout" Text="Logout" OnClick="btnLogout_Click" />
            </div>
        </div>
    </form>
</body>
</html>
