using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace ShoppingCart.Business.Test
{
    public class ProductShould
    {
        [SetUp]
        public void SetUp()
        {

        }

        [TestCase("Lechuga", "Lechuga")]
        [TestCase("Tomate", "Tomate")]
        [TestCase("Pan", "Pan")]
        public void Retrieve_lechuga_given_lechuga_as_product_name(string name, string expected)
        {
            var product = new Product(name, 0, 0);

            var result = product.Name;

            result.Should().Be(expected);
        }
    }
}
