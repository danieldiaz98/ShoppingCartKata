namespace ShoppingCart.Business;

public class ShoppingCart
{
    public List<Product> shoppingCart;
    public ShoppingCart()
    {
        shoppingCart = new List<Product>();
    }
    public int Calculate()
    {
        return 0;
    }

    public void AddProductToShoppingCart(Product product)
    {
        shoppingCart.Add(product);
    }

    public string GetProductsInShoppingCart()
    {
        string result = "";
        for (int i = 0; i < shoppingCart.Count; i++)
        {
            result += shoppingCart[i].Name + " ";
        }
        return result.TrimEnd();
    }

    public int GetTotalNumberOfProducts()
    {
        return shoppingCart.Count();
    }

}