using Microsoft.AspNetCore.Mvc;
using Mission08_Team0301.Models;
using System.Diagnostics;

namespace Mission08_Team0301.Controllers
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

        public IActionResult Task()
        {
            return View();
        }

        public IActionResult Quadrants()
        {
            return View();
        }
    }
}
