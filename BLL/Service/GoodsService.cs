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
        public List<Goods> GetGoodsData(GoodsEntity entity)
        {
         
            return new DB_Goods().GetGoodsData(entity);
        }

        public string test(GoodsEntity entity)
        {
       
            return new DB_Goods().test(entity);
        }
    }
}
