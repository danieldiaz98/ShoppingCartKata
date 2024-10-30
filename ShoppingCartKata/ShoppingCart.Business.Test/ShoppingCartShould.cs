using FluentAssertions;
using NUnit.Framework;
using ShoppingCart.Business;

namespace ShoppingCart.Business.Test
{
    public class ShoppingCartShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [Test]
        public void Return_zero_if_you_can_calculate_shopping_cart_price()
        {
            var shoppingCart = new ShoppingCart();

            var result = shoppingCart.Calculate();

            result.Should().Be(0);
        }

        [Test]
        public void Return_one_if_there_is_one_product_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add("Lechuga");

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(1);
        }

        [Test]
        public void Return_lechuga_if_there_is_a_lechuga_inside_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();

            var result = shoppingCart.GetProductsInShoppingCart();

            result.Should().Be("Lechuga");
        }

        
    }
}