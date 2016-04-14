using Entity.BaseClass;
using Entity.CustomClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DB_SellGoods
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 获商品销售数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetSellGoods(SellGoodsEntity entity)
        {
            try
            {
                string sql = "select *from SellGoods";
                var query = Uy.GetData<SellGoods>(sql) as IEnumerable<SellGoods>;
                if (entity.Gid != null)
                {
                    query = query.Where(a => a.Gid == entity.Gid);
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
        /// 更新商品销售数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateSellGoods(SellGoodsEntity entity)
        {
            try
            {
                string sql = "select *from SellGoods where 1=1";
                int i = 0;
                if (entity.Sgid != null)
                {
                    sql += " and sgid=" + entity.Sgid;

                    var data = Uy.GetData<SellGoods>(sql).FirstOrDefault();

                    data.Gid = entity.Gid == null ? data.Gid : entity.Gid;
                    data.Uid = entity.Uid == null ? data.Uid : entity.Uid;
                    data.Sellcount = entity.Sellcount == null ? data.Sellcount : data.Sellcount += entity.Sellcount;
                    data.Selltime = DateTime.Now;
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
        private string SqlString(SellGoodsEntity entity)
        {
            if (entity.Sgid != null)
            {
                string update = "UPDATE SellGoods  SET Gid={0} ,Uid={1},Sellcount={2},selltime='{3}',Sgmark='{4}' WHERE Sgid={5}";
                update = string.Format(update, entity.Gid, entity.Uid, entity.Sellcount, entity.Selltime, entity.Sgmark, entity.Sgmark);
                return update;
            }
            else
            {
                string insert = "  insert into SellGoods  (Gid,Uid,Sellcount,selltime,Sgmark)" +
                  "values({0},{1},{2},{3},'{4}');";
                insert = string.Format(insert, entity.Gid, entity.Uid, entity.Sellcount, entity.Selltime, entity.Sgmark);
                return insert;
            }
        }
    }
}
