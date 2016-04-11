<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffView.aspx.cs" Inherits="WebShopping.StaffPage.StaffView" %>

<%@ Register Src="~/Controls/Menu_admin.ascx" TagPrefix="uc1" TagName="Menu_admin" %>
<%@ Register Src="~/Controls/Menu_left_staff.ascx" TagPrefix="uc1" TagName="Menu_left_staff" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>人员管理</title>
</head>
<body>
    <form id="Form1" runat="server">
        <div class="_admin_head_menu">
            <uc1:Menu_admin runat="server" ID="Menu_admin" />
        </div>
        <div class="_admin_body">
            <div class="_admin_body_left">
                <uc1:Menu_left_staff runat="server" id="Menu_left_staff" />
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
