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
        /// 获取商品;评论信息
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetStaffCommit(StaffCommitEntity entity)
        {
            try
            {
                string sql = "select *from StaffCommit";
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

        /// <summary>
        /// 更新评论
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateStaffCommit(StaffCommitEntity entity)
        {

            try
            {
                string sql = "select *from StaffCommit where 1=1";
                int i = 0;
                if (entity.Scid != null)
                {
                    sql += " and Scid=" + entity.Scid;

                    var data = Uy.GetData<StaffCommit>(sql).FirstOrDefault();

                    data.Gid = entity.Gid == null ? data.Gid : entity.Gid;
                    data.Uid = entity.Uid == null ? data.Uid : entity.Uid;
                    data.Sid = entity.Sid == null ? data.Sid : entity.Sid;
                    data.Commitdate = DateTime.Now;
                    data.isEnabled = entity.isEnabled;
                    string strsql = SqlString(entity);
                    i = DB.Update(strsql);
                }
                else
                {
                    string strsql = SqlString(entity);
                    i = DB.Update(strsql);
                }
                if (i > 0)
                {
                    return new JsonHelp().JsonMsg(true, "保存成功!", 0);
                }
                else
                {
                    return new JsonHelp().JsonMsg(false, "保存失败!", 0);
                }
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "保存失败!" + ex.Message, 0);
            }
        }


        /// <summary>
        /// 组装执行语句
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private string SqlString(StaffCommitEntity entity)
        {
            if (entity.Scid == null)
            {
                string insert = "  insert into StaffCommit  (Gid,Uid,Commitinfo,Sid,Backinfo,Commitdate,isEnabled)" +
                                      "values({0},{1},'{2}',{3},'{4}',{5},{6});";
                insert = string.Format(insert, entity.Gid, entity.Uid, entity.Commitinfo, entity.Sid, entity.Backinfo, entity.Commitdate, entity.isEnabled == true ? 1 : 0);
                return insert;
            }
            else
            {
                string update = "UPDATE StaffCommit  SET Gid={0},Uid={1},Commitinfo='{2}',Sid={3},Backinfo='{4}' ,isEnabled={5}, Commitdate={6} WHERE Scid={7}";
                update = string.Format(update, entity.Gid, entity.Uid, entity.Commitinfo, entity.Sid, entity.Backinfo, entity.isEnabled == true ? 1 : 0, entity.Commitdate, entity.Scid);
                return update;
            }
        }
    }
}
