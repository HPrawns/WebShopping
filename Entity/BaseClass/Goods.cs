using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    [Serializable]
    /// <summary>
    /// 商品表实体
    /// </summary>
    public class Goods
    {
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
        private string goodsname;
        /// <summary>
        /// 商品表名称
        /// </summary>
        [DataContextAttribute("GoodsName")]
        public string GoodsName
        {
            get { return goodsname; }
            set { goodsname = value; }
        }
        private string goodscode;

        /// <summary>
        /// 商品表编码
        /// </summary>
        [DataContextAttribute("GoodsCode")]
        public string GoodsCode
        {
            get { return goodscode; }
            set { goodscode = value; }
        }
        private string goodstype;

        /// <summary>
        /// 商品类型
        /// </summary>
        [DataContextAttribute("GoodsType")]
        public string GoodsType
        {
            get { return goodstype; }
            set { goodstype = value; }
        }
        private decimal goodsprice;

        /// <summary>
        /// 商品价格
        /// </summary>
        [DataContextAttribute("GoodsPrice")]
        public decimal GoodsPrice
        {
            get { return goodsprice; }
            set { goodsprice = value; }
        }
        private string goodsimg;

        /// <summary>
        /// 商品图片路径
        /// </summary>
        [DataContextAttribute("GoodsImg")]
        public string GoodsImg
        {
            get { return goodsimg; }
            set { goodsimg = value; }
        }
        private string goodsinfo;

        /// <summary>
        /// 商品说明
        /// </summary>
        [DataContextAttribute("GoodsInfo")]
        public string GoodsInfo
        {
            get { return goodsinfo; }
            set { goodsinfo = value; }
        }
        private string goodsmark;
        /// <summary>
        /// 商品备注
        /// </summary>
        [DataContextAttribute("GoodsMark")]
        public string GoodsMark
        {
            get { return goodsmark; }
            set { goodsmark = value; }
        }
        private string goodsplace;
        /// <summary>
        /// 商品产地
        /// </summary>
        [DataContextAttribute("GoodsPlace")]
        public string GoodsPlace
        {
            get { return goodsplace; }
            set { goodsplace = value; }
        }
        private decimal goodsscore;
        /// <summary>
        /// 商品累计评分
        /// </summary>
        [DataContextAttribute("GoodsScore")]
        public decimal GoodsScore
        {
            get { return goodsscore; }
            set { goodsscore = value; }
        }
        private bool isenabled;
        /// <summary>
        /// 是否启用
        /// </summary>
        [DataContextAttribute("GoodsScore")]
        public bool isEnabled
        {
            get { return isenabled; }
            set { isenabled = value; }
        }


    }
}
