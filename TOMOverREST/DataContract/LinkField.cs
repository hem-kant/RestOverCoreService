using System.Xml.Serialization;
namespace TOR.DataContract
{
   public class LinkField : ContentItemBase
  {
      [XmlAttribute(AttributeName = "type", Namespace = "http://www.w3.org/1999/xlink")]
      public string Type { get { return _type; } set { _type = "simple"; } }

      [XmlAttribute(AttributeName = "title", Namespace = "http://www.w3.org/1999/xlink")]
      public string Title { get; set; }

      [XmlAttribute(AttributeName = "href", Namespace = "http://www.w3.org/1999/xlink")]
      public string Href { get; set; }

        private XmlSerializerNamespaces _xmlns;
        private string _type = "simple";
       public LinkField()
       {
           this.xmlns = new XmlSerializerNamespaces();
           this.xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
           //this.Type = "simple";
       
       }

       [XmlIgnore]
        public string FieldType { get; set; }

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns{
            set{ _xmlns = new XmlSerializerNamespaces ();
           _xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            }
            get { _xmlns = new XmlSerializerNamespaces ();
            _xmlns.Add("xlink", "http://www.w3.org/1999/xlink");
            return _xmlns;
            }
        }

    }
}
