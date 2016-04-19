using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
namespace BLL.Service
{
    public class LoginService
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="loginname"></param>
        /// <param name="loginpwd"></param>
        /// <returns></returns>
        public string Login(string loginname, string loginpwd)
        {
            return new DB_Staffinfo().Login(loginname, loginpwd);
        }

    }
}
