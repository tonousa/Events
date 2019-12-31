<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BasicCalc.ascx.cs" Inherits="Controls.Custom.BasicCalc" %>

This is the BasicCalc control
<div>
    <input name="<%= GetId("firstNumber") %>" value="10" /> + 
    <input name="<%= GetId("secondNumber") %>" value="31" />
    <button type="submit">=</button>
    <span runat="server" id="result"></span>
</div>