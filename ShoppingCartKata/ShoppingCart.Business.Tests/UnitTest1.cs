using FluentAssertions;
using NUnit.Framework;
using ShoppingCart.Business;

namespace ShoppingCart.Business.Tests
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
    
}