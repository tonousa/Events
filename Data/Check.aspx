﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Check.aspx.cs" Inherits="Data.Check" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.js"></script>
    <script>
        var IDs = {
            controlSelector: "#<%= cbl.ClientID %> input",
            allInputID: "<%= cbl.ClientID %>_0",
            allInputSelector: "#<%= cbl.ClientID %>_0"
        }
        $(document).ready(function () {
            $(IDs.controlSelector).change(function (e) {
                console.log("in change handler");

                var selection = (e.target.id == IDs.allInputID) ?
                    $(IDs.controlSelector).not(IDs.allInputSelector)
                        .attr("checked", false) :
                    $(IDs.allInputSelector).attr("checked", false);
                selection.attr("checked", false);
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBoxList runat="server" ID="cbl" AppendDataBoundItems="true"
             SelectMethod="GetProducts" RepeatColumns="3">
            <asp:ListItem Text="All" Selected="True" />
        </asp:CheckBoxList>
    </div>
        <div>
            Selection: <span runat="server" id="selection" />
        </div>
        <button type="submit">Submit</button>
    </form>
</body>
</html>
