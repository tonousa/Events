<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiViewDemo.aspx.cs" Inherits="OtherControls.MultiViewDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style> div { margin-bottom: 10px; } </style>
</head>
<body>
    <form id="form1" runat="server">
    <asp:MultiView runat="server" ID="mView">
        <asp:View ID="firstView" runat="server">
            <div>First View</div>
        </asp:View>
        <asp:View ID="secondView" runat="server">
            <div>Second View</div>
        </asp:View>
        <asp:View ID="thirdView" runat="server">
            <div>Third View</div>
        </asp:View>
    </asp:MultiView>
        <div>
            Select view:
            <select runat="server" id="nameSelect">
                <option value="0" selected="selected">First</option>
                <option value="1" >second</option>
                <option value="2" >Third</option>
            </select>
            <button type="submit">Submit</button>
        </div>
    </form>
</body>
</html>
