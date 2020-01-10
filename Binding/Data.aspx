<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="Binding.Data" %>
<%@ Register TagPrefix="CC" Namespace="Binding.Controls" Assembly="Binding" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="max" value="5" runat="server" />
            <CC:OperationSelector runat="server" id="opOperator" />
            <button type="submit">Generate</button>
        </div>
        <div>
            <asp:Repeater runat="server" ItemType="System.String" SelectMethod="GetData">
                <ItemTemplate>
                    <p><%# Item %></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
