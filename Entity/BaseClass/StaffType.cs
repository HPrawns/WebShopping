using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{

    /// <summary>
    /// 用户类型
    /// </summary>
    [Serializable]
    public class StaffType
    {
        private int stid;
        /// <summary>
        /// 商品表主键
        /// </summary>
        [DataContextAttribute("Stid")]
        public int Stid
        {
            get { return stid; }
            set { stid = value; }
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
        private string typecode;
        /// <summary>
        /// 类型编码
        /// </summary>
        [DataContextAttribute("Typecode")]
        public string Typecode
        {
            get { return typecode; }
            set { typecode = value; }
        }
        private string staffinfo;
        /// <summary>
        /// 种类说明
        /// </summary>
        [DataContextAttribute("Staffinfo")]
        public string Staffinfo
        {
            get { return staffinfo; }
            set { staffinfo = value; }
        }
        private string staffmark;
        /// <summary>
        /// 种类备注
        /// </summary>
        [DataContextAttribute("Staffmark")]
        public string Staffmark
        {
            get { return staffmark; }
            set { staffmark = value; }
        }

        private bool isenabled;
        /// <summary>
        /// 是否启用
        /// </summary>
        [DataContextAttribute("Staffmark")]
        public bool isEnabled
        {
            get { return isenabled; }
            set { isenabled = value; }
        }
    }
}
