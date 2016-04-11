using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    /// <summary>
    /// 商品种类
    /// </summary>
    [Serializable]
    public class GoodsType
    {
        private int gtid;
        /// <summary>
        /// 商品类型主键
        /// </summary>
        [DataContextAttribute("Gtid")]
        public int Gtid
        {
            get { return gtid; }
            set { gtid = value; }
        }
        private string parentcode;
        /// <summary>
        /// 父类型编码
        /// </summary>
        [DataContextAttribute("Parentcode")]
        public string Parentcode
        {
            get { return parentcode; }
            set { parentcode = value; }
        }
        private string selfcode;
        /// <summary>
        /// 类型编码
        /// </summary>
        [DataContextAttribute("Selfcode")]
        public string Selfcode
        {
            get { return selfcode; }
            set { selfcode = value; }
        }
        private string typename;
        /// <summary>
        /// 类型名称
        /// </summary>
        [DataContextAttribute("Typename")]
        public string Typename
        {
            get { return typename; }
            set { typename = value; }
        }
        private string goodsinfo;
        /// <summary>
        /// 类型说明
        /// </summary>
        [DataContextAttribute("Goodsinfo")]
        public string Goodsinfo
        {
            get { return goodsinfo; }
            set { goodsinfo = value; }
        }
        private string goodsmark;
        /// <summary>
        /// 类型说明
        /// </summary>
        [DataContextAttribute("Goodsmark")]
        public string Goodsmark
        {
            get { return goodsmark; }
            set { goodsmark = value; }
        }
        private bool isenabled;
        /// <summary>
        /// 是否启用
        /// </summary>
        [DataContextAttribute("isEnabled")]
        public bool isEnabled
        {
            get { return isenabled; }
            set { isenabled = value; }
        }
    }
}
