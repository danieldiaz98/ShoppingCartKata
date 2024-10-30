namespace ShoppingCart.Business;

public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public int Tax;

    public Product(string name, double price, int tax)
    {
        Name = name;
        Price = price;
        Tax = tax;
    }
}