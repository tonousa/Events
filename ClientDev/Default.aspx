<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientDev.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="MainStyles.css" rel="stylesheet" />
    <link href="ErrorStyles.css" rel="stylesheet" />
    <%--<script src="Scripts/jquery-3.4.1.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>--%>
    <link href="Content/themes/base/jquery-ui.css" rel="stylesheet" />
    <%: System.Web.Optimization.Styles.Render("~/bundle/basicCSS", "~/bundle/jqueryUICSS") %>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery", "~/bundle/jqueryui") %>
    <script>
        $(document).ready(function () {
            $('input[type=submit]').button();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="submit" name="color" value="Red" />
            <input type="submit" name="color" value="Green" />
            <input type="submit" name="color" value="Blue" />
        </div>
        <div>
            <span class="message">
                Selected color:
                <span id="selectedValue" runat="server">
                    <span class="error">No selection has been made</span>
                </span>
            </span>
        </div>
    </form>
</body>
</html>
