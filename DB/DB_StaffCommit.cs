using Entity.BaseClass;
using Entity.CustomClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DB_StaffCommit
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetStaffCommit(StaffCommitEntity entity)
        {
            try
            {
                string sql = "select *from Userinfo";
                var query = Uy.GetData<StaffCommit>(sql) as IEnumerable<StaffCommit>;
                if (entity.Gid != null)
                {
                    query = query.Where(a => a.Gid == entity.Gid);
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
