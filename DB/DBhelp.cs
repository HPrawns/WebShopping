using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    /// <summary>
    /// 数据库访问基类
    /// </summary>
    public class DBhelp
    {
        //连接地址
        private readonly string constr = "server=localhost;User Id=root;password=2432391;Database=WebShopping";

        /// <summary>
        /// 读取数据库 返沪datable类型
        /// </summary>
        /// <returns></returns>
        private DataTable GetTable(string str)
        {
            using (MySqlConnection connection = new MySqlConnection(constr))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter(str, connection);
                    da.Fill(ds, "ds");
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
