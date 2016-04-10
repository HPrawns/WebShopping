using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    /// <summary>
    /// 员工表
    /// </summary>
    [Serializable]
    public class Staffinfo
    {
        private int sid;

        /// <summary>
        /// 员工主键
        /// </summary>
        [DataContextAttribute("Sid")]
        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }
        private string staffname;
        /// <summary>
        /// 员工姓名
        /// </summary>
        [DataContextAttribute("StaffName")]
        public string StaffName
        {
            get { return staffname; }
            set { staffname = value; }
        }
        private string loginname;
        /// <summary>
        /// 帐号
        /// </summary>
        [DataContextAttribute("LoginName")]
        public string LoginName
        {
            get { return loginname; }
            set { loginname = value; }
        }
        private string loginpwd;
        /// <summary>
        /// 密码
        /// </summary>
        [DataContextAttribute("LoginPwd")]
        public string LoginPwd
        {
            get { return loginpwd; }
            set { loginpwd = value; }
        }
        private string stafftype;
        /// <summary>
        /// 员工类型
        /// </summary>
        [DataContextAttribute("StaffType")]
        public string StaffType
        {
            get { return stafftype; }
            set { stafftype = value; }
        }
        private string phone;
        /// <summary>
        /// 联系电话
        /// </summary>
        [DataContextAttribute("Phone")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private string email;
        /// <summary>
        /// 电子邮箱
        /// </summary>
        [DataContextAttribute("Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string smark;
        /// <summary>
        /// 备注说明
        /// </summary>
        [DataContextAttribute("Smark")]
        public string Smark
        {
            get { return smark; }
            set { smark = value; }
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
