using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core2EmptyExample.Models
{
    public class Product
    {
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }

        public Product RelatedProduct { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Price = 275m };
            Product lifeJacket = new Product { Name = "Life Jacket", Price = 48.9m };

            kayak.RelatedProduct = lifeJacket;

            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
