<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCalc.ascx.cs" Inherits="Controls.Custom.BasicCalc" %>

This is the BasicCalc control

<%--<script src="../Scripts/jquery-3.4.1.js"></script>
<script>
    $(document).ready(function () {
        var id = "<%= GetId("first")%>";
        $("#" + id).focus().select();
    });
</script>--%>

<div>
    <input name="<%= GetId("initialVal") %>" value="<%= Initial %>" />
    <asp:Repeater ItemType="Controls.Custom.Calculation" SelectMethod="GetCalculations"
         ID="calcRepeater" runat="server" EnableViewState="false">
        <ItemTemplate>
            <%# Item.Operation == OperationType.Plus ? "+" : "-" %>
            <input name="<%= GetId("calcValue") %>" value="<%# Item.Value %>" />
            <input type="hidden" name="<%= GetId("calcOp") %>" value="<%# Item.Operation %>" />
        </ItemTemplate>
    </asp:Repeater>
    
    <button type="submit">=</button>
    <span runat="server" id="result"></span>
</div>