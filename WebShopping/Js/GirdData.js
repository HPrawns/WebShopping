function JqTable(tableid) {
    this.tableid = tableid;
    this.table = $("#" + tableid);
    this.PageIndex = 1;
    this.PageSize = this.table.attr("PageSize");
    this.count = 0;
    this.DataArr = [];
    this.PageCount = 0;
    this.QueryFormId = null;
    this.QueryData = new Object();
    this.option = {
        action: this.table.attr("action"),
        RqUrl: this.table.attr("RqUrl")
    };
}
var divCont = $("<div id='pagediv'>");
//分页初始化
JqTable.prototype.PageInit = function () {
    var qindex = 0;
    var _datatable = this;
    _datatable.PageCount = parseInt(this.count / this.PageSize) + 1;     //总页数

    divCont.empty();
    divCont.insertAfter(this.table);
    var html = '<div><a href="javascript:void(0)" class="_pageindex_a" indextype="First"  >首页</a>' +
                       '<a href="javascript:void(0)" class="_pageindex_a" indextype="Prev">上一页</a>';
    for (var q = (_datatable.PageIndex - 1) ; q < _datatable.PageCount; q++) {
        html += '<a href="javascript:void(0)" class="_pageindex_a " indextype="' + (q + 1) + '" indexnumber="' + (q + 1) + '">' + (q + 1) + '</a>';
        if (_datatable.PageCount >= 5 && qindex == 4) {
            html += ' <span style="float: left">.........</span>';
            html += '<a href="javascript:void(0)" class="_pageindex_a" indextype="' + _datatable.PageCount + '"  indexnumber="' + _datatable.PageCount + '">' + _datatable.PageCount + '</a>';
            break;
        }
        qindex++;
    }
    html += '<a href="javascript:void(0)" class="_pageindex_a" indextype="Next">下一页</a>' +
    '<a href="javascript:void(0)" class="_pageindex_a"  indextype="Last"  indexnumber="' + _datatable.PageCount + '">尾页</a></div>';
    divCont.append(html);
    var pagediv = $("#pagediv");
    $("[indextype=First]").click(function () { _datatable.onFirst(this) });
    $("[indextype=Prev]").click(function () { _datatable.onPrev(this) });
    $("[indextype=Next]").click(function () { _datatable.onNext(this) });
    $("[indextype=Last]").click(function () { _datatable.onLast(this) });
    $("[indexnumber]").click(function () { _datatable.onPageGo(this) });
    NowIndexClass("pagediv", _datatable.PageIndex);
}
//组装查询数据
JqTable.prototype.FormData = function () {
    var eleid = "";
    if (this.QueryFormId == null || this.QueryFormId == undefined) {
        eleid = "._data_table_querform table";
    }
    else {
        eleid = this.QueryFormId;
    }
    this.QueryData.PageIndex = this.PageIndex;
    this.QueryData.PageSize = this.PageSize;
    var queryobj = this;
    $("input", eleid).each(function () {
        if ($(this).prop("type") != "button") {
            eval("queryobj.QueryData." + $(this).attr("name") + "='" + $(this).val() + "'");
        }
    });
    return this.QueryData;
}
//加载数据
JqTable.prototype.LoadData = function () {
    var _datatable = this;
    $.ajax({
        type: "POST",
        //contentType: "application/json;charset=utf-8",// 这句可不要忘了。
        url: "../Common/" + this.option.RqUrl + ".ashx",
        dataType: "JSON",
        data: { action: this.option.action, data: JSON.stringify(this.FormData()) },
        async: false,
        success: function (e) {
            if (e.success) {
                _datatable.count = e.count;
                _datatable.DataArr = e.content;
            }
            else {
                tipbox.error({ message: e.mess });
            }
        },
        error: function (e) {
            tipbox.error({ message: e.mess });
        }
    });
    this.BindData();
    this.PageInit();
}
var tbwidht = 0;
//绑定数据
JqTable.prototype.BindData = function () {
    var _datatable = this;
    tbwidht = 0;
    var ths = $(_datatable.table).find("thead tr th");
    var tbodys = $(_datatable.table).find("tbody");
    tbodys.empty();
    for (var i = 0; i < _datatable.DataArr.length; i++) {
        var htmls = $("<tr rownumber='" + i + "'></tr>");
        var item = _datatable.DataArr[i];
        for (var j = 0; j < ths.length; j++) {
            var values = item[$(ths[j]).attr("name")];
            var td = $("<td></td>");
            //判断自定义属性是否存在
            if ($(ths[j]).attr("celClick") != "" && $(ths[j]).attr("celClick") != undefined) {
                eval("var cellClickArry=" + $(ths[j]).attr("celClick") + "");
                if (typeof (cellClickArry) != "undefined") {
                    for (var key in cellClickArry) {
                        //     if (key == name) {
                        var funName = cellClickArry[key];
                        var linkA = $("<a href='javascript:void(0)' />").text(key);
                        linkA.attr("rowIndex", j);
                        linkA.attr("funName", funName);
                        linkA.bind("click", function () {
                            _datatable.LinkClick($(this).attr("funName"), item);
                        });
                        td.append(linkA);
                        //  }
                    }
                    htmls.append(td);
                }
            } else {
                htmls.append("<td>" + values + "</td>");
            }
            if ($(ths[j]).attr("width") != "" && $(ths[j]).attr("width") != undefined) {
                tbwidht += parseInt($(ths[j]).attr("width"));
            }
        }
        $(tbodys).append(htmls);
        htmls = "";
    }
    if (tbwidht < 1020) {
        $("#" + _datatable.tableid).css("width", 1020);
    }
    else {
        $("#" + _datatable.tableid).css("width", parseInt(tbwidht) + 50);
    }
}
//首页
JqTable.prototype.onFirst = function (obj) {
    this.PageIndex = 1;
    this.LoadData(this.PageIndex);
}
//上一页
JqTable.prototype.onPrev = function (obj) {
    this.PageIndex -= 1;
    if (this.PageIndex <= 0) { this.PageIndex = 1; return; }
    this.LoadData(this.PageIndex);
}
//下一页
JqTable.prototype.onNext = function (obj) {
    this.PageIndex += 1;
    if (this.PageIndex >= this.PageCount) {
        this.PageIndex = this.PageCount;
    }
    this.LoadData(this.PageIndex);
}
//尾页
JqTable.prototype.onLast = function (obj) {
    this.PageIndex = this.PageCount;
    this.LoadData(this.PageIndex);
}
//跳转页
JqTable.prototype.onPageGo = function (obj) {
    var _obj = $(obj);
    this.PageIndex = _obj.attr("indexnumber");

    this.LoadData(this.PageIndex);
}
JqTable.prototype.LinkClick = function (funName, obj) {
    eval(funName + "(obj)");
}
//为当前页提供类样式 obj=分页所在div的id
function NowIndexClass(obj, pageindex) {
    var _pagebox = $("#" + obj);
    $("a[indexnumber]", _pagebox).removeClass("_pageindex_a_click");
    $("a[indexnumber=" + pageindex + "]", _pagebox).addClass("_pageindex_a_click");
}
//重置区域
function ResetForm(tableid) {
    var Obj = $("#" + tableid);
    $("input", Obj).each(function () {
        if (this.disabled == true) { return true; }
        if (typeof ($(this).attr("name")) != "undefined" && $(this).prop("type") != "button") {
            if ($(this).prop("type") == "radiio") {
                if ($("input[name='" + this.name + "']").index(this) > 0) { return true; } $("input[name='" + this.name + "']")[0].checked = true;
            } else if ($(this).prop("type") == "checkbox") {
                this.checked = false;
            }
            else {
                $(this).val("");
            }

        }
    });
    $("select", Obj).each(function () {
        if (this.disabled == true) { return true; }
        if (typeof ($(this).attr("name")) != "undefined") {
            this.selectedIndex = 0;
        }
    });
}
/*下拉数据绑定*/
function BindOption(selid, types) {
    $("#" + selid).empty();
    $("#" + selid).append("<option value=''>----------</option>");
    var data = null;
    $.ajax({
        type: "POST",
        //contentType: "application/json;charset=utf-8",// 这句可不要忘了。
        url: "../Common/OptionCommon.ashx",
        //dataType: "text",
        data: types,
        async: false,
        success: function (e) {
            if (e.success) {
                data = e.content;
            }
            else {
                tipbox.error({ message: e.mess });
            }
            LoadEnd();
        },
        error: function (e) {
            tipbox.error({ message: e.mess });
        }
    });
    for (var i = 0; i < data.length; i++) {
        $("#" + selid).append("<option value='" + data[i].selfcode + "'>" + data[i].typename + "</option>");
    }
}
//读取URL参数
function GetQueryString(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)", "i");
    var r = window.location.search.substr(1).match(reg);  //获取url中"?"符后的字符串并正则匹配
    var context = "";
    if (r != null)
        context = r[2];
    reg = null;
    r = null;
    return context == null || context == "" || context == "undefined" ? "" : context;
}
///载入完成
function LoadEnd() {
    $(".spinner").hide();
    $(".spinner_div").hide();
}
function LoadStart() {
    $(".spinner_div").show();
    $(".spinner").show();
}