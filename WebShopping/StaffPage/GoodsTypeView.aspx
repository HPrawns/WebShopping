<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsTypeView.aspx.cs" Inherits="WebShopping.StaffPage.GoodsTypeView" %>

<%@ Register Src="~/Controls/Menu_left_goods.ascx" TagPrefix="uc1" TagName="Menu_left_goods" %>
<%@ Register Src="~/Controls/Menu_admin.ascx" TagPrefix="uc1" TagName="Menu_admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>商品管理</title>
    <style>

    </style>

</head>
<body>
    <form id="Form1" runat="server">
        <div class="_admin_head_menu">
            <uc1:Menu_admin runat="server" ID="Menu_admin" />
        </div>
        <script>
            var goodstypetable = {};
            var tipbox = {};
            $(function () {
                tipbox = new TipBox();
                tipbox.init();
                //LoadStart();
                //BindOption("goodstype", "goodstype");
                //goodstable = new JqTable("_datatable_goods");
                //goodstable.LoadData();
            });
            function EditGoodsType(item) {
                location.href = "../StaffPage/GoodsTypeEdit.aspx?type='edit'&gid=" + item.gid;
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
                    <table id="goodstypeform">
                        <tr>
                            <td>类型名称：</td>
                            <td>
                                <input type="text" class="_input_default" name="typename" id="typename" /></td>
                            <td>类型编码：</td>
                            <td>
                                <input type="text" class="_input_default" name="selfcode" id="selfcode" /></td>
<%--                            <td>商品类型：</td>
                            <td>
                                <select class="select_default" id="goodstype" name="goodstype">
                                </select></td>--%>
                        </tr>
                        <tr>
                            <td colspan="6"><a class="_btn_a _btn_a_submit" onclick="goodstable.LoadData()">查询</a><a class="_btn_a _btn_a_reset" onclick="ResetForm('goodstypeform')">重置</a></td>
                        </tr>
                    </table>
                </div>
                <div class="_data_div">
                    <table class="_data_table" id="_datatable_goodstype" pagesize="15" action="query" rqurl="">
                        <thead>
                            <tr>
                                <th name="gtid" width="80" celclick="{'修改':'EditGoodsType'}"><a>序号</a></th>
                                <th name="parentcode">父菜单编码</th>
                                <th name="selfcode">类型编码</th>
                                <th name="typename">类型名称</th>
                                <th name="goodsinfo">类型说明</th>
                                <th name="goodsmark">类型备注</th>
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
