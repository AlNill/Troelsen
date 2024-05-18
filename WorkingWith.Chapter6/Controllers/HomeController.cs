using Microsoft.AspNetCore.Mvc;
using WorkingWith.Chapter6.Models;

namespace WorkingWith.Chapter6.Controllers;

public class HomeController : Controller
{
    SimpleRepository Repository = SimpleRepository.SharedRepository;
    public IActionResult Index()
    {
        var result = Repository.Products.Where(p => p?.Price < 50);
        return View(result);
    }

    [HttpGet]
    public IActionResult AddProduct() => View(new Product());

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {
        Repository.AddProduct(product);
        return RedirectToAction("Index");
    }
}
