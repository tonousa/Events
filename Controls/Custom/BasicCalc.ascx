<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCalc.ascx.cs" Inherits="Controls.Custom.BasicCalc" %>

This is the BasicCalc control

<script src="../Scripts/jquery-3.4.1.js"></script>
<script>
    <%--$(document).ready(function () {
        var id = "<%= GetId("first")%>";
        $("#" + id).focus().select();
    });--%>
</script>

<div>
    <input name="<%= GetId("firstNumber") %>" value="<%= FirstValue %>" /> + 
    <input name="<%= GetId("secondNumber") %>" value="<%= SecondValue %>" />
    <button type="submit">=</button>
    <span runat="server" id="result"></span>
</div>