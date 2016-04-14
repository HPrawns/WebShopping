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
                string sql = "select *from Staffinfo";
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


        /// <summary>
        /// 组装执行语句
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private string SqlString(StaffinfoEntity entity)
        {
            if (entity.Sid == null)
            {
                string insert = "  insert into Staffinfo  (StaffName,LoginName,LoginPwd,StaffType,Phone,Email,Smark,isEnabled)" +
                                      "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7});";
                insert = string.Format(insert, entity.StaffName, entity.LoginName, entity.LoginPwd, entity.StaffType, entity.Phone, entity.Email, entity.Smark, entity.isEnabled == true ? 1 : 0);
                return insert;
            }
            else
            {
                string update = "UPDATE Staffinfo  SET StaffName='{0}',LoginName='{1}',LoginPwd='{2}',StaffType='{3}',Phone='{4}',Email='{5}',Smark='{6}',isEnabled={7} WHERE Scid={8}";
                update = string.Format(update, entity.StaffName, entity.LoginName, entity.LoginPwd, entity.StaffType, entity.Phone, entity.Email, entity.Smark, entity.isEnabled == true ? 1 : 0, entity.Sid);
                return update;
            }
        }
    }
}
