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

        [Test]
        public void Retrieve_lechuga_given_lechuga_as_product_name()
        {
            var product = new Product("Lechuga", 1.17);

            var result = product.Name;

            result.Should().Be("Lechuga");
        }

        [Test]
        public void Retrieve_tomate_given_tomate_as_product_name()
        {
            var product = new Product("Tomate", 1.17);

            var result = product.Name;

            result.Should().Be("Tomate");
        }

        [Test]
        public void Retrieve_pan_given_tomate_as_product_name()
        {
            var product = new Product("Pan", 1.17);

            var result = product.Name;

            result.Should().Be("Pan");
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
