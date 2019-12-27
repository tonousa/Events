<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterButtons.aspx.cs" Inherits="WorkingWithControls.RepeaterButtons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #buttonTarget > input {margin: 10px 5px 0 0;}
        #selectedValue { margin-top: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="buttonTarget" runat="server">
        <asp:Repeater ItemType="System.String" SelectMethod="GetButtonDetails" 
            runat="server" OnItemCommand="HandleClick">
            <ItemTemplate>
                <asp:Button Text="<%# Item %>" runat="server" />
            </ItemTemplate>
        </asp:Repeater>
    </div>
        <div runat="server" id="selectedValue"></div>
    </form>
</body>
</html>
