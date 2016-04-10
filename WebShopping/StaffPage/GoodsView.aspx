<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsView.aspx.cs" Inherits="WebShopping.StaffPage.GoodsView" %>

<%@ Register Src="~/Controls/Admin_left.ascx" TagPrefix="uc1" TagName="Admin_left" %>
<%@ Register Src="~/Controls/Goods_menu.ascx" TagPrefix="uc1" TagName="Goods_menu" %>



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
            margin: 0 auto;
            width: 1210px;
            height: 685px;
        }

        ._admin_body_left, ._admin_body_right {
            border: 1px solid #C0C0C0;
            border-radius: 2px;
            float: left;
            height: 680px;
        }

        ._admin_body_left {
            width: 195px;
            margin: 15px 0 0 0px;
        }

        ._admin_body_right {
            width: 1010px;
            margin: 15px 0 0 0;
            overflow-x:auto;
        }

        ._admin_left_menu {
            width: 180px;
            height: auto;
            padding-top: 10px;
        }

            ._admin_left_menu li {
                width: 180px;
                border: 1px solid #C0C0C0;
                height: 45px;
                text-align: center;
                line-height: 45px;
                margin-left: 5px;
                transition: margin-left 500ms;
                background-color: #007ACC;
                border-radius: 2px;
            }

                ._admin_left_menu li a {
                    font-size: 1.1em;
                    color: white;
                }

                ._admin_left_menu li:hover {
                    background-color: #0062A5;
                    margin-left: 10px;
                }

        ._admin_left_menu_li_hover {
            width: 186px;
            height: 47px;
            background-color: #FFEDC3;
        }
    </style>
</head>
<body>
    <form runat="server">
        <div class="_admin_head_menu">
            <uc1:Admin_left runat="server" ID="Admin_left" />
        </div>
        <div class="_admin_body">
            <div class="_admin_body_left">
                <uc1:Goods_menu runat="server" ID="Goods_menu" />
            </div>
            <div class="_admin_body_right">
                <table class="_data_table" id="_datatable_goods">
                    <thead>
                        <tr>
                            <th name="gid" width="50">序号</th>
                            <th name="goodsname" width="100">商品名称</th>
                            <th name="goodscode">商品编码</th>
                            <th name="goodsprice">商品类型</th>
                            <th name="goodsprice">商品价格</th>
                            <th name="goodsplace">商品产地</th>
                            <th name="goodsscore">商品评分</th>
                            <th name="goodsplace">商品备注</th>
                            <th name="goodsmark">商品说明</th>
                            <th name="isenabled">是否启用</th>
                        </tr>
                    </thead>
                    <tbody>
                    </tbody>
                </table>

            </div>
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
