<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsView.aspx.cs" Inherits="WebShopping.StaffPage.GoodsView" %>

<%@ Register Src="~/Controls/Admin_left.ascx" TagPrefix="uc1" TagName="Admin_left" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>

    <style>
        ._admin_head_menu {
            margin: 0 auto;
            height: 70px;
            width: 1210px;
        }
        ._admin_body {
            margin:0 auto;
            width:1210px;
            height:685px;
        }
        ._admin_body_left, ._admin_body_right {
            border: 1px solid red;
            float: left;
            height: 680px;  
           
        }

        ._admin_body_left {
            width: 185px;
           margin:15px 0 0 0px;
        }

        ._admin_body_right {
            width: 1020px;
             margin:15px 0 0 0;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="_admin_head_menu">
            <uc1:Admin_left runat="server" ID="Admin_left" />
        </div>
        <div class="_admin_body">
            <div class="_admin_body_left"></div>
            <div class="_admin_body_right"></div>
        </div>

    </form>
</body>
<script>
    $(function () {
        var slideMenuObj = new slideMenu("slideMenu", "hrdiv", 500);
        slideMenuObj.Init();
    });

</script>
</html>
