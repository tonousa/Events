<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change.aspx.cs" Inherits="ManagingUsers.Account.Change" %>

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
    <div>
        <h3>Change Password</h3>
        <asp:PlaceHolder runat="server" ID="error" Visible="false">
            <span id="message" class="error" runat="server"></span>
        </asp:PlaceHolder>

        <asp:PlaceHolder runat="server" ID="usernamePh" Visible="true">
            <div>
                <label>Username:</label>
                <input id="user" name="user" runat="server" />
            </div>
        </asp:PlaceHolder>

        <asp:PlaceHolder runat="server" ID="oldpassPh" Visible="true">
            <div>
                <label>Old Pass:</label>
                <input id="oldpass" name="oldpass" type="password" runat="server" />
            </div>
        </asp:PlaceHolder>

        <div><label>New Password:</label>
            <input id="newpass1" name="newpass1" type="password" runat="server" />
        </div>
        <div><label>New Password (again):</label>
            <input id="newpass2" name="newpass2" type="password" runat="server" />
        </div>

        <div>
            <input type="submit" value="Change Password" />
        </div>
    </div>
    </form>
</body>
</html>
