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
        private static List<Product> productList = new List<Product>();

        public ProductController()
        {
            if (productList.Count == 0)
            {
                productList.Add(new Product
                {
                    ProductID = 100,
                    Name = "Kayak",
                    Description = "A boat for one person",
                    Price = 750M,
                    Quantity = 4,
                    Category = "Watercraft"
                });
                productList.Add(new Product
                {
                    ProductID = 101,
                    Name = "Duct Tape",
                    Description = "If it doesn't stick and should, use this",
                    Price = 6M,
                    Quantity = 10,
                    Category = "DIY"
                });
                productList.Add(new Product
                {
                    ProductID = 102,
                    Name = "WD-40",
                    Description = "If it sticks and shouldn't, use this",
                    Price = 7.50M,
                    Quantity = 20,
                    Category = "DIY"
                });
                productList.Add(new Product
                {
                    ProductID = 103,
                    Name = "Raspberry Pi",
                    Description = "Simple computer",
                    Price = 35M,
                    Quantity = 12,
                    Category = "Tech"
                });
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSampleProduct()
        {
            Product myProduct = new Product
            {
                ProductID = 100,
                Name = "Kayak",
                Description = "A boat for one person",
                Price = 750M,
                Quantity = 4,
                Category = "Watercraft"
            };
            return View("Details", myProduct);
        }

        public IActionResult ProductList(string searchTerm)
        {
            if (!string.IsNullOrEmpty(searchTerm))
            {
                return View(productList.FindAll(p => p.Category.Contains(searchTerm)));
            }
            return View(productList);
        }

        public IActionResult Details(int id)
        {
            var product = productList.Find(p => p.ProductID == id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound("Product not found");
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                productList.Add(product);
                return RedirectToAction("Index");
            }
            else
                return View(product);
        }
    }
}