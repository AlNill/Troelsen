using Microsoft.AspNetCore.Mvc;
using WorkingWith.Chapter6.Controllers;
using WorkingWith.Chapter6.Models;

namespace WorkingWith.Tests;

public class HomeControllerTests
{
    [Test]
    public void IndexActionModelIsComplete()
    {
        //Arrange
        var controller = new HomeController();
        //Act
        var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Product>;
        //Assert
        // This functional use in xUnit
        //Assert.Equals(
        //    SimpleRepository.SharedRepository.Products, 
        //    model, 
        //    Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name && p1.Price == p2.Price));
    }
}
