using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;
using BLL;

namespace WebShopping.Common
{
    /// <summary>
    /// GoodsCommon 的摘要说明
    /// </summary>
    public class GoodsCommon : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
        }
    }
}