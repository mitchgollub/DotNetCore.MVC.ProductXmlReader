using System.Xml.Serialization;

namespace DotNetCore.MVC.ProductXmlReader.Models
{
    [XmlRoot(ElementName = "inventory")]
    public class Inventory
    {
        [XmlElement(ElementName = "products")]
        public Products Products { get; set; }
    }
}
