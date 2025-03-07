using Microsoft.AspNetCore.Mvc;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    public class IndexController : Controller
    {
        private readonly IHttpContextAccessor _context;

        public IndexController(IHttpContextAccessor context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}
