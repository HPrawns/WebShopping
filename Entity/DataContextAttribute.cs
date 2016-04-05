using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 自定特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class DataContextAttribute : Attribute
    {
        /// <summary>
        /// 自定义特性
        /// </summary>
        /// <param name="fieldname">数据表字段名称</param>
        public DataContextAttribute(string property) { this.property = property; }
        /// <summary>
        /// 数据表字段属性(实体属性)
        /// </summary>
        public string property { get; set; }
    }
}
