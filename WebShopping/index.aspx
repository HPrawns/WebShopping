<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebShopping.index" %>

<%@ Register Src="~/Controls/Index_menu.ascx" TagPrefix="uc1" TagName="Index_menu" %>
<%@ Register Src="~/Controls/Index_foot.ascx" TagPrefix="uc1" TagName="Index_foot" %>
<%@ Register Src="~/Controls/Index_search.ascx" TagPrefix="uc1" TagName="Index_search" %>




<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>欢迎光临网上商城</title>
</head>

<body>
    <div class="_topmenu">
        <uc1:Index_menu runat="server" ID="Index_menu" />
    </div>
    <div class="_search">
        <uc1:Index_search runat="server" id="Index_search" />
    </div>
    <div class="_head">
        <div class="_head_left"></div>
        <div class="_head_middle"></div>
        <div class="_head_right"></div>
    </div>
    <div class="_body">
        <div class="_body_left">
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
            <div class="_body_left_content"></div>
        </div>
        <div class="_body_right">
            <div class="_body_right_title"></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB22_vRjpXXXXXqXXXXXXXXXXXX_!!35616715-0-dgshop.jpg_120x120.jpg" /></span><strong>迷你全自动洗衣机</strong><p>迷你小巧的洗衣机，收纳方便，箱体使用的是工程级ABS塑料材质制成，耐用方便清洁，盘形波轮和钻石抛光工艺处理的内桶，减少了直接摩擦，保护衣物，配备了智能自检装置，自动调整负载平衡，降低了噪音，24小时预约洗涤功能，方便省钱。</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB231g4jVXXXXXCXFXXXXXXXXXX_!!0-dgshop.jpg_120x120.jpg" /></span><strong>牛仔半身裙</strong> <p>经典的半身裙版型，具有强大的藏肉功效，让多余肉肉隐藏无形，前排扣设计，穿脱方便，衣橱里不可缺少的百搭神器，怎么穿都是不会错。</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB2LWXMdXXXXXXSXXXXXXXXXXXX_!!671002383-0-dgshop.jpg_120x120.jpg"/></span><strong>墨西哥牛油果</strong><p>墨西哥牛油果，进口鲜果，果型饱满，色泽墨绿，肉厚核小，油香浓郁，细腻柔滑，味道甘美，营养丰富，好吃又健康！</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB2uAMHcpXXXXarXpXXXXXXXXXX_!!671002383-0-dgshop.jpg_120x120.jpg" /></span><strong>EDO江户猪骨味拉面</strong><p>新加坡原装进口，EDO江户猪骨味拉面，精选优质小麦制成，口感筋道爽滑，汤汁浓而不腻，好吃得停不下来！</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB1k7HoGVXXXXX9XXXXXXXXXXXX_120x120.jpg" /></span><strong>湖南香辣小鱼仔</strong><p>湖南香辣小鱼仔，肉酥汁浓，口感鲜美，能下饭的小鱼仔，不仅仅是零食哦~</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB2gxmgkFXXXXbsXXXXXXXXXXXX_!!0-dgshop.jpg_120x120.jpg"/></span><strong>壁挂式迷你滚筒洗衣机</strong><p>外观小巧功能却很强大的壁挂洗衣机，尤其对宝宝衣服的去污能力超赞，普通洗衣机很难清洗的污渍，通过高温煮洗就可以轻松应对，带童锁功能更安全，而且静音效果好，不影响日常生活。</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB2gPZbhFXXXXXvXXXXXXXXXXXX_!!1750793293-0-dgshop.jpg_120x120.jpg"/></span><strong>PLADI 变倍双筒望远镜</strong><p>一体式金属骨架，光轴稳定。10-300倍无极变倍，看得更远，看得更清楚。全光学玻璃镜片，FMC宽频镀膜，成像清晰锐利，微光夜视效果出色。</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB2jAxjaVXXXXacXpXXXXXXXXXX_!!2074381025-0-dgshop.jpg_120x120.jpg" /></span><strong>铁棍山药红薯粉丝 手工自制 无添加 地瓜粉条</strong><p>铁棍山药红薯粉条是由河南焦作温县原产地的铁棍山药，加上优质的红薯精制加工而成。红薯含有丰富的淀粉、膳食纤维、胡萝卜素、维生素A、B、C、E以及钾、铁、铜、硒、钙等微量元素，营养价值很高。食用铁棍山药红薯粉条使营养更加均衡。</p></a></div>
             <div class="_body_right_content"><a><span><img src="Img/index/TB2xGHQeXXXXXbdXpXXXXXXXXXX_!!31720691.jpg_120x120.jpg" /></span><strong>藤编收纳筐 杂物储物箱 文具整理篮 中号置物盒抽屉手工越南进口</strong><p>越南藤编所使用的藤是生长在越南中部的一种植物，这种材料非常结实，可以用来做家具，这种收纳篮基本保持了传统的式样，由当地的农家一个一个的编织，即使熟练一天也只能编出几个，虽然很慢，但是这种方式制作的物件可以使用多年，而且愈来愈美。</p></a></div>
             <div class="_body_right_content"><a><span><img src="Img/index/TB1PSZFHXXXXXXvXpXXXXXXXXXX_120x120.jpg.png" /></span><strong>飘零大叔三味猪肉脯</strong><p>新加坡风味、蜜汁味、香辣味，三位一体猪肉脯，入口细嚼，越嚼越香，肉质酥香爽口，回味无穷。</p></a></div>
            <div class="_body_right_content"><a><span><img src="Img/index/TB23uSzeFXXXXbXXpXXXXXXXXXX_!!1917126244-0-dgshop.jpg_120x120.jpg" /></span><strong>北京特产驴打滚</strong><p>驴打滚是老北京传统小吃之一，因其最后制作工序中撒上的黄豆面，犹如老北京郊外野驴撒欢打滚时扬起的阵阵黄土，因此而得名“驴打滚”。期原料采用大黄米面、黄豆面、澄沙、白糖、香油、桂花、青红丝和瓜仁精制而成，外层粘满豆面，呈金黄色，豆香馅甜，入口绵软，别具风味，是老少皆宜的传统风味小吃！</p></a></div>
        </div>

    </div>
    <div class="_foot">
        <uc1:Index_foot runat="server" id="Index_foot" />
    </div>
</body>
</html>
