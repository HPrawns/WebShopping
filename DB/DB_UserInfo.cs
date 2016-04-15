using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.BaseClass;
using Entity.CustomClass;
namespace DB
{
    public class DB_UserInfo
    {
        Utility Uy = new Utility();
        DBhelp DB = new DBhelp();
        /// <summary>
        /// 获取用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string GetUserinfo(UserInfoEntity entity)
        {
            try
            {
                string sql = "select *from Userinfo";
                var query = Uy.GetData<UserInfo>(sql) as IEnumerable<UserInfo>;
                if (!string.IsNullOrEmpty(entity.UserName))
                {
                    query = query.Where(a => a.UserName == entity.UserName);
                }
                if (entity.isEnabled != null)
                {
                    query = query.Where(a => a.isEnabled == entity.isEnabled);
                }
                var list = query.Skip(entity.PageIndex).Take(entity.PageSize).ToList();
                return new JsonHelp().JsonMsg(true, "获取成功!", list.Count, list);
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "获取失败!" + ex.Message, 0);
            }
        }
        /// <summary>
        /// 更新用户数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public string UpdateUserinfo(UserInfoEntity entity)
        {
            try
            {
                string sql = "select *from UserInfo where 1=1";
                int i = 0;
                if (entity.Uid != null)
                {
                    sql += " and Sid=" + entity.Uid;

                    var data = Uy.GetData<UserInfo>(sql).FirstOrDefault();

                    data.LoginPwd = entity.LoginPwd == null ? data.LoginPwd : entity.LoginPwd;
                    data.Phone = entity.Phone == null ? data.Phone : entity.Phone;
                    data.Email = entity.Email == null ? data.Email : entity.Email;
                    data.Userlevel = entity.Userlevel == null ? data.Userlevel : entity.Userlevel;
                    data.Certificates = entity.Certificates == null ? data.Certificates : entity.Certificates;
                    data.Certificatesid = entity.Certificatesid == null ? data.Certificatesid : entity.Certificatesid;
                    data.Umark = entity.Umark;
                    data.Addresscontact = entity.Addresscontact;
                    data.Address1 = entity.Address1;
                    data.Address2 = entity.Address2;
                    data.Address3 = entity.Address3;
                    data.isEnabled = entity.isEnabled;
                    string strsql = SqlString(entity);
                    i = DB.Update(strsql);
                }
                else
                {
                    string strsql = SqlString(entity);
                    i = DB.Update(strsql);
                }
                if (i > 0)
                {
                    return new JsonHelp().JsonMsg(true, "保存成功!", 0);
                }
                else
                {
                    return new JsonHelp().JsonMsg(false, "保存失败!", 0);
                }
            }
            catch (Exception ex)
            {
                return new JsonHelp().JsonMsg(false, "保存失败!" + ex.Message, 0);
            }

        }
        /// <summary>
        /// 组装执行语句
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private string SqlString(UserInfoEntity entity)
        {
            if (entity.Uid == null)
            {
                string insert = "  insert into UserInfo  (UserName,LoginName,LoginPwd,Userlevel,Phone,Email,Certificates,Certificatesid,Addresscontact,Address1,Address2,Address3,Content,Umark,LoginDate,isEnabled)" +
                                      "values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15});";
                insert = string.Format(insert, entity.UserName, entity.LoginName, entity.LoginPwd, entity.Userlevel, entity.Phone, entity.Email, entity.Certificates, entity.Certificatesid,
                    entity.Addresscontact, entity.Address1, entity.Address2, entity.Address3, entity.Content, entity.Umark, entity.LoginDate, entity.isEnabled == true ? 1 : 0);
                return insert;
            }
            else
            {
                string update = "UPDATE UserInfo  SET UserName='{0}',LoginName='{1}',LoginPwd='{2}',Userlevel='{3}',Phone='{4}',Email='{5}',Certificates='{6}',Certificatesid='{7}'" +
                " Addresscontact='{8}' Address1='{9}',Address2='{10}',Address3='{11}' ,Content='{12}'   ,Umark='{13}' ,LoginDate={14} ,isEnabled={15} WHERE Scid={16}";
                update = string.Format(update, entity.UserName, entity.LoginName, entity.LoginPwd, entity.Userlevel, entity.Phone, entity.Email, entity.Certificates, entity.Certificatesid,
                    entity.Addresscontact, entity.Address1, entity.Address2, entity.Address3, entity.Content, entity.Umark, entity.LoginDate, entity.isEnabled == true ? 1 : 0, entity.Uid);
                return update;
            }
        }
    }
}
