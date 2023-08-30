using LogisticService.Data.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Web;

namespace LogisticService.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly GoogleMapsOptions _options;

        public ScheduleController(IOptions<GoogleMapsOptions> options)
        {
            _options = options.Value;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetDefaultMapOptions()
        {
            using (var httpClient = new HttpClient())
            {
                var ip = HttpContext.Connection.LocalIpAddress;
                var address = new Uri(_options.GetCurrentLocation + ip);
                var result = httpClient.GetAsync(address).Result;
                if (result.IsSuccessStatusCode)
                {
                    return Json(result.Content.ReadAsStringAsync().Result);
                }
                else return Json("");
            }
           
        }
    }
}
