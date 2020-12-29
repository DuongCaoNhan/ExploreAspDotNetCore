using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //The null conditional operator allows for null values to be detected more elegantly(thanh lich) :).
            List<string> results = new List<string>(); foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name;
                decimal? price = p?.Price;
                results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            }
            return View(results);
            // return View(new string[] { "C#", "Language", "Features" });
        }
    }
}