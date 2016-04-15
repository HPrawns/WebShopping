﻿using System;
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
            var data = context.Request.Form["data"];
            string backjson = string.Empty;
            switch (action)
            {
                case "query":
                    backjson = GetGoodsData(data);
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
            GoodsEntity ge = new JsonHelp().ParseEntity<GoodsEntity>(jsondata);
            ge.PageIndex = (ge.PageIndex - 1) * ge.PageSize;
            return gs.GetGoodsData(ge);

        }
        public string test(string jsondata)
        {
            GoodsEntity ge = new JsonHelp().ParseEntity<GoodsEntity>(jsondata);
            ge.PageIndex = (ge.PageIndex - 1) * ge.PageSize;
            return gs.GetGoodsData(ge);
        }
    }
}