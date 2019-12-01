<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ManagingUsers.Account.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div.details {margin-bottom: 20px;}
        div {margin-top: 5px;}
        label {display: inline-block; width: 90px; }
        button {margin: 10px 10px 0 0 ;}
    </style>
</head>
<body>
    <div class="details">The request is authenticated: <%: GetRequestStatus() %></div>
    <div class="details">The current user is: <%: GetUser() %></div>
    <form id="form1" runat="server">
        <div><label>User:</label><input name="user" /></div>
        <div><label>Password:</label><input name="pass" type="password" /></div>
        <div>
            <button name="action" value="login" type="submit">Log In</button>
            <button name="action" value="logout" type="submit">Log Out</button>
        </div>
    </form>
</body>
</html>
