<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RequestControl.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>This is Default.aspx</h3>
        <div>
            <input type="radio" name="choice"
                value="redirect302" checked="checked" />Redirect
        </div>
        <div>
            <input type="radio" name="choice"
                value="redirect301" checked="checked" />Redirect 
            Permanent
        </div>
        <div>
            <input type="radio" name="choice"
                value="remaphandler" checked="checked" />Remap Handler
        </div>
        <div>
            <input type="radio" name="choice"
                value="transferpage" checked="checked" />Transfer Page
        </div>
        <div>
            <input type="radio" name="choice"
                value="execute" checked="checked" />Execute Handlers
        </div
        <p><button type="submit">Submit</button></p>
    </div>
    </form>
</body>
</html>
