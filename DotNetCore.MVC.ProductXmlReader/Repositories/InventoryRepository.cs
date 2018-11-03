using DotNetCore.MVC.ProductXmlReader.Models;
using System.IO;
using System.Xml.Serialization;

namespace DotNetCore.MVC.ProductXmlReader.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        private readonly string InventoryXmlFilePath = @"Data/inventory.xml";

        public Inventory GetInventory()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Inventory), new XmlRootAttribute("inventory"));
            string text = File.ReadAllText(InventoryXmlFilePath);
            StringReader stringReader = new StringReader(text);
            return (Inventory)xmlSerializer.Deserialize(stringReader);
        }
    }
}
