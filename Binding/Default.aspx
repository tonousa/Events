﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Binding.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {display:inline-block; width:100px; text-align:right; margin: 5px;}
        div.panel {float:left; margin-left:10px;}
        div.panel label {text-align:right;}
    </style>
</head>
<body>
    <div class="panel">
        <form id="form1" runat="server">
            <div><label>Your name:</label><input id="name" runat="server" /></div>
            <div><label>Your age:</label><input id="age" runat="server" /></div>
            <div><label>Your cell no:</label><input id="cell" runat="server" /></div>
            <div><label>Your zip:</label><input id="zip" runat="server" /></div>
            <button type="submit">Submit</button>
        </form>
    </div>
    <div class="panel">
            <div><label>Your name:</label><span id="sname" runat="server" /></div>
            <div><label>Your age:</label><span id="sage" runat="server" /></div>
            <div><label>Your cell no:</label><span id="scell" runat="server" /></div>
            <div><label>Your zip:</label><span id="szip" runat="server" /></div>
    </div>
</body>
</html>
