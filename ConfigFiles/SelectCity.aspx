<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SelectCity.aspx.cs" Inherits="ConfigFiles.SelectCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <label>Pick a city:</label>
    <select>
        <asp:Repeater ID="repeater1" runat="server" SelectMethod="GetPlaces" 
             ItemType="ConfigFiles.Place">
            <ItemTemplate>
                <option value="<%# Item.Code %>"><%# Item.City %></option>,
                    <%# Item.Country %></option>
            </ItemTemplate>
        </asp:Repeater>
    </select>
</body>
</html>
