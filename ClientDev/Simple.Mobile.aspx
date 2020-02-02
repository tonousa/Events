<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.Mobile.aspx.cs" Inherits="ClientDev.Simple_Mobile" MasterPageFile="~/Site.Mobile.Master" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <span class="message">This is Simple.Mobile.aspx</span>
    </div>
    <div>Mobile: <%: Request.Browser.IsMobileDevice %> </div>
    <div>
        <button>Button 1</button>
        <button>Button 2</button>
    </div>
</asp:Content>