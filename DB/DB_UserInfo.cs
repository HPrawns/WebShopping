using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;
using Entity.CustomClass;
namespace DB
{
    public class DB_UserInfo
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetUserinfo(UserInfoEntity entity)
        {
            try
            {
                string sql = "select *from Userinfo";
                var query = Uy.GetData<UserInfo>(sql) as IEnumerable<UserInfo>;
                if (!string.IsNullOrEmpty(entity.UserName))
                {
                    query = query.Where(a => a.UserName == entity.UserName);
                }
                if (entity.isEnabled != null)
                {
                    query = query.Where(a => a.isEnabled == entity.isEnabled);
                }
                var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
                return new JsonHelp().JsonMsg(true, "获取成功!", list.Count, list);
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "获取失败!" + ex.Message, 0);
            }
        }
    }
}
