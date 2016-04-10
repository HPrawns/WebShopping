using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShopping.Common
{
    /// <summary>
    /// 工具类
    /// </summary>
    public class Tools
    {

        public static string GeVer() {
            string ver = System.Guid.NewGuid().ToString();
            return ver;
        }
    }
}