namespace LanguageFeatures.Chapter4.Models;

public static class MyExtensionMethods
{
    public static decimal TotalPrices(this ShoppingCart cart)
    {
        decimal total = 0;
        foreach(Product product in cart.Products)
        {
            total += product?.Price ?? 0;
        }
        return total;
    }
}
