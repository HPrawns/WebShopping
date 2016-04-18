<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoodsTypeEdit.aspx.cs" Inherits="WebShopping.StaffPage.GoodsTypeEdit" %>

<%@ Register Src="~/Controls/Menu_left_goods.ascx" TagPrefix="uc1" TagName="Menu_left_goods" %>
<%@ Register Src="~/Controls/Menu_admin.ascx" TagPrefix="uc1" TagName="Menu_admin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>商品编辑</title>
</head>
<body>
    <form id="Form1" runat="server">
        <div class="_admin_head_menu">
            <uc1:Menu_admin runat="server" ID="Menu_admin" />
        </div>
        <script>
            var goodstable = {};
            var quertstring = GetQueryString("gid");
            var actiontype = GetQueryString("type");
            var tipbox = {};
            $(function () {
                tipbox = new TipBox();
                tipbox.init();
                //        BindOption("goodstype", "goodstype");
                if (actiontype == "edit") {
                    //BindData();
                }
                else {
                    $("title").html("商品添加");
                }
            });
            //提交数据
            function SubmitData() {
                var goods = {};
                $("input,select,radio", $("#_goods_edit")).each(function () {
                    goods[$(this).attr("name")] = $(this).val();
                });
                $.ajax({
                    type: "POST",
                    //contentType: "application/json;charset=utf-8",// 这句可不要忘了。
                    url: "../Common/GoodsCommon.ashx",
                    //dataType: "text",
                    data: { action: "update", data: JSON.stringify(goods) },
                    async: false,
                    success: function (e) {
                        if (e.success) {
                            tipbox.message({ callback: "Close" });
                        }
                    },
                    error: function (e) { }
                });
            }
            function BindData() {
                var data = {};
                $.ajax({
                    type: "POST",
                    //contentType: "application/json;charset=utf-8",// 这句可不要忘了。
                    url: "../Common/GoodsCommon.ashx",
                    //dataType: "text",
                    data: { action: "edit", data: quertstring },
                    async: false,
                    success: function (e) {
                        if (e.success) {
                            data = e.firstcontent;
                        }
                    },
                    error: function (e) { }
                });
                for (var name in data) {
                    $("#" + name).val(data[name] + "");
                }
            }
            function Close() {
                location.href = "../StaffPage/GoodsView.aspx";
            }
        </script>
        <div class="_admin_body">
            <div class="_admin_body_left">
                <uc1:Menu_left_goods runat="server" ID="Menu_left_goods" />
            </div>
            <div class="_admin_body_right">

                <div class="_data_div_edit">
                    <table class="_data_table_edit" id="_goods_edit">
                        <tr>
                            <td>类型名称：</td>
                            <td>
                                <input class="_input_default" name="typename" id="typename" />
                                <input style="display: none" name="gtid" id="gtid" /></td>
                            <td>类型编码：</td>
                            <td>
                                <select class="select_default" id="selfcode" name="selfcode">
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>父菜单编码：</td>
                            <td>
                                <select class="select_default" id="parentcode" name="parentcode">
                                </select></td>
                            <td>是否启用：</td>
                            <td>
                                <select class="select_default" id="isenabled" name="isenabled">
                                    <option value="true">是</option>
                                    <option value="false">否</option>
                                </select>
                            </td>
                        </tr>
                        <tr>
                            <td>商品备注：</td>
                            <td>
                                <input class="_input_default" name="goodsmark" id="goodsmark" /></td>
                            <td>商品说明：</td>
                            <td>
                                <input class="_input_default" name="goodsinfo" id="goodsinfo" /></td>
                        </tr>
                        <tr>
                            <td></td>
                            <td colspan="3"><a class="_btn_a _btn_a_submit" onclick="SubmitData()">提交</a><a class="_btn_a _btn_a_reset" onclick="Close()">返回</a></td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
