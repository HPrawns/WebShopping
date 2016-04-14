using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;
using System.Data;
using Entity.CustomClass;
namespace DB
{
    /// <summary>
    /// 类型操作基类
    /// </summary>
    public class DB_Option
    {

        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 读取商品总类数据,参数的实体可配置分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsType(GoodsTypeEntity entity)
        {
            try
            {
                string sql = "select *from GoodsType";
                var query = Uy.GetData<GoodsType>(sql) as IEnumerable<GoodsType>;
                if (!string.IsNullOrEmpty(entity.Selfcode))
                {
                    query = query.Where(a => a.Selfcode == entity.Selfcode);
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
        /// 更新商品类型
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateGoodsType(GoodsTypeEntity entity)
        {
            try
            {
                string sql = "select *from GoodsType where 1=1";
                int i = 0;
                if (!string.IsNullOrEmpty(entity.Selfcode))
                {
                    sql += " and Selfcode='" + entity.Selfcode + "'";
                }
                var data = Uy.GetData<GoodsType>(sql).FirstOrDefault();
                if (data != null)
                {
                    string update = "UPDATE GoodsType  SET parentcode='{0}' ,typename='{1}',goodsinfo='{2}',goodsmark='{3}',isenabled={4} WHERE selfcode='{5}'";
                    update = string.Format(update, entity.Parentcode, entity.Typename, entity.Goodsinfo, entity.Goodsmark, entity.isEnabled == true ? 1 : 0, entity.Selfcode);
                    i = DB.Update(update);
                }
                else
                {
                    string insert = "  insert into GoodsType  (parentcode,selfcode,typename,goodsinfo,goodsmark,isenabled)" +
                      "values('{0}','{1}','{2}','{3}','{4}',{5});";
                    insert = string.Format(insert, entity.Parentcode, entity.Selfcode, entity.Typename, entity.Goodsinfo, entity.Goodsmark, entity.isEnabled == true ? 1 : 0);

                    i = DB.Update(insert);
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
        #region 员工种类
        /// <summary>
        /// 读取商品总类数据,参数的实体可配置分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsType(StaffTypeEntity entity)
        {
            try
            {
                string sql = "select *from StaffType";
                var query = Uy.GetData<StaffType>(sql) as IEnumerable<StaffType>;
                if (!string.IsNullOrEmpty(entity.Typecode))
                {
                    query = query.Where(a => a.Typecode == entity.Typecode);
                }
                query = query.Where(a => a.isEnabled == entity.isEnabled);
                var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
                return new JsonHelp().JsonMsg(true, "获取成功!", list.Count, list);
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "获取失败!" + ex.Message, 0);
            }
        }
        #endregion
    }
}
