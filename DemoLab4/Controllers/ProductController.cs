using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLab4.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoLab4.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            // Show the list of sample products

            return View();
        }

        public IActionResult ShowSampleProduct() {
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 750M,
                Quantity = 4,
                Category = "Watercraft"
            };
            return View(myProduct);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product p)
        {
            return View();
        }
    }
}