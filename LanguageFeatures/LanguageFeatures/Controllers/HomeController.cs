using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var results = new List<string>();

            foreach (var product in Product.GetProducts())
            {
                string name = product?.Name;
                decimal? price = product?.Price;
                string relatedName = product?.Related?.Name;
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            }
            return View(results);
        }
    }
}
