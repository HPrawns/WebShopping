function TipBox() {
    this.tipboxDiv = "_tipbox_div";
    this.tipboxClass = "_tipbox";
}

TipBox.prototype.init = function () {
    var tipbox_div = $("#" + this.tipboxDiv);
    if (tipbox_div.length == 0) {
        tipbox_div = $("<div id='" + this.tipboxDiv + "'></div>")
        $("body").append(tipbox_div);
    }
    var _tipbox = $("." + this.tipboxClass);
    if (_tipbox.length == 0) {
        tipbox_div = '<div class="' + this.tipboxClass + '">' +
            ' <div class="_tipbox_title"><span style="margin-left: 15px;"  id="tiptitle">温馨提醒</span><div onclick="tipbox.close()" class="_tipbox_title_colse"></div></div>' +
            '<div class="_tipbox_content"><table class="_tipbox_table"><tr><td style="width: 45px;"><div class="_tipbox_content_img"></div></td><td><span id="tipmessage">保存成功!</span></td></tr>' +
            ' <tr><td></td><td></td></tr>' +
            ' <tr><td></td><td><a class="_btn_a _btn_a_tip" id="SureBtn">确定</a></td></tr></table></div></div>';
        $("body").append(tipbox_div);
    }

    $("." + this.tipboxClass).css({ top: (document.documentElement.clientHeight - 220) / 2, left: (document.documentElement.clientWidth - 360) / 2 });
}
/*
    title:提示标题 
    type:提示类型  success   information error
    message:提示内容
    callback:回调函数
   */
TipBox.prototype.message = function (obj) {
    if (typeof (obj.title) == "undefined" || obj.title == "") {
        obj.title = "温馨提示";
    }
    if (typeof (obj.message) == "undefined" || obj.message == "") {
        obj.message = "保存成功!";
    }
    if (typeof (obj.type) == "undefined" || obj.type == "") {
        obj.type = "success";
    }
    if (typeof (obj.callback) == "undefined" || obj.callback == "") {
        obj.callback = "";
    }
    $("." + this.tipboxClass).find($("#tiptitle")).html(obj.title);
    $("." + this.tipboxClass).find($("#tipmessage").html(obj.message));
    $("." + this.tipboxClass).find("#SureBtn").click(eval(obj.callback));
    $("#" + this.tipboxDiv).slideDown();
    $("." + this.tipboxClass).slideDown();

}
TipBox.prototype.close = function () {
    $("." + this.tipboxClass).hide();
    $("#" + this.tipboxDiv).hide();
}
