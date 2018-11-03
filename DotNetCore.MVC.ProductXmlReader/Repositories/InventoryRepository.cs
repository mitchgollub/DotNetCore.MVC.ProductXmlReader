using DotNetCore.MVC.ProductXmlReader.Models;
using System.IO;
using System.Xml.Serialization;

namespace DotNetCore.MVC.ProductXmlReader.Repositories
{
    public class InventoryRepository
    {
        private readonly string InventoryXmlFilePath = @"../Data/inventory.xml";

        public InventoryRepository()
        {
            XmlSerializer ser = new XmlSerializer(typeof(Inventory), new XmlRootAttribute("inventory"));
            string text = File.ReadAllText(InventoryXmlFilePath);
            StringReader stringReader = new StringReader(text);
            Inventory objOutput = (Inventory)ser.Deserialize(stringReader);
        }

        //public Inventory Get()
        //{
            
        //}
    }
}
