<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TechFixClient.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div style="width: 300px; margin: 0 auto; padding: 20px;">
            <h2>Login</h2>
            <!-- Message Label for showing email after login -->
            <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
            <div>
                <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                <asp:TextBox ID="txtEmail" runat="server" Width="100%"></asp:TextBox>
            </div>
            <div style="margin-top: 10px;">
                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Width="100%"></asp:TextBox>
            </div>
            <div style="margin-top: 20px;">
                <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
