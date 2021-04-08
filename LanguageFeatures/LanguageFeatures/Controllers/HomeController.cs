using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // bool FilterByPrice(Product p)
        // {
        //     return (p?.Price ?? 0) >= 20;
        // }
        public async Task<ViewResult> Index()
        {
            #region 
            // //The null conditional operator allows for null values to be detected more elegantly(thanh lich) :).
            // List<string> results = new List<string>();
            // foreach (Product p in Product.GetProducts())
            // {
            //     // string name = p?.Name;
            //     // decimal? price = p?.Price;
            //     // string relatedName = p?.Related?.Name; 

            //     //Combining the Conditional and Coalescing Operators
            //     string name = p?.Name ?? "<No Name>";
            //     decimal? price = p?.Price ?? 0;
            //     string relatedName = p?.Related?.Name ?? "<None>";

            //     // results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            //     results.Add(string.Format("Name: {0}, Price: {1}, Related: {2}", name, price, relatedName));
            // }
            // return View(results);
            // // return View(new string[] { "C#", "Language", "Features" });

            //----------------------------------------------------------------
            // Using Object and Collection Initializers
            // string[] names = new string[3]; 
            // names[0] = "Bob"; 
            // names[1] = "Joe"; 
            // names[2] = "Alice"; 
            // return View("Index", names);

            // return View("Index", new string[] { "Bob", "Joe", "Alice" });
            //--------------------------------
            // Using an Index Initializer
            // Dictionary<string, Product> products = new Dictionary<string, Product> { 
            //     { "Kayak", new Product { Name = "Kayak", Price = 275M } }
            //   , { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
            // }; 
            // return View("Index", products.Keys);

            // Dictionary<string, Product> products = new Dictionary<string, Product> {
            //     ["Kayak"] = new Product { Name = "Kayak", Price = 275M }
            //   , ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            // };
            // return View("Index", products.Keys);

            //Pattern matching
            // object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            // decimal total = 0;
            // for (int i = 0; i < data.Length; i++)
            // {
            //     if (data[i] is decimal d)
            //     {
            //         total += d;
            //     }
            // }

            // return View("Index", new string[] { $"Total: {total:C2}" });

            //Pattern Matching in switch Statements
            // for (int i = 0; i < data.Length; i++) { 
            //     switch (data[i]) { 
            //         case decimal decimalValue: 
            //             total += decimalValue; 
            //             break; 
            //         case int intValue when intValue > 50:
            //             total += intValue; 
            //             break;
            //     }
            // }
            // return View("Index", new string[] { $"Total: {total:C2}" });
            // ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            // Product[] productArray = { new Product {Name = "Kayak", Price = 275M},
            //                            new Product {Name = "Lifejacket", Price = 48.95M} };
            // decimal cartTotal = cart.TotalPrices();
            // decimal arrayTotal = productArray.TotalPrices();
            // return View("Index", new string[] { 
            //     $"Cart Total: {cartTotal:C2}", 
            //     $"Array Total: {arrayTotal:C2}" });
            // Product[] productArray = {
            //         new Product {Name = "Kayak", Price = 275M},
            //         new Product {Name = "Lifejacket", Price = 48.95M},
            //         new Product {Name = "Soccer ball", Price = 19.50M},
            //         new Product {Name = "Corner flag", Price = 34.95M} };
            // decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            // decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrices();
            // decimal nameFilterTotal = productArray.FilterByName('S').TotalPrices();

            // // return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });
            // return View("Index", new string[] { 
            //       $"Price Total: {priceFilterTotal:C2}"
            //     , $"Name Total: {nameFilterTotal:C2}" });
            // / khoong cos cachs tiep can naof la lys tuongw
            // Func<Product, bool> nameFilter = delegate (Product prod)
            // {
            //     return prod?.Name?[0] == 'S';
            // };
            // decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrices();
            // decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPr
            // decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrices();
            // decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrices();
            // return View("Index", new string[] {$"Price TOTAL: {priceFilterTotal:C2}",
            //                                     $"Name Total: {nameFilterTotal:C2}"});


            // return View(Product.GetProducts().Select(p=> p?.Name));

            //Using anonymous type
            // var names = new [] { "Kayak", "Lifejacket", "Soccer ball"};
            // return View(names);
            // var products = new[] {
            //         new { Name = "Kayak", Price = 275M },
            //         new { Name = "Lifejacket", Price = 48.95M },
            //         new { Name = "Soccer ball", Price = 19.50M },
            //         new { Name = "Corner flag", Price = 34.95M } 
            //         };
            // return View(products.Select(p => p.Name));
            // return View(products.Select(p => p.GetType().Name));
            //Using Default Implementations in Interfaces
            // IProductSelection cart = new ShoppingCart(
            //     new Product { Name = "Kayak", Price = 275M },
            //     new Product { Name = "Lifejacket", Price = 48.95M },
            //     new Product { Name = "Soccer ball", Price = 19.50M },
            //     new Product { Name = "Corner flag", Price = 34.95M });
            // // return View(cart.Products.Select(p => p.Name));
            // return View(cart.Names);
            #endregion
            //Using Asynchronous Methods
            long? length = await MyAsyncMethods.GetPageLength();
            return View(new string[] { $"Length: {length}"
            });
        }

    }
}