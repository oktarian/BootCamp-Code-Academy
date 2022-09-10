using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Northwind.web.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Northwind.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var nameType = "Bogor";
            return View("Index", nameType);
        }

        public IActionResult Privacy()
        {
            var hour = DateTime.Now.Hour;
            //ternary operation (seperti if else) 
            var greating = hour > 12 ? "Good Day" : "Good Morning";
            return View("Privacy",greating);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
