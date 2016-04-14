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
        /// 获取用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetSellGoods(SellGoodsEntity entity)
        {
            try
            {
                string sql = "select *from Userinfo";
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
    }
}
