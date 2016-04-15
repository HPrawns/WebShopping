using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BaseClass
{
    [Serializable]
    /// <summary>
    /// 用户类
    /// </summary>
    public class UserInfo
    {
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
        private string username;
        /// <summary>
        /// 用户名
        /// </summary>
        [DataContextAttribute("UserName")]
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        private string loginname;
        /// <summary>
        /// 登录名
        /// </summary>
        [DataContextAttribute("LoginName")]
        public string LoginName
        {
            get { return loginname; }
            set { loginname = value; }
        }
        private string loginpwd;
        /// <summary>
        /// 登录密码
        /// </summary>
        [DataContextAttribute("LoginPwd")]
        public string LoginPwd
        {
            get { return loginpwd; }
            set { loginpwd = value; }
        }
        private string userlevel;
        /// <summary>
        /// 用户等级
        /// </summary>
        [DataContextAttribute("Userlevel")]
        public string Userlevel
        {
            get { return userlevel; }
            set { userlevel = value; }
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

        private string certificates;
        /// <summary>
        /// 证件类型
        /// </summary>
        [DataContextAttribute("Certificates")]
        public string Certificates
        {
            get { return certificates; }
            set { certificates = value; }
        }

        private string certificatesid;
        /// <summary>
        /// 证件号码
        /// </summary>
        [DataContextAttribute("Certificatesid")]
        public string Certificatesid
        {
            get { return certificatesid; }
            set { certificatesid = value; }
        }
        private string addresscontact;
        /// <summary>
        /// 联系地址
        /// </summary>
        [DataContextAttribute("Addresscontact")]
        public string Addresscontact
        {
            get { return addresscontact; }
            set { addresscontact = value; }
        }
        private string address1;
        /// <summary>
        /// 联系地址1
        /// </summary>
        [DataContextAttribute("Address1")]
        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }
        private string address2;
        /// <summary>
        /// 联系地址2
        /// </summary>
        [DataContextAttribute("Address2")]
        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }
        private string address3;
        /// <summary>
        /// 联系地址1
        /// </summary>
        [DataContextAttribute("Address3")]
        public string Address3
        {
            get { return address3; }
            set { address3 = value; }
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
        private string content;
        /// <summary>
        /// 用户说明
        /// </summary>
        [DataContextAttribute("Content")]
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        private string umark;
        /// <summary>
        /// 用户备注
        /// </summary>
        [DataContextAttribute("Umark")]
        public string Umark
        {
            get { return umark; }
            set { umark = value; }
        }
        private Nullable<DateTime> logindate;
        /// <summary>
        /// 登录时间
        /// </summary>
        [DataContextAttribute("LoginDate")]
        public Nullable<DateTime> LoginDate
        {
            get { return logindate; }
            set { logindate = value; }
        }
    }
}
