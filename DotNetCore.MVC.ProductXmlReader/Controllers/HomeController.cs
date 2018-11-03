using DotNetCore.MVC.ProductXmlReader.Models;
using DotNetCore.MVC.ProductXmlReader.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCore.MVC.ProductXmlReader.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInventoryRepository _inventoryRepository;

        public HomeController(IInventoryRepository inventoryRepository) 
        {
            _inventoryRepository = inventoryRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
