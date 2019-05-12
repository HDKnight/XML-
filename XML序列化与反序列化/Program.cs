using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using static XML序列化与反序列化.XMLEntityModel;

namespace XML序列化与反序列化
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = File.Open("../../test2.xml", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            //var list = XmlSerializeHelper.DeSerialize<AuditInfoModel>(text);
            //foreach(AuditInfoModel aim in list)
            //{

            //}
            //Console.WriteLine(list.ToString());
            XMLEntityModel xml = new XMLEntityModel();
            //反序列化xml
            //xml = Convert(text);
            xml = (XMLEntityModel)Deserialize(typeof(XMLEntityModel), text);
            foreach (Vehispara v in xml.VehisparaList)
            {
                Console.WriteLine("id:"+v.id);
                Console.WriteLine("hphm:" + v.hphm,Encoding.Default);
                Console.WriteLine("jylsh:"+v.jylsh);
                Console.WriteLine("jyjgbh:"+v.jyjgbh);
                Console.WriteLine("hpzl:"+v.hpzl);
                Console.WriteLine("shjg:" + v.shjg);
            }

            
            Console.WriteLine(xml.VehisparaList);
            Console.WriteLine();
        }

        #region 反序列化
        /// <summary>  
        /// 反序列化  
        /// </summary>  
        /// <param name="T">类型</param>  
        /// <param name="xml">XML字符串</param>  
        /// <returns></returns>  
        public static T Deserialize<T>(T t, string s)
        {
            using (StringReader sr = new StringReader(s))
            {
                XmlSerializer xz = new XmlSerializer(t.GetType());
                return (T)xz.Deserialize(sr);
            }
        }
        #endregion

        public static XMLEntityModel Convert(string xml)
        { //将xml反序列化成对象
            XMLEntityModel b = new XMLEntityModel();
            return Deserialize<XMLEntityModel>(b, xml);
        }

        /// <summary>  
        /// 反序列化  
        /// </summary>  
        /// <param name="type">类型</param>  
        /// <param name="xml">XML字符串</param>  
        /// <returns></returns>  
        public static object Deserialize(Type type, string xml)
        {
            try
            {
                using (StringReader sr = new StringReader(xml))
                {
                    XmlSerializer xmldes = new XmlSerializer(type);
                    return xmldes.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
