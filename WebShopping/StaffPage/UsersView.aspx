<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsersView.aspx.cs" Inherits="WebShopping.StaffPage.UsersView" %>

<%@ Register Src="~/Controls/Menu_left_goods.ascx" TagPrefix="uc1" TagName="Menu_left_goods" %>
<%@ Register Src="~/Controls/Menu_admin.ascx" TagPrefix="uc1" TagName="Menu_admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户管理</title>
</head>
<body>
    <form id="Form1" runat="server">
        <div class="_admin_head_menu">
            <uc1:Menu_admin runat="server" ID="Menu_admin" />
        </div>
        <script>
            var goodstable = {};
            var tipbox = {};
            $(function () {
                tipbox = new TipBox();
                tipbox.init();
                //LoadStart();
                //BindOption("goodstype", "goodstype");
                //goodstable = new JqTable("_datatable_goods");
                //goodstable.LoadData();
            });
            function EditGoods(item) {
                location.href = "../StaffPage/GoodsEdit.aspx?type='edit'&gid=" + item.gid;
            }
        </script>
        <div class="_admin_body">
            <div class="_admin_body_left">
                <uc1:Menu_left_goods runat="server" ID="Menu_left_goods" />
            </div>
            <div class="spinner_div"></div>
            <div class="spinner">
                <div class="rect1"></div>
                <div class="rect2"></div>
                <div class="rect3"></div>
                <div class="rect4"></div>
                <div class="rect5"></div>
            </div>
            <div class="_admin_body_right">
                <div class="_data_table_querform">
                    <table id="goodsform">
                        <tr>
                            <td>商品名称：</td>
                            <td>
                                <input type="text" class="_input_default" name="goodsname" id="goodsname" /></td>
                            <td>商品编码：</td>
                            <td>
                                <input type="text" class="_input_default" name="goodscode" id="goodscode" /></td>
                            <td>商品类型：</td>
                            <td>
                                <select class="select_default" id="goodstype" name="goodstype">
                                </select></td>
                        </tr>
                        <tr>
                            <td colspan="6"><a class="_btn_a _btn_a_submit" onclick="goodstable.LoadData()">查询</a><a class="_btn_a _btn_a_reset" onclick="ResetForm('goodsform')">重置</a></td>
                        </tr>
                    </table>
                </div>
                <div class="_data_div">
                    <table class="_data_table" id="_datatable_goods" pagesize="15" action="query" rqurl="GoodsCommon">
                        <thead>
                            <tr>
                                <th name="Uid" width="80" celclick="{'修改':'EditGoods'}"><a>序号</a></th>
                                <th name="username"  width="180">用户名</th>
                                <th name="loginname"  width="180">登录名</th>
                                <th name="loginpwd"  width="180">登录密码</th>
                                <th name="userlevel"  width="80">用户等级</th>
                                <th name="phone"  width="180">联系电话</th>
                                <th name="email" width="180">电子邮箱</th>
                                <th name="certificates"  width="100">证件类型</th>
                                <th name="certificatesid"  width="180">证件号码</th>
                                <th name="addresscontact"  width="180">联系地址</th>
                                <th name="address1"  width="180">联系地址2</th>
                                <th name="address3"  width="180">联系地址3</th>
                                <th name="address3"  width="180">联系地址4</th>
                                <th name="umark"  width="180">用户备注</th>
                                <th name="content"  width="180">用户说明</th>
                                <th name="logindate"  width="180">登录时间</th>
                                <th name="isenabled">是否启用</th>
                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>

    </form>
</body>

</html>
