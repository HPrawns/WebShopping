<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShopping.UserPage.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户登录</title>
    <script src="../Js/Jquery_2.2.2.js"></script>
    <link href="../Css/Initialization.css" rel="stylesheet" />
    <link href="../Css/OverrideStyle.css" rel="stylesheet" />
    <link href="../font-awesome-4.5.0/css/font-awesome.min.css" rel="stylesheet" />
    <style>
        ._head {
            height: 65px;
            margin: 0px auto;
            width: 100%;
        }

        ._head_back {
            margin-top: 5px;
            border: 0px solid red;
            height: 65px;
            width: 125px;
            margin-left: 60px;
            border-radius: 2px;
            line-height: 65px;
            font-size: 16px;
            color: #C0C0C0;
            font-weight: 700;
            text-align: center;
            transition: background-color 500ms;
            float:right;
        }

            ._head_back:hover {
                color: white;
                background-color: #FF4400;
                
            }

        ._body {
            height: 550px;
            margin: 0px auto;
        }

        ._head, ._body {
            width: 1210px;
        }

        ._body_img {
            margin-top: 50px;
            border: 0px solid red;
            height: 500px;
            width: 1210px;
            background: url(../Img/img_02.jpg) no-repeat -650px 0px;
        }

        ._body_right {
            background-color: white;
            width: 430px;
            height: 350px;
            position: absolute;
            top: 27%;
            left: 60.75%;
        }

            ._body_right table {
                border: 0px solid green;
                border-collapse: collapse;
                width: 360px;
                height: 300px;
                margin: 25px 25px;
            }

                ._body_right table tr td {
                    border: 0px solid black;
                }

                ._body_right table tr span {
                    height: 18px;
                    line-height: 18px;
                    font-size: 16px;
                    color: #3C3C3C;
                    margin-top: 9px;
                    padding-bottom: 8px;
                    font-weight: 700;
                    margin-left: 45px;
                }

        .font_div {
            background-color: #CCC;
            /*border: 1px solid #ccc;*/
            height: 38px;
            margin-left: 45px;
            border-top-left-radius: 4px;
            border-bottom-left-radius: 4px;
            border-right: 0;
        }

        ._btn_a {
            height: 36px;
            font: 16px/36px Helvetica, Verdana, sans-serif;
            width: 280px;
            margin-left: 55px;
        }

        .fa-2x {
            color: #FF4400;
            font-size: 1.5em;
            margin-top: 8px;
            margin-left: 10px;
        }
    </style>
</head>
<body>
    <div class="_head">
        <div class="_head_back"   onclick="javascript:window.location.href='/index.aspx'" >返回首页</div>

    </div>
    <hr />
    <div class="_body">
        <div class="_body_img">
            <div class="_body_right">
                <table>
                    <tr>
                        <td colspan="2"><span>用户登录</span></td>
                    </tr>
                    <tr>
                        <td>
                            <div class="font_div"><i class="fa fa-user fa-2x"></i></div>
                        </td>
                        <td>
                            <input type="text" class="input_login" placeholder="账号" /></td>
                    </tr>
                    <tr>
                        <td>
                            <div class="font_div"><i class="fa fa-lock fa-2x"></i></div>
                        </td>
                        <td>
                            <input type="password" class="input_login" placeholder="密码" /></td>
                    </tr>
                    <tr>
                        <td colspan="2" ><a class="_btn_a">登录</a></td>
                    </tr>
                    <tr>
                        <td colspan="2"><a class="_link_a">用户注册</a><a class="_link_a" style="float: right;">忘记密码</a></td>
                    </tr>
                </table>

            </div>
        </div>

    </div>
    <hr />
</body>
</html>
