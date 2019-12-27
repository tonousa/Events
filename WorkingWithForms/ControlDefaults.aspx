﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlDefaults.aspx.cs" Inherits="WorkingWithForms.ControlDefaults" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script>
        var clientIDs = {
            textId: "#<%: text.ClientID %>",
            buttonId: "#<%: button.ClientID %>",
            formId: "#<%: form1.ClientID %>"
        };

        $(document).ready(function () {
            $(clientIDs.textId).focus();
            $(clientIDs.formId).keypress(function () {
                $(clientIDs.buttonId).click();
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="text" runat="server">
        </asp:TextBox>
        <asp:Button ID="button" runat="server" Text="Submit" />
        <asp:Button ID="otherButton" runat="server"  Text="Cancel" />
    </form>
</body>
</html>
