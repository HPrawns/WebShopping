using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
using BLL;
using BLL.Service;
using Entity.CustomClass;

namespace WebShopping.Common
{
    /// <summary>
    /// GoodsCommon ajax请求入口
    /// </summary>
    public class GoodsCommon : IHttpHandler
    {
        GoodsService gs = new GoodsService();

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            var action = context.Request.Form["action"];
            string backjson = string.Empty;
            switch (action)
            {
                case "query":
                    backjson = GetGoodsData("");
                    break;
                default:
                    break;
            }
            context.Response.Write(backjson);
        }
        /// <summary>
        /// 获取商品数据
        /// </summary>
        /// <returns></returns>
        public string GetGoodsData(string jsondata)
        {
            GoodsEntity ge = new GoodsEntity();
            ge.PageIndex = 0;
            ge.PageSize = 15;
            var query = gs.GetGoodsData(ge);
            return new JsonHelp().JsonMsg(true, "获取成功", 0, query);
        }
    }
}