<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Binding.Default" %>
<%@ Register TagPrefix="CC" Assembly="Binding" Namespace="Binding.Controls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {display:inline-block; width:100px; text-align:right; margin: 5px;}
        div.panel {float:left; margin-left:10px;}
        div.panel label {text-align:right;}
        div.error, span.error  {color:red;}
    </style>
</head>
<body>
    <%--<asp:PlaceHolder ID="errorPanel" Visible="false" runat="server">
        <div class="error">
            Problems:
            <ul>
                <asp:Repeater runat="server" ItemType="System.String" 
                    SelectMethod="GetModelValidationErrors" ViewStateMode="Disabled">
                    <ItemTemplate>
                        <li><%# Item %></li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
    </asp:PlaceHolder>--%>

    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server" CssClass="error"
             HeaderText="Problems:" />

        <div class="panel">
            <div>
                <label>Your name:</label><input id="name" runat="server" />
                <CC:FieldValidator runat="server" PropertyName="name" CssClass="error" />
            </div>
            <div>
                <label>Your age:</label><input id="age" runat="server" />
                <CC:FieldValidator runat="server" PropertyName="age" CssClass="error" />
            </div>
            <div>
                <label>Your cell no:</label><input id="cell" runat="server" />
                <CC:FieldValidator runat="server" PropertyName="cell" CssClass="error" />
            </div>
            <div>
                <label>Your zip:</label><input id="zip" runat="server" />
                <CC:FieldValidator runat="server" PropertyName="zip" CssClass="error" />
            </div>
            <button type="submit">Submit</button>
        </div>
        <div class="panel">
            <asp:Repeater runat="server" ItemType="Binding.Models.Person" 
                SelectMethod="GetData" ViewStateMode="Disabled">
                <ItemTemplate>
                    <div><label>Your name:</label><span><%# Item.Name %></span></div>
                    <div><label>Your age:</label><span><%# Item.Age %></span></div>
                    <div><label>Your cell no:</label><span><%# Item.Cell %></span></div>
                    <div><label>Your zip:</label><span><%# Item.Zip %></span></div>
                </ItemTemplate>
            </asp:Repeater>
               
        </div>
    </form>
</body>
</html>
