<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotFoundShared.aspx.cs" Inherits="ErrorHandling.NotFoundShared" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <p>something has gone wrong</p>
        <p>(You asked <span id="errorSrc" runat="server"></span>
            for: <span id="requestedUrl" runat="server"></span></p>
        <p><a href="Default.aspx">Try again</a></p>
    </div>
    </form>
</body>
</html>
