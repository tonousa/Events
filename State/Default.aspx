<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="State.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .nameContainer { margin: 10px 0;}
        input {margin-right: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <%--<div>
        This page has been displayed <%: GetUserCounter() %> times for the user
        and <%: GetSessionCounter() %> times for this session.
    </div>

    <div class="nameContainer">
        <input id="requestedUser" value="Joe" runat="server" />
        <button type="submit">Submit</button>
    </div>--%>

    <div>
        This page has been displayed <%: GetCounter() %> times
    </div>
    <button type="submit">Submit</button>

    </form>
</body>
</html>
