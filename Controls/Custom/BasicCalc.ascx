<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCalc.ascx.cs" Inherits="Controls.Custom.BasicCalc" %>

This is the BasicCalc control

<script src="../Scripts/jquery-3.4.1.js"></script>
<script>
    $(document).ready(function () {
        var id = "<%= GetId("first")%>";
        $("#" + id).focus().select();
    });
</script>

<div>
    <input id="<%= GetId("first") %>" name="<%= GetId("firstNumber") %>" value="10" /> + 
    <input name="<%= GetId("secondNumber") %>" value="31" />
    <button type="submit">=</button>
    <span runat="server" id="result"></span>
</div>