<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CityAndColor.aspx.cs" Inherits="State.CityAndColor" EnableSessionState="True" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="section">
            Select a color:
            <asp:DropDownList ID="colorSelect" runat="server" ItemType="System.String" 
                 SelectMethod="GetColors"></asp:DropDownList>
        </div>
        <div class="section">
            Select a city:
            <asp:DropDownList ID="citySelect" runat="server" ItemType="System.String" 
                 SelectMethod="GetCities"></asp:DropDownList>
        </div>
        <div class="section">
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
