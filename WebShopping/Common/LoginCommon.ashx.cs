using BLL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity.BaseClass;
using System.Web.SessionState; 
namespace WebShopping.Common
{
    /// <summary>
    /// LoginCommon 登录相关的一般处理
    /// </summary>
    public class LoginCommon : IHttpHandler, IRequiresSessionState 
    {
        LoginService Ls = new LoginService();
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "application/json";
            string backJson = string.Empty;
            var action = context.Request.Form["action"];
            var data = context.Request.Form["data"];

            switch (action)
            {
                case "staff":
                    backJson = stafflogion(data,context);
                    break;
                default:
                    break;
            }
            context.Response.Write(backJson);
        }

        public string stafflogion(string datajson,HttpContext context)
        {
            Dictionary<string, object> data = new JsonHelp().ParseEntity<Dictionary<string, object>>(datajson);
            string loginname = data["loginname"].ToString();
            string loginpwd = data["loginpwd"].ToString();
            string json = Ls.Login(loginname, loginpwd);
            Msg<Staffinfo> ms = new JsonHelp().ParseEntity< Msg<Staffinfo>>(json);
            if (ms.success)
            {
                context.Session["staffer"] = ms.firstcontent;
            }
            return json;
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