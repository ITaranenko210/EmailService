using LogisticService.Data.Options;
using LogisticService.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LogisticService.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITestOptions _options;
        public HomeController(ILogger<HomeController> logger, ITestOptions options)
        {
            _logger = logger;
            _options = options;
        }

        public IActionResult Index()
        {
            return View(_options.GetOptions());
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