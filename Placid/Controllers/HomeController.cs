using Microsoft.AspNetCore.Mvc;
using Placid.Models;
using System.Diagnostics;

namespace Placid.Controllers
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
            return View();
        }


        public IActionResult test9()
        {
            return View();
        }

 

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }


        public IActionResult Read()
        {
            return View();
        }


        public IActionResult Calender()
        {
            return View();
        }

        public IActionResult Homes()
        {
            return View();
        }

        public IActionResult Location()
        {
            return View();
        }

        public IActionResult ParkPlan()
        {
            return View();
        }


        public IActionResult Rules()
        {
            return View();
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
