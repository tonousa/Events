<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentError.aspx.cs" Inherits="ErrorHandling.ComponentError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>something has gone wrong with 
            <span><%:Request["errorSource"] %></span></p>
        <p>The error was a <span><%:Request["errorType"] %></span></p>
        <p><a href="Default.aspx">Try again</a></p>
    </div>
    </form>
</body>
</html>
