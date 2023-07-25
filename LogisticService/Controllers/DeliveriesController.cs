using Microsoft.AspNetCore.Mvc;

namespace LogisticService.Controllers
{
    public class DeliveriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
