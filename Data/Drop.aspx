<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Drop.aspx.cs" Inherits="Data.Drop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList runat="server" ID="drop"
                 SelectMethod="GetProducts" AppendDataBoundItems="true">
                <asp:ListItem Selected="True" Text="All"></asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            Selection: <span runat="server" id="selection"></span>
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
