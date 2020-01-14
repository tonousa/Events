<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bullet.aspx.cs" Inherits="Data.Bullet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:BulletedList runat="server" ID="bullet" SelectMethod="GetProducts"
             AppendDataBoundItems="true" BulletStyle="Square" ItemType="System.String">
            <asp:ListItem Selected="True" Text="All"></asp:ListItem>
        </asp:BulletedList>
    </div>
    </form>
</body>
</html>
