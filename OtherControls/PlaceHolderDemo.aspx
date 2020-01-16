<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlaceHolderDemo.aspx.cs" Inherits="OtherControls.PlaceHolderDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Show placeholders contents:
            <input id="show" type="checkbox" runat="server" />
            <button type="submit">Submit</button>
        </div>
        <asp:PlaceHolder ID="ph" runat="server">
            <div>
                ph content:
                <div>
                    <button type="submit">another submit</button>
                    <asp:LinkButton Text="Rich UI control" runat="server" ></asp:LinkButton>
                </div>
            </div>
        </asp:PlaceHolder>
    </form>
</body>
</html>
