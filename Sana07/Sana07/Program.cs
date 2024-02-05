using ClassLibrary1;

try
{
    var laptop = new Laptop("Lenovo", 800m, 100, 16.7f, "Smart", "Silver");
    var phone = new Phone("Samsung", 300m, 250, "android", "A54");
    var backpack = new Backpack("Backpack", 149m, 175, 7.5f, "Grey");

    var shoppingCart = new ShoppingCart();

    shoppingCart.AddToCart(laptop);
    shoppingCart.AddToCart(phone);
    shoppingCart.AddToCart(backpack);

    shoppingCart.DisplayAll();
    shoppingCart.CountPrice();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}