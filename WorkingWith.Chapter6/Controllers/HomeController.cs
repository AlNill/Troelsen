using Microsoft.AspNetCore.Mvc;
using WorkingWith.Chapter6.Models;

namespace WorkingWith.Chapter6.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(SimpleRepository.SharedRepository.Products);
}
