<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Index_menu.ascx.cs" Inherits="WebShopping.Controls.Index_menu" %>
<link href="../Css/Initialization.css" rel="stylesheet" />
<link href="../Css/Index.css" rel="stylesheet" />
<script src="Js/Jquery_2.2.2.js"></script>
<style>
    .menu_right, .menu_left {
        height: 35px;
        line-height: 35px;
        font: 12px/35px Arial,Verdana,"宋体";
    }

    .menu_left {
        float: left;
        margin-left: 100px;
    }

    .menu_right {
        float: right;
        margin-right: 100px;
    }

    .menu_right_ul li {
        float: left;
        margin-left: 15px;
    }

        .menu_right_ul li a {
            font-weight: bold;
            color: #747474;
        }

            .menu_right_ul li a:hover {
                text-decoration: underline;
                color: #ff6a00;
                cursor: pointer;
            }

    .spacer {
        width: 1px;
        height: 15px;
        margin-top: 9px;
        padding: 0px;
        background: #DDD none repeat scroll 0% 0%;
        overflow: hidden;
    }
</style>
<div class="menu_left">返回首页</div>
<div class="menu_right">
    <ul class="menu_right_ul">
        <li><a>你好,请登录</a></li>
        <li class="spacer"></li>
        <li><a>免费注册</a></li>
        <li class="spacer"></li>
        <li><a>查看购物车</a></li>
        <li class="spacer"></li>
        <li><a>我的订单</a></li>
        <li class="spacer"></li>
        <li><a>商城助手</a></li>
        <li class="spacer"></li>
        <li><a>客服帮助</a></li>
        <li class="spacer"></li>
        <li><a>企业采购</a></li>

    </ul>
</div>
