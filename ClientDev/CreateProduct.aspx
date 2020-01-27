<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="ClientDev.CreateProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th {text-align:left;}
        td[colspan="2"] {text-align: center; padding: 10px 0;}
        .error {color:red;}
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/validation") %>
    <script>
        $(document).ready(function () {
            $("button").click(function (e) {
                var inputElem = $("#Name")[0];
                if (inputElem.checkValidity() && !inputElem.validity.customError) {
                    var length = inputElem.value.length;
                    if (length < 5 || length > 20) {
                        inputElem.setCustomValidity("Name must be 5-20 chars")
                    }
                } else {
                    inputElem.setCustomValidity("");
                }
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server" CssClass="error" />
        <table>
            <tr>
                <td>Name:</td>
                <td><input id="Name" runat="server" required="required" /></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Name" 
                        ErrorMessage="Name must be provided" Text="*" CssClass="error" />
                </td>
            </tr>
            <tr>
                <td>Category:</td>
                <td><input id="Category" runat="server" required="required" /></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Category" 
                        ErrorMessage="provide Category" Text="*" CssClass="error" />
                </td>
            </tr>
            <tr>
                <td>Price:</td>
                <td><input id="Price" runat="server" required="required" 
                    type="number" min="1" max="100000" /></td>
                <td>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Price" 
                        ErrorMessage="Enter price" Text="*" CssClass="error" />
                    <asp:RangeValidator runat="server" ControlToValidate="Price" 
                        MinimumValue="1" MaximumValue="100000" 
                        ErrorMessage="price not in range" Text="*" CssClass="error"  />
                </td>
            </tr>

            <tr><td colspan="2"><input type="submit" value="Create" runat="server" /></td></tr>

            <tr><th>ID</th><th>Name</th><th>Category</th><th>Price</th></tr>
            <asp:Repeater runat="server" 
                ItemType="ClientDev.Models.Product" SelectMethod="GetCreated">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.ProductID %></td>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Category %></td>
                        <td><%#: Item.Price.ToString("F2") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
            
        </table>
    </form>
</body>
</html>
