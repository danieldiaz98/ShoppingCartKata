namespace ShoppingCart.Business;

public class ShoppingCart
{
    public List<String> shoppingCart;
    public ShoppingCart()
    {
        shoppingCart = new List<String>();
    }
    public int Calculate()
    {
        return 0;
    }

    public string GetProductsInShoppingCart()
    {
        string result = "";
        for (int i = 0; i < shoppingCart.Count; i++)
        {
            result += shoppingCart[i] + " ";
        }
        return result.TrimEnd();
    }

}