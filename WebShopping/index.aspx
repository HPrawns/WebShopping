<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebShopping.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎光临网上商城</title>
    <script src="Js/Jquery_2.2.2.js"></script>
    <link href="Css/Initialization.css" rel="stylesheet" />
    <style>
        div {
            border: 1px solid red;
            margin: 0px auto;
        }
        /*最外层的div暂时用蓝色边框辨识*/
        ._head, ._body, ._topmenu {
            border:1px solid blue;
        }
        /*头部div 最外层DIV*/
        ._head {
            height: 450px;
            width: 1210px;
        }
        /*顶部的菜单栏*/
        ._topmenu {
            height:35px;
            width:100%;
            /*position:absolute;*/
        }
        /*中间部分最大div*/
        ._body {
            height:1400px;
            width:1210px;
        }
    </style>
</head>

<body>
    <div class="_topmenu"></div>
    <div class="_head">
    </div>
    <div class="_body"></div>
</body>
</html>
