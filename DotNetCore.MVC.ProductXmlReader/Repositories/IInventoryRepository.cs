using DotNetCore.MVC.ProductXmlReader.Models;

namespace DotNetCore.MVC.ProductXmlReader.Repositories
{
    public interface IInventoryRepository
    {
        Inventory GetInventory();
    }
}