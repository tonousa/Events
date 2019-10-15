<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnCachedForm.aspx.cs" Inherits="Caching.UnCachedForm" %>

<%@ Register TagPrefix="CC" TagName="Time" Src="~/CurrentTime.ascx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        div.panel { margin: 5px; padding: 5px; border: thin solid black;}
    </style>
</head>
<body>
    <div class="panel">
        <CC:Time runat="server" ID="timeControl" />
    </div>
    <div class="panel">
        Requested at: <%: DateTime.Now.ToLongTimeString() %>
    </div>
</body>
</html>
