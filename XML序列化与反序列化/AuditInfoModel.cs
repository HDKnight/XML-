using System.Xml.Serialization;

namespace XML序列化与反序列化
{
    public class AuditInfoModel
    {
        public AuditInfoModel()
        {

        }

        private string shbtgyy;
        private string bhgdtdjyxm;
        private string bhgjxm;
        private string bhggwzp;
        private string bhgzlzp;
        private string bhgcyxm;
        private string bhcyzp;
        private string hphm;
        private string bhgdpjyxm;
        private string shjg;
        private string jylsh;
        private string jyjgbh;
        private string bhgwgjyxm;
        private string hpzl;

        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("shbtgyy")]
        public string Shbtgyy { get; set; }

        [XmlElement("bhgdtdjyxm")]
        public string Bhgdtdjyxm { get; set; }

        [XmlElement("bhgjxm")]
        public string Bhgjxm { get; set; }

        [XmlElement("bhggwzp")]
        public string Bhggwzp { get; set; }

        [XmlElement("bhgzlzp")]
        public string Bhgzlzp { get; set; }

        [XmlElement("bhgcyxm")]
        public string Bhgcyxm { get; set; }

        [XmlElement("bhcyzp")]
        public string Bhcyzp { get; set; }

        [XmlElement("hphm")]
        public string Hphm { get; set; }

        [XmlElement("bhgdpjyxm")]
        public string Bhgdpjyxm { get; set; }

        [XmlElement("shjg")]
        public string Shjg { get; set; }

        [XmlElement("jylsh")]
        public string Jylsh { get; set; }

        [XmlElement("jyjgbh")]
        public string Jyjgbh { get; set; }

        [XmlElement("bhgwgjyxm")]
        public string Bhgwgjyxm { get; set; }

        [XmlElement("hpzl")]
        public string Hpzl { get; set; }

        
    }
}
