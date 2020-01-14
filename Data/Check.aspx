<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Check.aspx.cs" Inherits="Data.Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList runat="server" ID="cbl" AppendDataBoundItems="true"
             SelectMethod="GetProducts" RepeatColumns="3">
            <asp:ListItem Text="All" Selected="True" />
        </asp:CheckBoxList>
    </div>
        <div>
            Selection: <span runat="server" id="selection" />
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
