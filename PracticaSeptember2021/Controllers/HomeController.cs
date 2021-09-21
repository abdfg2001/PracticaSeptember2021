using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PracticaSeptember2021.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSeptember2021.Controllers
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
            Interface_Class Plate = new Animal();
            Plate.Cook();
            return View("Index", Static_Class.result);
        }

        public IActionResult Listing()
        {           
            return View("Listing",Static_List.MyList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
