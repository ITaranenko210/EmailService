using LogisticService.Data.WorkCases;
using LogisticService.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogisticService.Controllers
{
    public class DeliveriesController : Controller
    {
        private readonly IWorkCaseRepository _context;
        
        public DeliveriesController(IWorkCaseRepository context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Get());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WorkCase delivery)
        {
            if (!ModelState.IsValid)
            {
                return View(delivery);
            }
            _context.Create(delivery);

            return RedirectToAction("Index");
        }
    }
}
