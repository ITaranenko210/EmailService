using LogisticService.Data.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Text.Json;
using System.Web;

namespace LogisticService.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly ITestOptions _options;

        public ScheduleController(ITestOptions options)
        {
            _options = options;
        }
        public IActionResult Index()
        {
            return View(_options.GetOptions());
        }
    
        public string GetDefaultMapOptions()
        {
            using (var httpClient = new HttpClient())
            {
               
                var ip = Request.HttpContext.Connection.RemoteIpAddress;
                var mapOptions = _options.GetOptions();
                //var ip = HttpContext.Connection.LocalIpAddress;
                var address = new Uri(mapOptions.GetCurrentLocation + "172.56.3.235");//+ ip);
                var result = httpClient.GetAsync(address).Result;
                if (result.IsSuccessStatusCode)
                {
                    var response = result.Content.ReadAsStringAsync().Result;
                    return response;
                }
                else return string.Empty;
            }
           
        }
    }
}
