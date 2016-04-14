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
                return new JsonHelp().JsonMsg(true, "获取成功!", list.Count, list);
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "获取失败!" + ex.Message, 0);
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
