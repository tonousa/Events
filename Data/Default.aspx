<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Data.Default" %>

<%@ Register TagPrefix="CC" Assembly="Data" Namespace="Data.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
        th, td { text-align: left;}
        td {padding-bottom: 5px;}
        th, table { border-bottom: solid thin black;}
        th:last-child, td:last-child {text-align:right; color:red;}
        body {font-family:"Arial Narrow", sans-serif;}
    </style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr><th>Name</th><th>Category</th><th>Price</th></tr>
                <asp:Repeater runat="server" ItemType="Data.Models.Product" 
                    SelectMethod="GetProductData">
                    <ItemTemplate>
                        <tr>
                            <td><%# Item.Name %></td>
                            <td><%# Item.Category %></td>
                            <td><%# Item.Price.ToString("F2") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>

        <div>
            Filter:
            <%--<select name="filterSelect">
                <asp:Repeater runat="server" ItemType="System.String" 
                    SelectMethod="GetCategories">
                    <ItemTemplate>
                        <option><%# Item %></option>
                    </ItemTemplate>
                </asp:Repeater>
            </select>--%>

            <%--<asp:DropDownList runat="server" ItemType="System.String" 
                SelectMethod="Getcategories" ID="ddList" />--%>

            <CC:DatatSelect id="dSelect" runat="server" SelectMethod="GetCategories"
                 ItemType="Data.Models.Product">
                <ItemTemplate>
                    <option><%# Item.Category %></option>
                </ItemTemplate>
            </CC:DatatSelect>

            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
