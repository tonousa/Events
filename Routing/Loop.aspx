<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loop.aspx.cs" Inherits="Routing.Loop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>Loop.aspx</p>
    <ul>
        <asp:Repeater ID="Repeater1" ItemType="System.Int32" SelectMethod="getValues" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</body>
</html>
