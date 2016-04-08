///菜单滑动初始化
//ultagclass:菜单UL外层DIV类名,请保持唯一    slidedivclass:滑动的DIV类名请保持唯一   seed:速度/毫秒
function slideMenu(ultagclass, slidedivclass, seed) {
    this.ultagclass = ultagclass;
    this.slidedivclass = slidedivclass;
    this.seed = seed;
}
slideMenu.prototype.Init = function () {
    var liobj = $("." + this.ultagclass).find("li"); if (!liobj) { return; }
    var sldiv = $("." + this.slidedivclass);
    var fileft = $(liobj[0]).offset().left;
    sldiv.css({ "width": $(liobj[0]).css("width"), "left": fileft });
    $(liobj).hover(function () {
        var lefts = $(this).offset().left;
        sldiv.stop().animate({
            left: lefts
        }, this.seed);
    }, function () {
        sldiv.stop().animate({
            left: fileft
        }, "fast");
    });
}
