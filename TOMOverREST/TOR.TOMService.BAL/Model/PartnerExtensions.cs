using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Blackboard.PartnershipSyncService.BAL.Model
{
    [DataContract]
    [Serializable]
    public class PartnerExtensions
    {
        //Partner Extension type - TCM:23-7662-512 - Single Selection
        [XmlElement("item_type")]
        [DataMember]
        public List<string> item_type { get; set; }

        [XmlElement("ext_id")]
        [DataMember]
        public string ext_id { get; set; }

        [XmlElement("ext_name")]
        [DataMember]
        public string ext_name { get; set; }

        //Partner Extension category - TCM:23-7659-512 - MultiSelection
        [XmlElement("ext_category")]
        [DataMember]
        public List<string> ext_category { get; set; }

        //Partner Extension category - TCM:23-1009-512 - MultiSelection
        [XmlElement("ext_market")]
        [DataMember]
        public List<string> ext_market{get;set;}

        //Partner Extension category - TCM:23-1011-512 - MultiSelection
        [XmlElement("ext_platform")]
        [DataMember]
        public List<string> ext_platform { get; set; }


        //Partner Extension category - TCM:23-7600-512 - Single Selection
        [XmlElement("ext_lic")]
        [DataMember]
        public List<string> ext_lic { get; set; }

        /* Include new fields as per the new SQL query date 21 july 2015*/
        [XmlElement("small-logo")]
        [DataMember]
        public string smalllogo { get; set; }

        [XmlElement("large-logo")]
        [DataMember]
        public string largelogo { get; set; }

        [XmlElement("contact-information")]
        [DataMember]
        public string contactinformation { get; set; }

        [XmlElement("long-description")]
        [DataMember]
        public string longdescription { get; set; }

        [XmlElement("short-description")]
        [DataMember]
        public string shortdescription { get; set; }

        [XmlElement("ext_persona")]
        [DataMember]
        public List<string> ext_persona { get; set; }
        /*  End of Updated code date 21 july 2015*/

        [XmlElement("ext_req")]
        [DataMember]
        public string ext_req { get; set; }

        [XmlElement("ext_screenshot")]
        [DataMember]
        public string ext_screenshot { get; set; }
       

        //Partner Extension category - TCM:23-7661-512 - MultiSelection
        [XmlElement("ext_vsupported")]
        [DataMember]
        public List<string> ext_vsupported { get; set; }

        [XmlElement("ext_lastmodDT")]
        [DataMember]
        public string ext_lastmodDT { get; set; }

        [XmlElement("prt_id")]
        [DataMember]
        public string prt_id { get; set; }

        [XmlElement("prt_partner")]
        [DataMember]
        public string prt_partner { get; set; }

        [XmlElement("prt_partnerlogo")]
        [DataMember]
        public string prt_partnerlogo { get; set; }

        [XmlElement("prt_type")]
        [DataMember]
        public string prt_type { get; set; }

        [XmlElement("prt_desc")]
        [DataMember]
        public string prt_desc { get; set; }

        [XmlElement("prt_partnerurl")]
        [DataMember]
        public string prt_partnerurl { get; set; }

        [XmlElement("prt_lastmodDT")]
        [DataMember]
        public string prt_lastmodDT { get; set; }
    }
    
}
