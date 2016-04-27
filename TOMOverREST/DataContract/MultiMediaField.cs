using System.Xml.Serialization;

namespace TOR.DataContract
{
    public class MultiMediaField : LinkField
    {
        [XmlIgnore]
        public byte[] Content { get; set; }
        public MultiMediaField()
            : base()
        {
            FieldType = "Image";
        
        }
    }
}
