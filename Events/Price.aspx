﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Price.aspx.cs" Inherits="Events.Price" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Today's date is: <%= DateTime.Now.ToShortDateString() %></p>
        <p>A new shirt costs <%= 20.ToString("C") %></p>
    </div>
    </form>
</body>
</html>
