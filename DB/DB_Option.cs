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
        #region 商品种类
        /// <summary>
        /// 组装商品种类基本数据到实体集合
        /// </summary>
        /// <returns></returns>
        private IEnumerable<GoodsType> GetGoodstypeData(string sql)
        {
            List<GoodsType> list = new List<GoodsType>();
            DataTable dt = DB.GetTable(sql);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    GoodsType gs = new GoodsType();
                    Uy.ConvertToEntityList(gs, item);
                    list.Add(gs);
                }
            }
            return list;
        }
        /// <summary>
        /// 读取商品总类数据,参数的实体可配置分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<GoodsType> GetGoodsType(GoodsTypeEntity entity)
        {
            string sql = "select *from GoodsType";
            var query = GetGoodstypeData(sql);
            if (!string.IsNullOrEmpty(entity.Selfcode))
            {
                query = query.Where(a => a.Selfcode == entity.Selfcode);
            }
            if (entity.isEnabled != null)
            {
                query = query.Where(a => a.isEnabled == entity.isEnabled);
            }
            var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
            return list;
        }

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
                var data = GetGoodstypeData(sql).FirstOrDefault();
                if (data != null)
                {
                    string update = "UPDATE GoodsType  SET parentcode='" + entity.Parentcode + "', typename='" + entity.Typename + "'  ," +
                        " goodsinfo='" + entity.Goodsinfo + "' , goodsmark='" + entity.Goodsmark + "' , isenabled='" + entity.isEnabled + "' ," +
                        " WHERE selfcode='" + entity.Selfcode + "';";
                    i = DB.Update(update);
                }
                else
                {
                    string insert = "insert into GoodsType values('parentcode','" + entity.Parentcode + "'),('selfcode','" + entity.Selfcode + "')," +
                        "('typename','" + entity.Typename + "'),('goodsinfo','" + entity.Goodsinfo + "'),('goodsmark','" + entity.Goodsmark + "')," +
                        "('isenabled','" + entity.isEnabled + "')";
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

        #endregion
        #region 员工种类
        /// <summary>
        /// 组装员工种类基本数据到实体集合
        /// </summary>
        /// <returns></returns>
        private IEnumerable<StaffType> GetStaffTypeData(string sql)
        {
            List<StaffType> list = new List<StaffType>();

            DataTable dt = DB.GetTable(sql);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    StaffType gs = new StaffType();
                    Uy.ConvertToEntityList(gs, item);
                    list.Add(gs);
                }
            }
            return list;
        }
        /// <summary>
        /// 读取商品总类数据,参数的实体可配置分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public List<StaffType> GetGoodsType(StaffTypeEntity entity)
        {
            string sql = "select *from StaffType";
            var query = GetStaffTypeData(sql);
            if (!string.IsNullOrEmpty(entity.Typecode))
            {
                query = query.Where(a => a.Typecode == entity.Typecode);
            }
            if (entity.isEnabled != null)
            {
                query = query.Where(a => a.isEnabled == entity.isEnabled);
            }
            var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
            return list;
        }
        #endregion
    }
}
