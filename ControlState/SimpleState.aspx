﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SimpleState.aspx.cs" Inherits="ControlState.SimpleState" EnableViewState="true" ViewStateEncryptionMode="Auto"
     EnableViewStateMac="true" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div {margin-bottom:10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div><CC:SimpleTime runat="server" ViewStateMode="Enabled" /></div>
        <div>View State works: <%= ViewStateWorks %></div>
        <div>Control State works: <%= ControlStateWorks %></div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
