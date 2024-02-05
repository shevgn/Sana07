namespace ClassLibrary1;

public class ShoppingCart
{
    private List<Product> shoppingList = new List<Product>();
    
    public void AddToCart(Product product)
    {
        shoppingList.Add(product);
    }

    public void DisplayAll()
    {
        foreach (var product in shoppingList)
        {
            product.Display();
        }
    }

    public decimal CountPrice()
    {
        decimal totalPrice = 0;
        foreach (var product in shoppingList)
        {
            totalPrice += product.Price;
        }
        
        Console.WriteLine($"Summary price {totalPrice}$");
        return totalPrice;
    } 
}