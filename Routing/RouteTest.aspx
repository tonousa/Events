<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RouteTest.aspx.cs" Inherits="Routing.RouteTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div class="routeTest">
        <h3>Route Test</h3>
        <table>
            <thead>
                <tr>
                    <th>Match</th><th>Route</th><th>Values</th>
                </tr>
            </thead>
            <tbody>
                <asp:Repeater ItemType="Routing.RouteMatchInfo" 
                     SelectMethod="GetRouteMatches" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%# Item.matches %></td>
                        <td><%# Item.path %></td>
                        <td><%# Item.values %></td>
                    </tr>
                </ItemTemplate>
                </asp:Repeater>
            </tbody>
        </table>
    </div>
</body>
</html>
