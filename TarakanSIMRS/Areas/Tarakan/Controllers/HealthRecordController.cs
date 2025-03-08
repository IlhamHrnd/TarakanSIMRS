using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TarakanSIMRS.Areas.Tarakan.Controllers
{
    [Area("Tarakan")]
    [Authorize]
    public class HealthRecordController : BaseController
    {
        public IActionResult HealthRecord()
        {
            return View(baseModel);
        }
    }
}
