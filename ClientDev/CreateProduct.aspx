<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="ClientDev.CreateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th {text-align:left;}
        td[colspan="2"] {text-align: center; padding: 10px 0;}
        .error {color:red;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server" CssClass="error" />
        <table>
            <tr>
                <td>Name:</td>
                <td><input id="Name" runat="server" /></td>
            </tr>
            <tr>
                <td>Category:</td>
                <td><input id="Category" runat="server" /></td>
            </tr>
            <tr>
                <td>Price:</td>
                <td><input id="Price" runat="server" /></td>
            </tr>

            <tr><td colspan="2"><button type="submit">Create</button></td></tr>

            <tr><th>ID</th><th>Name</th><th>Category</th><th>Price</th></tr>
            <asp:Repeater runat="server" 
                ItemType="ClientDev.Models.Product" SelectMethod="GetCreated">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.ProductID %></td>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Category %></td>
                        <td><%#: Item.Price.ToString("F2") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </table>
    </form>
</body>
</html>
