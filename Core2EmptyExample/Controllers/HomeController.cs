using Core2EmptyExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            List<string> results = new List<string>();
            foreach(Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;

                results.Add(string.Format("Name: {0}, Price: {1:c}", name, price));
            }

            return View(results);
        }
    }
}
