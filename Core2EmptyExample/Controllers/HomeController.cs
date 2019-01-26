using Core2EmptyExample.Models;
using Microsoft.AspNetCore.Mvc;

namespace Core2EmptyExample.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new string[] { "Robin", "Blue Tit", "Great Tit" });
        }

        public ViewResult Products ()
        {
            //List<string> results = new List<string>();

            //foreach(Product p in Product.GetProducts())
            //{
            //    string name = p?.Name;
            //    decimal? price = p?.Price;
            //    string related = p?.RelatedProduct?.Name;

            //    results.Add(string.Format("Name: {0}, Price: {1:c}, Related {2}", 
            //        name, price, related));
            //}

            return View(Product.GetProducts());
        }
    }
}
