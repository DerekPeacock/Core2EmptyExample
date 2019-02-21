using System;
using System.ComponentModel.DataAnnotations;


namespace Core2EmptyExample.Models
{
    public enum ProductCategories
    {
        WaterCraft,
        Clothing,
    }

    public class Product
    {
        public string Name { get; set; }

        [DisplayFormat(DataFormatString ="{0:c}")]
        public Nullable<decimal> Price { get; set; }

        public string Category { get; set; } = "Water Sports";

        public Product RelatedProduct { get; set; }

        public static Product[] GetProducts()
        {
            Product kayak = new Product { Name = "Kayak", Category = "Water Craft", Price = 275m };
            Product lifeJacket = new Product { Name = "Life Jacket", Price = 48.9m };

            kayak.RelatedProduct = lifeJacket;

            return new Product[] { kayak, lifeJacket, null };
        }
    }
}
