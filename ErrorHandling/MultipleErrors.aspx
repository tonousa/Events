<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleErrors.aspx.cs" Inherits="ErrorHandling.MultipleErrors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>something has gone wrong, problems:
         <p>
             <ul>
                 <asp:Repeater ItemType="System.String" SelectMethod="GetErrorMessages"
                      runat="server">
                     <ItemTemplate>
                         <li><%# Item %></li>
                     </ItemTemplate>
                 </asp:Repeater>
             </ul>
         </p>

        <p><a href="Default.aspx">Try again</a></p>
    </div>
    </form>
</body>
</html>
