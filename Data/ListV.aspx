<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListV.aspx.cs" Inherits="Data.ListV" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListView runat="server" ItemType="Data.Models.Product" SelectMethod="GetProducts" 
            UpdateMethod="UpdateProduct" DataKeyNames="ProductID">

            <LayoutTemplate>
                <table class="listViewTable">
                    <tr>
                        <th>
                            <asp:LinkButton runat="server" Text="ProductID"
                                CommandName="Sort" CommandArgument="ProductID" /></th>
                        <th>
                            <asp:LinkButton runat="server" Text="Name" 
                                CommandName="Sort" CommandArgument="Name" />
                        </th>
                        <th>Category</th>
                        <th>
                            <asp:LinkButton runat="server" Text="Price" 
                                CommandName="Sort" CommandArgument="Price" />
                        </th>
                    </tr>
                    <tr id="itemPlaceHolder" runat="server"></tr>
                    <tr>
                        <td colspan="5">
                            <asp:DataPager runat="server" PageSize="4">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" 
                                        ShowFirstPageButton="true" ShowPreviousPageButton="true" 
                                        ShowNextPageButton="false" ShowLastPageButton="false" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" 
                                        ShowLastPageButton="true" ShowNextPageButton="true" 
                                        ShowFirstPageButton="false" ShowPreviousPageButton="false" />
                                </Fields>
                            </asp:DataPager>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>

            <ItemTemplate>
                <tr>
                    <td><%# Item.ProductID %></td>
                    <td><%# Item.Name %></td>
                    <td><%# Item.Category %></td>
                    <td class="price"><%# Item.Price.ToString("F2") %></td>
                    <td>
                        <asp:Button runat="server" CommandName="Edit" Text="Edit" />
                    </td>
                </tr>
            </ItemTemplate>

            <EditItemTemplate>
                <tr>
                    <td colspan="5" class="error">
                        <asp:ValidationSummary runat="server" DisplayMode="SingleParagraph" />
                    </td>
                </tr>
                <tr>
                    <td><%# Item.ProductID %></td>
                    <td><input id="name" runat="server" value="<%# BindItem.Name %>" /></td>
                    <td>
                        <input id="category" runat="server" value="<%# BindItem.Category %>" />
                    </td>
                    <td><input id="price" runat="server" value="<%# BindItem.Price %>" /></td>
                    <td>
                        <asp:Button runat="server" CommandName="Update" Text="Save" />
                        <asp:Button runat="server" CommandName="Cancel" Text="Cancel" />
                    </td>
                </tr>
            </EditItemTemplate>

        </asp:ListView>
    </form>
</body>
</html>
