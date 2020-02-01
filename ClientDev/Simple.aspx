<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Simple.aspx.cs" Inherits="ClientDev.Simple" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <span class="message">simple.aspx</span>
    </div>
    <div> Mobile: <%: Request.Browser.IsMobileDevice %></div>
    <div>
        <button>Button 1</button>
        <button>Button 2</button>
    </div>
</asp:Content>
