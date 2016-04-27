using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TOR.TOMService.BAL.Utils
{
    public class ConvertTojson
    {
        public static string ConvertXmlToJson(XElement listXml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(listXml.ToString());
            return JsonConvert.SerializeXmlNode(doc);
        }

        public static string ConvertObjectToJson(object listXml)
        {
            return JsonConvert.SerializeObject(listXml);
        }
    }
}
