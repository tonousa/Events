<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CurrentTime.ascx.cs" Inherits="Caching.CurrentTime" %>

<%@ OutputCache Duration="10" VaryByParam="none" Shared="true" %>

Time from the CurrentTime control is <%= DateTime.Now.ToLongTimeString() %>