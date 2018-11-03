using DotNetCore.MVC.ProductXmlReader.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DotNetCore.MVC.ProductXmlReader.Controllers
{
    public class HomeController : Controller
    {
        private readonly string InventoryXmlFilePath = @"Data/inventory.xml";
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
