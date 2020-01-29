<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="ClientDev.CreateProduct" %>

<%@ Register TagPrefix="CC" Assembly="ClientDev" Namespace="ClientDev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        th {text-align:left;}
        td[colspan="2"] {text-align: center; padding: 10px 0;}
        .error {color:red;}
        .input-validation-error {border: medium solid red;}
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/validation") %>
    <script src="Scripts/CreateProduct.js"></script>
    <%--<script>
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
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <div id="errorSummary" data-valmsg-summary="true" class="error">
            <ul><li style="display:none"></li></ul>
            <asp:ValidationSummary runat="server" CssClass="error" />
        </div>
        <table>
            <%--<tr>
                <td>Name:</td>
                <td><input id="Name" runat="server" 
                    data-val="true" data-val-required="Provide a Name"
                    data-val-length="5-20 chars" 
                    data-val-length-min="5" data-val-length-max="20"/></td>
            </tr>
            <tr>
                <td>Category:</td>
                <td><input id="Category" runat="server" 
                    data-val="true" data-val-required="Provide Category" /></td>
            </tr>
            <tr>
                <td>Price:</td>
                <td><input id="Price" runat="server" 
                    data-val="true" data-val-required="Provide Price" 
                    data-val-range="between 1-100,000" 
                    data-val-range-min="1" data-val-range-max="100000" /></td>
            </tr>--%>

            <CC:ValidationRepeater runat="server"
                ItemType="ClientDev.ValidationRepeaterDataItem" 
                ModelType="ClientDev.Models.Product" 
                Properties="Name, Category, Price" >
                <PropertyTemplate>
                    <tr>
                        <td><%# Item.PropertyName %></td>
                        <td>
                            <input id="<%# Item.PropertyName %>" 
                                name="<%# Item.PropertyName %>" 
                                <%# Item.ValidationAttributes %> />
                        </td>
                    </tr>
                </PropertyTemplate>
            </CC:ValidationRepeater>

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
