using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XML序列化与反序列化
{
    [XmlRoot("root")]
    public class XMLEntityModel
    {
        [XmlRoot("head")]
        public class Head
        {
            [XmlElement("code")]
            public string code { get; set; }

            [XmlElement("message")]
            public string message { get; set; }

            [XmlElement("rownum")]
            public string rownum { get; set; }


        }


        [XmlArray("body"), XmlArrayItem("vehispara")]
        public List<Vehispara> VehisparaList { get; set; }


        [XmlRoot("vehispara")]
        public class Vehispara
        {
            [XmlAttribute("id")]
            public string id { get; set; }

            [XmlElement("hphm")]
            public string hphm { get; set; }

            [XmlElement("shjg")]
            public string shjg { get; set; }

            [XmlElement("jyjgbh")]
            public string jyjgbh { get; set; }

            [XmlElement("jylsh")]
            public string jylsh { get; set; }

            [XmlElement("hpzl")]
            public string hpzl { get; set; }
        }
    }
}
