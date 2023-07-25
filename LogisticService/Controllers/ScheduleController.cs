using Microsoft.AspNetCore.Mvc;

namespace LogisticService.Controllers
{
    public class ScheduleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
