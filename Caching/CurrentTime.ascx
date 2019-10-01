<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CurrentTime.ascx.cs" Inherits="Caching.CurrentTime" %>

Time from the CurrentTime control is <%= DateTime.Now.ToLongTimeString() %>