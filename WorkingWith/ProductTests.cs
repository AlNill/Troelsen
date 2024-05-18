using WorkingWith.Chapter6.Models;

namespace WorkingWith.Tests;

public class ProductTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void CanChangeProductName() 
    { 
        //Arrange
        var p = new Product { Name = "Test", Price = 100M };
        //Act
        p.Name = "New Name";
        //Asset
        Assert.That(p.Name, Is.EqualTo("New Name"));
    }

    [Test]
    public void CanChangeProductPrice()
    {
        //Arrange
        var p = new Product { Name = "Test", Price = 100M };
        //Act
        p.Price = 200M;
        //Asset
        Assert.That(p.Price, Is.EqualTo(200M));
    }
}
