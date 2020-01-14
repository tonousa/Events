<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Repeat.aspx.cs" Inherits="Data.Repeat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
        <asp:Repeater runat="server" ID="rep"
                ItemType="Data.Models.Product" SelectMethod="GetProducts">
            <HeaderTemplate>
                <table>
                    <tr><th>Name</th><th>Category</th><th>Price</th></tr>
            </HeaderTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
            <%--<ItemTemplate>
                <tr>
                    <td><%# Item.Name %></td>
                    <td><%# Item.Category %></td>
                    <td><%# Item.Price.ToString("F2") %></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                <tr class="alternate">
                    <td><%# Item.Name %></td>
                    <td><%# Item.Category %></td>
                    <td><%# Item.Price.ToString("F2") %></td>
                </tr>
            </AlternatingItemTemplate>--%>
        </asp:Repeater>
</body>
</html>
