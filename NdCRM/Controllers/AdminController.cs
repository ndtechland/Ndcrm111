using Microsoft.AspNetCore.Mvc;
using NdCRM.Models.admin_NDCrM;

namespace NdCRM.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly AdminNdcrMContext context;

        public AdminController(ILogger<AdminController> logger, AdminNdcrMContext Context)
        {
            _logger = logger;
            context = Context;
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
