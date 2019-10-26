<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicFailure.aspx.cs" Inherits="ErrorHandling.DynamicFailure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>something has gone wrong</p>
        <p><a href="<%: Request["aspxerrorpath"] %>">Try again</a></p>
    </div>
    </form>
</body>
</html>
