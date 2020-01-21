<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WebUserControl1.ascx.cs" Inherits="ClientDev.WebUserControl1" %>
<script>
    if (jQuery) {
        $(document).ready(function () {
            $('#nameSpan').text("Simple User control");
        });
    }
    else {
        throw new Error("jQuery is required");
    }
</script>

<div>
    This is the <span id="nameSpan"></span>
</div>