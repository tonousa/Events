<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayItemValue.aspx.cs" Inherits="AsyncApp.DisplayItemValue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        The length of the result is: <%: Context.Items["length"] %>
    </div>
    </form>
</body>
</html>
