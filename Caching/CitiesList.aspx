<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CitiesList.aspx.cs" Inherits="Caching.CitiesList" %>

<%@ OutputCache Duration="60" VaryByParam="none" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    Here are some cities: 
    <%= GetCities() %>
    (Rendered at <%: DateTime.Now.ToLongTimeString() %>)
</body>
</html>
