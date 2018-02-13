using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DemoLab4.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            string greeting = "Hello from the Demo controller";
            return View("Index", greeting);
        }

        public IActionResult Page2(int id)
        {
            if (id < 10)
            {
                return View(id);
            }
            throw new Exception("Number too big");
        }

        public IActionResult Page3(string word, int count)
        {
            ViewData["Word"] = word;
            ViewData["Count"] = count;
            return View();
        }
    }
}