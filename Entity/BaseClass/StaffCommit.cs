using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    /// <summary>
    /// 用户评论表
    /// </summary>
    [Serializable]
    public class StaffCommit
    {
        private int scid;
        /// <summary>
        /// 商品表主键
        /// </summary>
        [DataContextAttribute("Scid")]
        public int Scid
        {
            get { return scid; }
            set { scid = value; }
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

        private string commitinfo;
        /// <summary>
        /// 评论内容
        /// </summary>
        [DataContextAttribute("Commitinfo")]
        public string Commitinfo
        {
            get { return commitinfo; }
            set { commitinfo = value; }
        }
        private int sid;

        /// <summary>
        /// 回复员工ID
        /// </summary>
        [DataContextAttribute("Sid")]
        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private string backinfo;
        /// <summary>
        /// 评论回复
        /// </summary>
        [DataContextAttribute("Backinfo")]
        public string Backinfo
        {
            get { return backinfo; }
            set { backinfo = value; }
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
