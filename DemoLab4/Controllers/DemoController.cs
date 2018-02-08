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
            return View(id);
        }
    }
}