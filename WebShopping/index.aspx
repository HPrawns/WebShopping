<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebShopping.index" %>

<%@ Register Src="~/Controls/Index_menu.ascx" TagPrefix="uc1" TagName="Index_menu" %>
<%@ Register Src="~/Controls/Index_foot.ascx" TagPrefix="uc1" TagName="Index_foot" %>
<%@ Register Src="~/Controls/Index_search.ascx" TagPrefix="uc1" TagName="Index_search" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎光临网上商城</title>
</head>

<body>
    <div class="_topmenu">
        <uc1:Index_menu runat="server" ID="Index_menu" />
    </div>
    <div class="_search">
        <uc1:Index_search runat="server" id="Index_search" />
    </div>
    <div class="_head">
        <div class="_head_left"></div>
        <div class="_head_middle"></div>
        <div class="_head_right"></div>
    </div>
    <div class="_body">
        <div class="_body_left">
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
        </div>
        <div class="_body_right">
            <div class="_body_right_title"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
             <div class="_body_right_content"></div>
             <div class="_body_right_content"></div>
            <div class="_body_right_content"></div>
        </div>

    </div>
    <div class="_foot">
        <uc1:Index_foot runat="server" id="Index_foot" />
    </div>
</body>
</html>
