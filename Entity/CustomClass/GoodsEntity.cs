﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;

namespace Entity.CustomClass
{
    /// <summary>
    /// 商品类自定义
    /// </summary>
    public class GoodsEntity : Goods
    {
        /// <summary>
        /// 当前页
        /// </summary>
        private int pageindex;
        public int PageIndex
        {
            get { return pageindex < 0 ? 0 : pageindex; }
            set { pageindex = value; }
        }
        /// <summary>
        /// 每页多少行
        /// </summary>
        public int PageSize { get; set; }
    }
}
