<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListModules.aspx.cs" Inherits="Events.ListModules" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th, td {border-bottom:thin solid black; text-align:left; padding:3px;}
        td span {display: inline-block; text-overflow:ellipsis; overflow:hidden; width: 300px;}
        table {border-collapse: collapse;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr><th>Name</th><th>Type</th></tr>
            <asp:Repeater ItemType="Events.ModuleDescription" ID="repeater1" 
                SelectMethod="GetModules" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><span><%#: Item.Name %></span></td>
                        <td><span><%#: Item.TypeName %></span></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
