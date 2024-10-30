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
        public void Return_two_if_there_are_two_products_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add("Lechuga");
            shoppingCart.shoppingCart.Add("Tomate");

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(2);
        }
        [Test]
        public void Return_three_if_there_are_three_products_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add("Lechuga");
            shoppingCart.shoppingCart.Add("Tomate");
            shoppingCart.shoppingCart.Add("Pan");

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(3);
        }

        [Test]
        public void Return_lechuga_if_there_is_a_lechuga_inside_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddProductToShoppingCart("Lechuga");

            var result = shoppingCart.GetProductsInShoppingCart();

            result.Should().Be("Lechuga");
        }

        [Test]
        public void Return_lechuga_and_tomate_if_there_is_a_lechuga_and_a_tomate_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddProductToShoppingCart("Lechuga");
            shoppingCart.AddProductToShoppingCart("Tomate");

            var result = shoppingCart.GetProductsInShoppingCart();

            result.Should().Be("Lechuga Tomate");
        }

        [Test]
        public void Return_lechuga_tomate_and_pan_if_there_is_a_lechuga_a_tomate_and_pan_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.AddProductToShoppingCart("Lechuga");
            shoppingCart.AddProductToShoppingCart("Tomate");
            shoppingCart.AddProductToShoppingCart("Pan");

            var result = shoppingCart.GetProductsInShoppingCart();

            result.Should().Be("Lechuga Tomate Pan");
        }


    }
}