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
        //private readonly string constr = "server=localhost;User Id=root;password=2432391;Database=world";
        private readonly string constr = "server=localhost;User Id=root;password=2432391;Database=webshopping";
        /// <summary>
        /// 读取数据库 返沪datable类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetTable(string str)
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
        /// <summary>
        /// 添,删 改, 返回受影响的行
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int Update(string sql)
        {
            int i = 0;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                i = cmd.ExecuteNonQuery();
            }
            return i;
        }

        /// <summary>
        /// 返回单条数据
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public Object Select(string sql)
        {
            Object i = "";
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(sql, con);
                i = cmd.ExecuteScalar();
            }
            return i;
        }
    }
}
