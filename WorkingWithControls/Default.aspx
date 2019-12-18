<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WorkingWithControls.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-top: 10px;} </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Button presses: <span id="counter" runat="server"></span>
    </div>
    <div>
        <button type="submit">Submit</button>
    </div>
    </form>
</body>
</html>
