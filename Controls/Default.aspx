﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Controls.Default" %>

<%--<%@ Register Src="~/Custom/BasicCalc.ascx" TagPrefix="CC" TagName="Calc" %>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input { width: 100px;}
        div { margin-bottom: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input name="firstNumber" value="10" /> + 
            <input name="secondNumber" value="31" />
            <button type="submit">=</button>
            <span id="result" runat="server"></span>
        </div>
        <div>
            <CC:Calc runat="server" id="calc" />
        </div>
    </form>
</body>
</html>