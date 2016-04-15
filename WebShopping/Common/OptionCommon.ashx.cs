using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity.CustomClass;
using Entity.BaseClass;
using BLL.Service;

namespace WebShopping.Common
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {
        OptionService os = new OptionService();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            var type = context.Request.Form[0];
            string backjson = string.Empty;
            switch (type)
            {
                case "goodstype":
                    backjson = GetOption();
                    break;
                case "StaffType":
                    backjson = "";
                    break;
                default:
                    break;
            }
            context.Response.Write(backjson);
        }

        public string GetOption()
        {
            GoodsTypeEntity gt = new GoodsTypeEntity();
            gt.isEnabled = true;
            gt.PageIndex = 0;
            gt.PageSize = 9999;
            return os.GetGoodsType(gt);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}