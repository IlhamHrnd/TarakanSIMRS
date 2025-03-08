using Microsoft.AspNetCore.Mvc;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    public class HealthRecordController : Controller
    {
        public IActionResult HealthRecord()
        {
            return View();
        }
    }
}
