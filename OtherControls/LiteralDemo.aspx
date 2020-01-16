<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LiteralDemo.aspx.cs" Inherits="OtherControls.LiteralDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
        div.message {color: <asp:Literal ID="colorLiteral" Text="Red" runat="server" />; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="message">
        color set by literal control
    </div>
        <div>
            Enter color:
            <input id="colorInput" runat="server" />
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
