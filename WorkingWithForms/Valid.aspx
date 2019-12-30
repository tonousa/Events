<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Valid.aspx.cs" Inherits="WorkingWithForms.Valid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin: 10px 0;}
        input { margin: 0 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>Enter your name <input name="name" /></div>
    <div>Enter some html <input name="html" /></div>
    <div><button type="submit">Submit</button></div>
    <div>The name value you entered was <span runat="server" id="nameResult" /></div>
    <div>The html you entered was <span runat="server" id="htmlResult" /></div>
    </form>
</body>
</html>
