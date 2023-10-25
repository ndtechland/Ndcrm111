using Microsoft.AspNetCore.Mvc;
using NdCRM.Models;
using NdCRM.Models.admin_NDCrM;
using System.Diagnostics;

namespace NdCRM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AdminNdcrMContext context;

        public HomeController(ILogger<HomeController> logger, AdminNdcrMContext Context)
        {
            _logger = logger;
            context = Context;
        }

        public IActionResult Index()
        {
            var data=context.Products.ToList();
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