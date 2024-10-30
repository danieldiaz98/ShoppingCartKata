using FluentAssertions;
using NUnit.Framework;

namespace ShoppingCart.Business.Test
{
    public class UnitTest1
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
    }

    public class ShoppingCart()
    {

        public int Calculate()
        {
            return 0;
        }

    }
}