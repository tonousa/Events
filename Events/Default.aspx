﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Events.Default" %>
<%@ Register TagPrefix="Events" TagName="Counter" Src="~/ViewCounter.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th, td { border: thin solid black; text-align:left;
                 padding: 3px; width: 120px
        }
        table {border-collapse: collapse;}
    </style>
</head>
<body>
    <Events:Counter id="counter" runat="server" OnCount="HandleEvent"></Events:Counter>

    <form id="form1" runat="server">
    <div>
        <h2><%: Application["message"] %></h2>
        <table id="eventTable">
            <tr>
                <th>Source</th><th>Type</th>
            </tr>
            <asp:Repeater SelectMethod="GetEvents" ItemType="Events.EventDescription" 
                runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.Source %></td>
                        <td><%#: Item.Type %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
    </form>
</body>
</html>
