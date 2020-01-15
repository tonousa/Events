<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormView.aspx.cs" Inherits="Data.FormView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:FormView runat="server" ID="formView" CssClass="formViewTable" RenderOuterTable="true" 
            ItemType="Data.Models.Product" SelectMethod="GetProducts" AllowPaging="true"
            InsertMethod="InsertProduct" UpdateMethod="UpdateProduct" 
            DeleteMethod="DeleteProduct" DataKeyNames="ProductID">

        <ItemTemplate>
            <table class="formViewTable innerTable">
                <tr><th>ID:</th><td><%# Item.ProductID %></td></tr>
                <tr><th>name:</th><td><%# Item.Name %></td></tr>
                <tr><th>Category:</th><td><%# Item.Category %></td></tr>
                <tr><th>Price:</th><td><%# Item.Price %></td></tr>
            </table>
        </ItemTemplate>

        <PagerTemplate>
            <asp:Button runat="server" CommandName="Page" CommandArgument="First" Text="First" />
            <asp:Button runat="server" CommandName="Page" CommandArgument="Prev" Text="Prev" />
            <%= formView.PageIndex %> of <%= formView.PageCount %>
            <asp:Button runat="server" CommandName="Page" CommandArgument="Next" Text="Next" />
            <asp:Button runat="server" CommandName="Page" CommandArgument="Last" Text="Last" />
        </PagerTemplate>


        <HeaderTemplate>
            <asp:Button runat="server" CommandName="New" Text="New" />
            <asp:Button runat="server" CommandName="Delete" Text="Delete" />
            <asp:Button runat="server" CommandName="Edit" Text="Edit" />
        </HeaderTemplate>

        <EditItemTemplate>
            <table class="formViewTable innerTable">
                <tr>
                    <th>Name:</th>
                    <td><input id="name" value="<%# BindItem.Name %>" runat="server"/></td>
                </tr>
                <tr>
                    <th>Category:</th>
                    <td><input id="category" value="<%# BindItem.Category %>" runat="server"/></td>
                </tr>
                <tr>
                    <th>Price:</th>
                    <td><input id="price" value="<%# BindItem.Price %>" runat="server"/></td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" CommandName="Update" Text="Update" 
                            Visible="<%# formView.CurrentMode == FormViewMode.Edit %>" />
                        <asp:Button runat="server" CommandName="Insert" Text="Insert" 
                            Visible="<%# formView.CurrentMode == FormViewMode.Insert %>" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </EditItemTemplate>
    </asp:FormView>
    </form>
</body>
</html>
