using System.Collections.Generic;
using System.Xml.Serialization;
namespace TOR.DataContract
{
    public abstract class ContentItemBase
    {
        [XmlIgnore]
        public string Name { get; set; }

        [XmlIgnore]
        public string URI { get; set; }

        [XmlIgnore]
        public ComponentInformation Information { get; set; }
        [XmlIgnore]
        public List<string> PublishTargets;
    }
}
