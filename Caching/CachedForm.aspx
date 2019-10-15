<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CachedForm.aspx.cs" Inherits="Caching.CachedForm" EnableViewStateMac="true" %>

<%@ OutputCache Duration="10" CacheProfile="standard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        div.panel { margin: 10px 0;}
        div.panel label { display: inline-block; text-align:right;
                          width:60px; margin-right:10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="panel">
            <label>Quantity:</label>
            <input id="quantity" name="quantity" runat="server" />
        </div>
        <div class="panel">
            <label>Price:</label>
            <input id="price" name="price" runat="server" />
        </div>

        <div class="panel">
            <button type="submit">Submit</button>
        </div>
        <div class="panel">
            Total Price: <%: GetTotal() %>
        </div>
        <div class="panel">
            Generated at: <%: GetTimeStamp() %>
        </div>
        <div class="panel">
            Requested at: <asp:Substitution MethodName="GetDynamicTimeStamp" runat="server" />
        </div>
    </div>
    </form>
</body>
</html>
