using LanguageFeatures.Chapter4.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Chapter4.Controllers;

public class HomeController: Controller
{
    public ViewResult Index()
    {
        var results = new List<string>();
        foreach(Product p in Product.GetProducts())
        {
            string name = p?.Name ?? "<No Name>";
            decimal? price = p?.Price ?? 0;
            string relatedName = p?.Related?.Name ?? "<None>";
            //results.Add(string.Format(
            //    "Name: {0}, Price: {1}, Related: {2}", 
            //    name, 
            //    price, 
            //    relatedName)
            //    );

            results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
        }
        return View(results);
    }
}
