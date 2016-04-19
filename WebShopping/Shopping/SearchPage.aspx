<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPage.aspx.cs" Inherits="WebShopping.Shopping.SearchPage" %>


<%@ Register Src="~/Controls/Index_menu.ascx" TagPrefix="uc1" TagName="Index_menu" %>
<%@ Register Src="~/Controls/Index_foot.ascx" TagPrefix="uc1" TagName="Index_foot" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <div class="_topmenu">
        <uc1:Index_menu runat="server" ID="Index_menu" />
    </div>
        <div class="_search"></div>
    <div class="_body">
     
    </div>
    <div class="_foot">
        <uc1:Index_foot runat="server" id="Index_foot" />
    </div>
</body>
</html>
