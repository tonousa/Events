<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductTest.aspx.cs" Inherits="ClientDev.ProductTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px; }
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        $(document).ready(function () {
            $("button").click(function (e) {
                var action = 
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <button data-action="all">Get all</button>
        <button data-action="one">Get one</button>
    </div>
        <textarea id="results" cols="40" rows="10"></textarea>
    </form>
</body>
</html>
