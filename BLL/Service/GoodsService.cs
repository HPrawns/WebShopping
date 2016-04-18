using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DB;
using Entity.CustomClass;
using System.Data;
using Entity.BaseClass;

namespace BLL.Service
{
    public class GoodsService
    {
        /// <summary>
        /// 获取商品数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsData(GoodsEntity entity)
        {

            return new DB_Goods().GetGoodsData(entity);
        }
        /// <summary>
        /// 获取商品数据(id)
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsDataByid(string gid)
        {
            return new DB_Goods().GetGoodsDataByid(gid);
        }
        /// <summary>
        /// 更新商品
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateGoods(GoodsEntity entity)
        {
            return new DB_Goods().UpdateGoods(entity);
        }

        /// <summary>
        /// 更新商品类型
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateGoodsType(GoodsTypeEntity entity)
        {
            return new DB_Option().UpdateGoodsType(entity);
        }
        public string test(GoodsEntity entity)
        {

            return new DB_Goods().test(entity);
        }
    }
}
