﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormTwo.aspx.cs" Inherits="OtherControls.FormTwo" %>

<%@ PreviousPageType VirtualPath="~/FormOne.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; }</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Your name is: <%: PreviousPage.Name %>
    </div>
        <asp:Button runat="server" PostBackUrl="~/FormOne.aspx" Text="Back" />
    </form>
</body>
</html>
