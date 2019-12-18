using Microsoft.AspNetCore.Mvc;
using DataTransferToView.Models;
using System.Collections.Generic;

namespace DataTransferToView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>()
            {
                new Category 
                {
                    CategoryID = 1,
                    CategoryName = "Beverages",
                    Description = "Soft drinks, coffees, teas, beers, and ales"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Condiments",
                    Description = "Sweet and savory sauces, relishes, spreads, and seasonings"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Confections",
                    Description = "Desserts, candies, and sweet breads"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Dairy Products",
                    Description = "Cheeses"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Grains/Cereals",
                    Description = "Breads, crackers, pasta, and cereal"
                },
                new Category
                {
                    CategoryID = 6,
                    CategoryName = "Meat/Poultry",
                    Description = "Prepared meats"
                },
                new Category
                {
                    CategoryID = 7,
                    CategoryName = "Produce",
                    Description = "Dried fruit and bean curd"
                },
                new Category
                {
                    CategoryID = 8,
                    CategoryName = "Seafood",
                    Description = "Seaweed and fish"
                }};
                
                ViewBag.Kategoriler = categories;

                return View(categories); //View'in 4 farklı kullanım şekli var. Yazarken kullanabiliriz.
        }
    }
}