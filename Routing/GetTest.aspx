<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetTest.aspx.cs" Inherits="Routing.GetTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" action="/methodtest" method="post">
        <p>This is GetTest.aspx</p>
        <p>City: <input name="city" /></p>
        <p><button type="submit">Post request</button></p>
    </form>
</body>
</html>
