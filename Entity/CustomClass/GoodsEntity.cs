using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Entity.CustomClass
{
    /// <summary>
    /// 商品类自定义
    /// </summary>
    public class GoodsEntity:Goods
    {

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
