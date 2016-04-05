﻿using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Utility
    {
        /// <summary>
        /// 将datarow转换成实体
        /// </summary>
        /// <param name="obj">实体</param>
        /// <param name="row">数据表一行数据</param>
        public static void converttoentity(object obj, DataRow row)
        {
            ///得到obj的类型
            Type type = obj.GetType();
            ///返回这个类型的所有公共属性
            PropertyInfo[] infos = type.GetProperties();
            ///循环公共属性数组
            foreach (PropertyInfo info in infos)
            {
                ///返回自定义属性数组
                object[] attributes = info.GetCustomAttributes(typeof(DataContextAttribute), false);
                ///将自定义属性数组循环
                foreach (DataContextAttribute attribute in attributes)
                {
                    ///如果datarow里也包括此列
                    if (row.Table.Columns.Contains(attribute.property))
                    {
                        ///将datarow指定列的值赋给value
                        object value = row[attribute.property];
                        ///如果value为null则返回
                        if (value == DBNull.Value) continue;
                        ///将值做转换
                        if (info.PropertyType.Equals(typeof(string)))
                        {
                            value = row[attribute.property].ToString();
                        }
                        else if (info.PropertyType.Equals(typeof(int)))
                        {
                            value = Convert.ToInt32(row[attribute.property]);
                        }
                        else if (info.PropertyType.Equals(typeof(decimal)))
                        {
                            value = Convert.ToDecimal(row[attribute.property]);
                        }
                        else if (info.PropertyType.Equals(typeof(DateTime)))
                        {
                            value = Convert.ToDateTime(row[attribute.property]);
                        }
                        else if (info.PropertyType.Equals(typeof(double)))
                        {
                            value = Convert.ToDouble(row[attribute.property]);
                        }
                        else if (info.PropertyType.Equals(typeof(bool)))
                        {
                            value = Convert.ToBoolean(row[attribute.property]);
                        }
                        ///利用反射自动将value赋值给obj的相应公共属性
                        info.SetValue(obj, value, null);
                    }
                }
            }
        }
    }
}
