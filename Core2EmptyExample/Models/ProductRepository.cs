using System.Collections.Generic;

namespace Core2EmptyExample.Models
{
    public class ProductRepository
    {
        private static ProductRepository repository = new ProductRepository();

        private Dictionary<string, Product> products = new Dictionary<string, Product>();

        public static ProductRepository SharedRepository => repository;

        public ProductRepository()
        {
            var initialItems = new[]
            {
                new Product{ Name = "Kayak", Price = 275m },
                new Product{ Name = "Life Jacket", Price = 48.95m },
                new Product{ Name = "Soccer Ball", Price = 19.50m },
                new Product{ Name = "Corner Flag", Price = 34.95m },
            };

            foreach(var p in initialItems)
            {
                AddProduct(p);
            }
        }

        public IEnumerable<Product> Products => products.Values;

        public void AddProduct(Product p) => products.Add(p.Name, p);
    }
}
