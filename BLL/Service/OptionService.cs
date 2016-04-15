using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;
using Entity.CustomClass;
using DB;
namespace BLL.Service
{
   public class OptionService
    {

         /// <summary>
        /// 读取商品总类数据,参数的实体可配置分页
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetGoodsType(GoodsTypeEntity entity)
        {
            return new DB_Option().GetGoodsType(entity);
        }
    }
}
