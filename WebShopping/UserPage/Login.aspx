<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShopping.UserPage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户登录</title>
    <script src="../Js/Jquery_2.2.2.js"></script>
    <link href="../Css/Initialization.css" rel="stylesheet" />
    <style>
        div {
            border: 1px solid red;
            margin: 0px auto;
        }
        /*最外层的div暂时用蓝色边框辨识*/
        ._head, ._body, ._topmenu {
            border: 1px solid blue;
        }

        ._head {
            height: 45px;
        }

        ._body {
            height: 760px;
        }

        ._head, ._body {
            width: 1210px;
        }

        ._body_left, ._body_right {
            margin-top: 150px;
            border: 1px solid red;
            height: 450px;
            float: left;
            margin-left: 25px;
        }

        ._body_left {
            width: 570px;
        }

        ._body_right {
            width: 570px;
        }
    </style>
</head>
<body>
    <div class="_head"></div>
    <div class="_body">
        <div class="_body_left"></div>
        <div class="_body_right">
            <table>
                <tr><td></td></tr>
                <tr><td></td></tr>
                <tr><td></td></tr>
                <tr><td></td></tr>
            </table>

        </div>
    </div>
</body>
</html>
