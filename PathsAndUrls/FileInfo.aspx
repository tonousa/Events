<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileInfo.aspx.cs" Inherits="PathsAndUrls.FileInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>Content from file:</p>
    <%= GetFileContent() %>
</body>
</html>
