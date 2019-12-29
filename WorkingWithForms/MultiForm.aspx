<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiForm.aspx.cs" Inherits="WorkingWithForms.MultiForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
        label { width: 100px; display:inline-block}
        input[type=submit] {width: 120px; }
    </style>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <label>Enter a color:</label>
        <asp:TextBox runat="server" ID="color" Text="Green"></asp:TextBox>
        <asp:Button runat="server" ID="button1" Text="Submit Color"
            OnClick="button1_Click" />
    </form>
    </div>

    <div>
        <form method="post" action="MultiForm.aspx">
            <label>Enter a city:</label>
            <input id="city" value="London" runat="server" />
            <input type="submit" id="button2" value="Submit City" runat="server" />
        </form>
    </div>

    <div id="result" runat="server"></div>
</body>
</html>

