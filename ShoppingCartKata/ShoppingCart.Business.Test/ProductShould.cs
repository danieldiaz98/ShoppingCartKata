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

        [TestCase("Lechuga", 1.17, "Lechuga")]
        [TestCase("Tomate", 1.17, "Tomate")]
        [TestCase("Pan", 1.17, "Pan")]
        public void Retrieve_lechuga_given_lechuga_as_product_name(string name, double price, string expected)
        {
            var product = new Product(name, price);

            var result = product.Name;

            result.Should().Be(expected);
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
