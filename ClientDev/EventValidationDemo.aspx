<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventValidationDemo.aspx.cs" Inherits="ClientDev.EventValidationDemo" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        $(document).ready(function () {
            var targetElement = $("#nameSelect");
            targetElement.attr("disabled", "true");
            $.ajax({
                url: "/api/product",
                type: "GET",
                success: function (data) {
                    for (var i = 0; i < data.length; i++) {
                        $("<option>" + data[i].Name
                            + "</option>").appendTo("#nameSelect");
                    }
                    targetElement.removeAttr("disabled");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <select id="nameSelect" runat="server">
                <option>All</option>
            </select>
            <button type="submit">Submit</button>
        </div>
        <%--<div>
            control value: <span id="controlValue" runat="server"></span>
        </div>--%>
        <div>
            form value: <span id="formValue" runat="server"></span>
        </div>
    </form>
</body>
</html>
