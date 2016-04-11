using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.Data;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
namespace DB
{
    public class JsonHelp
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public string ToNewJson<T>(T t)
        {
            return JsonConvert.SerializeObject(t);
        }
        /// <summary>
        /// 序列化
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public string ToJson<T>(T t)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            ser.WriteObject(ms, t);
            string jsonString = Encoding.UTF8.GetString(ms.ToArray()).Replace("\"ExtProperties\":[],", "");
            ms.Close();

            string p = @"\\/Date\((\d+)\+\d+\)\\/";
            string p1 = @"\\\\\\/Date\((\d+)\+\d+\)\\\\\\/";
            MatchEvaluator me = new MatchEvaluator(ConvertJsonDateToDateString);
            Regex reg = new Regex(p);
            jsonString = reg.Replace(jsonString, me);
            reg = new Regex(p1);
            jsonString = reg.Replace(jsonString, me);
            return jsonString;

        }
        /// <summary>
        /// 将JSON序列化的时间由/Date(129449995678+0800)转为字符串
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        private string ConvertJsonDateToDateString(Match m)
        {
            string result = m.Groups[0].Value;
            if (!string.IsNullOrEmpty(m.Groups[1].Value))
            {
                DateTime dt = new DateTime(1970, 1, 1);
                dt = dt.AddMilliseconds(long.Parse(m.Groups[1].Value));
                dt = dt.ToLocalTime();
                result = dt.ToString();
            }
            return result;
        }
        /// <summary>
        /// JSON转实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jsonString"></param>
        /// <returns></returns>
        public  T ParseEntity<T>(string jsonString)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            json.MaxJsonLength = 536870912;
            return json.Deserialize<T>(jsonString);
        }
        /// <summary>
        /// 返回json格式数据
        /// </summary>
        /// <param name="success"></param>
        /// <param name="mess"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public string JsonMsg(bool success, string mess, int count)
        {
            var Mess = new Msg { success = success, mess = mess, count = count };
            return ToJson<Msg>(Mess);
        }
        public string JsonMsg<T>(bool success, string mess, int count, T t)
        {
            Msg<T> Mess = new Msg<T> { success = success, mess = mess, count = count, firstcontent = t };
            return ToJson<Msg<T>>(Mess);
        }
        public string JsonMsg<T>(bool success, string mess, int count, List<T> content)
        {
            Msg<T> Mess = new Msg<T> { success = success, mess = mess, count = count, content = content };
            return ToJson<Msg<T>>(Mess);
        }
    }



    public class Msg<T>
    {
        public bool success { get; set; }
        public string mess { get; set; }
        public int code { get; set; }
        public int count { get; set; }
        public List<T> content { get; set; }
        public T firstcontent { get; set; }

    }

    public class Msg
    {
        public bool success { get; set; }
        public string mess { get; set; }
        public int code { get; set; }
        public int count { get; set; }
    }
}