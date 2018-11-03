using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace DotNetCore.MVC.ProductXmlReader.Models
{
    [Serializable]
    [XmlRoot(ElementName = "product")]
    public class Product
    {
        [XmlAttribute("qty")]
        public int Quantity { get; set; }
        [XmlAttribute("price")]
        public decimal Price { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}