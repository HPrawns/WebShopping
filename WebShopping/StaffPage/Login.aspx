<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebShopping.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>管理员登录</title>
    <link href="../Css/Initialization.css" rel="stylesheet" />
    <link href="../Css/OverrideStyle.css" rel="stylesheet" />
    <script src="../Js/Jquery_2.2.2.js"></script>
    <link href="../font-awesome-4.5.0/css/font-awesome.min.css" rel="stylesheet" />
    <style>
        body {
            background: url('../Img/bg_img_01.jpg') no-repeat;
            background-size: 100%;
            margin: 0px auto;
        }

        ._div_login {
            top: 35%;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-shadow: 0px 0px 10px #ccc;
            margin: 0px auto;
            position: absolute;
            width: 300px;
            height: 250px;
            left: 38%;
        }

        ._qy_login {
            height: 45px;
            width: 300px;
            display: block;
            margin-top: 25px;
            margin-left: 22px;
        }

        ._btn_a {
            width: 255px;
            background-color: #ADC0D3;
            border-radius: 3px;
            margin-left: 0;
        }

            ._btn_a:hover {
                background-color: #F56C0B;
            }

        .input_login {
            transition: box-shadow 500ms;
        }

            .input_login:focus {
                -webkit-box-shadow: 0 0 5px #F56C0B;
                -moz-box-shadow: 0 0 5px #F56C0B;
                box-shadow: 0 0 5px #F56C0B;
            }

        ._qy_title {
            height: 25px;
            width: 255px;
            display: none;
            font-size: 12px;
            line-height: 25px;
            text-align: center;
            color: red;
            font-weight: bold;
            background-color:#fff;
            margin-left:21.5px;
        }
    </style>
    <script>
        $(function () {

        });
        function Logion() {
            var staffobj = {};
            staffobj.loginname = $("#loginname").val();
            staffobj.loginpwd = $("#loginpwd").val();
            $.ajax({
                type: "POST",
                url: "../Common/LoginCommon.ashx",
                //dataType: "text",
                data: { action: "staff", data: JSON.stringify(staffobj) },
                async: false,
                success: function (e) {
                    if (e.success) {
                        location.href = "GoodsView.aspx";
                    }
                    else {
                        console.log(e);
                        $("._qy_title").html(e.mess);
                        $("._qy_title").show();
                    }
                },
                error: function (e) {
                    $("._qy_title").html(e.mess);
                    $("._qy_title").show();
                }
            });
        }

    </script>
</head>
<body>
    <div class="_div_login">
        <div class="_qy_login">
            <div class="_qy_input">
                <input type="text" class="input_login" placeholder="账号"  id="loginname" name="loginname"/>
            </div>
        </div>
        <div class="_qy_login">
            <div class="_qy_input">
                <input type="password" class="input_login" placeholder="密码"    id="loginpwd" name="loginpwd"/>
            </div>
        </div>

        <div class="_qy_login"><a class="_btn_a" onclick="Logion()">登录</a></div>
        <div class="_qy_title">错误</div>
    </div>

</body>
</html>
