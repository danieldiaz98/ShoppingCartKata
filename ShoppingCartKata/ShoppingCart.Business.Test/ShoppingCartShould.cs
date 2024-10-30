using FluentAssertions;
using NUnit.Framework;
using ShoppingCart.Business;

namespace ShoppingCart.Business.Test
{
    public class ShoppingCartShould
    {
        private Product productLechuga;
        private Product productTomate;
        private Product productPan;
        [SetUp]
        public void SetUp()
        {
            productLechuga = new Product("Lechuga", 0, 0);
            productTomate = new Product("Tomate", 0, 0);
            productPan = new Product("Pan", 0, 0);

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
            shoppingCart.shoppingCart.Add(productLechuga);

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(1);
        }

        [Test]
        public void Return_two_if_there_are_two_products_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add(productLechuga);
            shoppingCart.shoppingCart.Add(productTomate);

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(2);
        }
        [Test]
        public void Return_three_if_there_are_three_products_in_the_shopping_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add(productLechuga);
            shoppingCart.shoppingCart.Add(productTomate);
            shoppingCart.shoppingCart.Add(productPan);

            var result = shoppingCart.shoppingCart.Count();

            result.Should().Be(3);
        }

        [Test]
        public void Return_lechuga_tomate_if_the_products_are_in_the_cart()
        {
            var shoppingCart = new ShoppingCart();
            shoppingCart.shoppingCart.Add(productLechuga);
            shoppingCart.shoppingCart.Add(productTomate);

            var result = shoppingCart.GetProductsInShoppingCart();

            result.Should().Be("Lechuga Tomate");
        }

    }
}