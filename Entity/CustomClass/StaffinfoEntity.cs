using Entity.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.CustomClass
{
    public class StaffinfoEntity : Staffinfo
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
