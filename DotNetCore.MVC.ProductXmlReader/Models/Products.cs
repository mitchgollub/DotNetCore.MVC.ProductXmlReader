using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotNetCore.MVC.ProductXmlReader.Models
{

    [XmlRoot(ElementName = "products")]
    public class Products
    {
        [XmlElement(ElementName = "product")]
        public List<Product> Product { get; set; }
    }
}
