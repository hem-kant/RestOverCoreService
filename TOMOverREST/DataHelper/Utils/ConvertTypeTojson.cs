using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOR.DataHelper.Utils
{
   public class ConvertTypeTojson
    {
       public static string ConvertXmlToJson(string listXml)
       {
          return JsonConvert.SerializeObject(listXml);
       }

       public static string ConvertObjectToJson(object listXml)
       {
           return JsonConvert.SerializeObject(listXml);
       }
    }
}
