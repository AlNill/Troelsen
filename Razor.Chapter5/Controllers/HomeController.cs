using Microsoft.AspNetCore.Mvc;
using Razor.Chapter5.Models;

namespace Razor.Chapter5.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        Product product = new Product()
        {
            Id = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };
        ViewBag.StockLevel = 2;
        return View(product);
    }
}
