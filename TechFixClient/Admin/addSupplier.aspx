<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addSupplier.aspx.cs" Inherits="TechFixClient.Admin.addSupplier" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Supplier</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f2f2f2;
            margin: 0;
            padding: 0;
        }
        .form-container {
            max-width: 500px;
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
        .form-input {
            display: block;
            width: 100%;
            padding: 10px;
            margin: 10px 0;
            font-size: 16px;
            border-radius: 5px;
            border: 1px solid #ccc;
        }
        .form-button {
            display: block;
            width: 100%;
            padding: 10px;
            margin: 20px 0;
            font-size: 16px;
            color: #fff;
            background-color: #007bff;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }
        .form-button:hover {
            background-color: #0056b3;
        }
        .success-message {
            color: green;
            font-weight: bold;
            margin-top: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-container">
            <h1>Add Supplier</h1>

            <asp:TextBox ID="txtUserName" runat="server" placeholder="User Name" CssClass="form-input" required="true"></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" placeholder="Email" CssClass="form-input" required="true" type="email"></asp:TextBox>
            <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" CssClass="form-input" required="true" TextMode="Password"></asp:TextBox>
            <asp:TextBox ID="txtContactNo" runat="server" placeholder="Contact Number" CssClass="form-input" required="true"></asp:TextBox>

            <asp:Button ID="btnSaveSupplier" runat="server" Text="Save Supplier" CssClass="form-button" OnClick="btnSaveSupplier_Click" />

            <!-- Success message label -->
            <asp:Label ID="lblSuccessMessage" runat="server" CssClass="success-message" Visible="false"></asp:Label>
        </div>
    </form>
</body>
</html>
