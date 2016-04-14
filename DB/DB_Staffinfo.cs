using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;
using Entity.CustomClass;
using System.Data;
namespace DB
{
    /// <summary>
    /// 员工数据访问基类
    /// </summary>
    public class DB_Staffinfo
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 获取员工数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetStaffinfo(StaffinfoEntity entity)
        {
            try
            {
                string sql = "select *from GoodsType";
                var query = Uy.GetData<Staffinfo>(sql) as IEnumerable<Staffinfo>;
                if (!string.IsNullOrEmpty(entity.StaffName))
                {
                    query = query.Where(a => a.StaffName == entity.StaffName);
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
