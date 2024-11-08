<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewQuotations.aspx.cs" Inherits="TechFixClient.Admin.ViewQuotations" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Manage Quotations</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Quotation Management</h2>

        <asp:Label ID="lblProduct" runat="server" Text="Select Product: " />
        <asp:DropDownList ID="ddlProducts" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProducts_SelectedIndexChanged">
        </asp:DropDownList>

        <asp:GridView ID="gvQuotations" runat="server" AutoGenerateColumns="False" Visible="False">
            <Columns>
                <asp:BoundField DataField="quotationId" HeaderText="Quotation ID" />
                <asp:BoundField DataField="categoryId" HeaderText="Category ID" />
                <asp:BoundField DataField="status" HeaderText="Status" />
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="btnAccept" runat="server" Text="Accept" CommandArgument='<%# Eval("quotationId") %>' OnClick="btnAccept_Click" />
                        <asp:Button ID="btnDecline" runat="server" Text="Decline" CommandArgument='<%# Eval("quotationId") %>' OnClick="btnDecline_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
