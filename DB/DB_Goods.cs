using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Entity.CustomClass;
using System.Data;
using Entity.BaseClass;

namespace DB
{
    /// <summary>
    /// 商品数据库访问类
    /// </summary>
    public class DB_Goods
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        DB_Option db_option = new DB_Option();
        /// <summary>
        /// 获取商品数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsData(GoodsEntity entity)
        {
            try
            {
                string sql = "select *from goods";
                var query = Uy.GetData<Goods>(sql) as IEnumerable<Goods>;
                if (!string.IsNullOrEmpty(entity.GoodsName))
                {
                    query = query.Where(a => a.GoodsName.Contains(entity.GoodsName));
                }
                var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
                var option = db_option.GetGoodsType("");

                list.ForEach(f =>
                {
                    var optiondata = option.Where(a => a.Selfcode == f.GoodsType).FirstOrDefault();
                    f.GoodsType = optiondata != null ? optiondata.Typename : f.GoodsType;
                });
                return new JsonHelp().JsonMsg(true, "获取成功!", list.Count, list);
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "获取失败!" + ex.Message, 0);
            }
        }
        /// <summary>
        /// 获取商品数据(id)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsDataByid(string gid)
        {
            try
            {
                string sql = "select *from goods";
                if (!string.IsNullOrEmpty(gid))
                {
                    sql += " where gid=" + gid;
                }
                var query = Uy.GetData<Goods>(sql) as IEnumerable<Goods>;
                return new JsonHelp().JsonMsg(true, "获取成功!", 0, query != null ? query.FirstOrDefault() : null);
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
        public string UpdateGoods(GoodsEntity entity)
        {
            try
            {
                string sql = "select *from goods where 1=1";
                int i = 0;
                if (!string.IsNullOrEmpty(entity.GoodsCode))
                {
                    sql += " and goodscode='" + entity.GoodsCode + "'";
                }
                var data = Uy.GetData<Goods>(sql).FirstOrDefault();
                if (data != null)
                {
                    string update = "UPDATE Goods SET goodsname='{0}' ,goodstype='{1}',goodsprice={2},goodsinfo='{3}',goodsmark='{4}',goodsplace='{5}',isenabled={6} WHERE gid={7}";
                    update = string.Format(update, entity.GoodsName, entity.GoodsType, entity.GoodsPrice, entity.GoodsInfo, entity.GoodsMark, entity.GoodsPlace, entity.isEnabled == true ? 1 : 0, entity.Gid);
                    i = DB.Update(update);
                }
                else
                {
                    string insert = "  insert into GoodsType  (goodsname,goodscode,goodstype,goodsprice,goodsinfo,goodsmark,goodsplace,goodsscore,isenabled)" +
                      "values('{0}','{1}','{2}',{3},'{4}','{5}','{6}',{7},{8});";
                    insert = string.Format(insert, entity.GoodsName, entity.GoodsCode, entity.GoodsType, entity.GoodsPrice, entity.GoodsInfo, entity.GoodsMark, entity.GoodsPlace, entity.GoodsScore, entity.isEnabled == true ? 1 : 0);

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






        #region 测试分页

        public string test(GoodsEntity entity)
        {
            var query = Getcity();
            var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
            return new JsonHelp().JsonMsg(true, "获取成功", query.Count(), list);
        }
        private IEnumerable<city> Getcity()
        {
            List<city> list = new List<city>();
            string sql = "select *from city";
            DataTable dt = DB.GetTable(sql);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    city gs = new city();
                    Uy.ConvertToEntityList(gs, item);
                    list.Add(gs);
                }
            }
            return list;
        }
        #endregion
    }
}
