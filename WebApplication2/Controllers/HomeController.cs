using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // Home page
        public IActionResult Index()
        {
            return View();
        }

        // About page
        public IActionResult About()
        {
            return View();
        }

        // Services page
        public IActionResult Services()
        {
            return View();
        }

        // Contact page
        public IActionResult Contact()
        {
            return View();
        }

        // Privacy page (optional, from template)
        public IActionResult Privacy()
        {
            return View();
        }

        // Error page
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
