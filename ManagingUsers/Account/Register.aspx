﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="ManagingUsers.Account.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {
            margin-bottom: 20px;
        }

        label {
            display: inline-block;
            margin-right: 5px;
            width: 150px;
        }

        span.error {
            color: red;
            margin-bottom: 10px;
            display: block;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Create Account</h3>
        <asp:PlaceHolder runat="server" ID="error" Visible="false">
            <span id="message" class="error" runat="server"></span>
        </asp:PlaceHolder>
        <div>
            <label>Username:</label><input name="user" />
        </div>
        <div>
            <label>Email:</label><input name="email" />
        </div>
        <div>
            <label>Password:</label><input name="pass" />
        </div>
        <div>
            <label>Recovery Question:</label>
            <select name="question">
                <option>Month born?</option>
                <option>Favorite color?</option>
                <option>Pet name?</option>
            </select>
        </div>
        <div><label>Answer:</label><input name="answer" /></div>
        <div><button type="submit">Create Account</button></div>
    </form>
</body>
</html>
