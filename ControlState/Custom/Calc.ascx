<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Calc.ascx.cs" Inherits="ControlState.Custom.Calc" %>

<div>
    <input id="firstValue" runat="server" value="10" />
    <input id="secondValue" runat="server" value="31" />
<%--    <asp:Button Text=" = " OnClick="HandleClick" runat="server" />--%>
    <button type="submit"> = </button>
    <span id="resultValue" runat="server"></span>
</div>

<div>
    <h3>History:</h3>
    <ul>
        <asp:Repeater runat="server" ItemType="System.String"
             SelectMethod="GetHistory">
            <ItemTemplate>
                <li><%# Item %></li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
</div>