using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    /// <summary>
    /// 商品销售表
    /// </summary>
    [Serializable]
    public class SellGoods
    {
        private int sgid;
        /// <summary>
        /// 商品销售表主键
        /// </summary>
        [DataContextAttribute("Sgid")]
        public int Sgid
        {
            get { return sgid; }
            set { sgid = value; }
        }

        private int gid;
        /// <summary>
        /// 商品表主键
        /// </summary>
        [DataContextAttribute("Gid")]
        public int Gid
        {
            get { return gid; }
            set { gid = value; }
        }
        private int uid;
        /// <summary>
        /// 用户表主键
        /// </summary>
        [DataContextAttribute("Uid")]
        public int Uid
        {
            get { return uid; }
            set { uid = value; }
        }

        private decimal sellcount;
        /// <summary>
        /// 销售数量
        /// </summary>
        [DataContextAttribute("Sellcount")]
        public decimal Sellcount
        {
            get { return sellcount; }
            set { sellcount = value; }
        }
        private Nullable<DateTime> selltime;
        /// <summary>
        /// 销售时间
        /// </summary>
        [DataContextAttribute("Sellcount")]
        public Nullable<DateTime> Selltime
        {
            get { return selltime; }
            set { selltime = value; }
        }
        private string sgmark;
        /// <summary>
        /// 备注说明
        /// </summary>
        [DataContextAttribute("Sellcount")]
        public string Sgmark
        {
            get { return sgmark; }
            set { sgmark = value; }
        }
    }
}
